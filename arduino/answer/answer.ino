#include <SPI.h>
#include "nRF24L01.h"
#include "macList.h"
#include "answer_strings.h"

//#define TYPE 0 //NANO
#define TYPE 1 //MEGA

#if TYPE == 0
//NANO SETTINGS
//MOSI 11, MISO 12, SCK 13 (see data sheet)
#define CSN 10
#define CE 9
#define IRQ 8

#elif TYPE == 1

//MEGA SETTINGS
#define CSN 53
#define CE 42
#define IRQ 41

#endif

#define MAX_RECORDS 200
#define MAC_SIZE 3
#define DATA_SIZE 1
#define PACKET_SIZE (MAC_SIZE + DATA_SIZE)
#define NUM_MACS (sizeof(mac) / MAC_SIZE)

#define STRING(x) (strcpy_P(tmp_string, (char *)x))
#define PRINT_STRING(y) (Serial.print(STRING(y)))

byte clickerMasterMAC[MAC_SIZE] = { 0x56, 0x34, 0x12 };
byte myMAC[MAC_SIZE] = { 0x99, 0x88, 0x77 };
byte oppositeMyMAC[MAC_SIZE] = { 0x77, 0x88, 0x99 };

//Specify mac address to send answer for.
byte bMac[MAC_SIZE] = {0x00, 0x01, 0x02};

struct {
  byte MAC[MAC_SIZE];
  byte answer[DATA_SIZE];
} record[MAX_RECORDS];

int numAnswers;
byte maxAnswer;
byte channel;
char string[20];
char tmp_string[50];
byte stats[256];
byte statusByte;
byte answer = '1';
byte trigger;
byte oldAnswer;
unsigned long time;

void setup() { 
 //Initialize serial and wait for port to open:
  Serial.begin(115200); 
  pinMode (CSN, OUTPUT);
  pinMode (CE, OUTPUT);
  pinMode (IRQ, INPUT);
  SPI.begin();
  SPI.setBitOrder(MSBFIRST);
  SPI.setClockDivider(SPI_CLOCK_DIV2);
  SPI.setDataMode(SPI_MODE0);
  channel = 47;
  help();
  receiveAsClickerMasterStart();
  newQuestion();
  time = millis();
  PRINT_STRING(FreeMemory);
  Serial.println(freeRam());
} 

void serialEvent(){
  byte readByte;
  int index;
  
  while(Serial.available()){
    readByte = Serial.read();
           if (readByte == 'r'){
      readAllRegisters();
    } else if (readByte == 'g'){
      PRINT_STRING(TrigRandMass);
      massSendAsClickerStart();
      trigger = 'r';
    } else if (readByte == 'c'){
      while(!Serial.available());
      answer = Serial.read();
      PRINT_STRING(ChangeAnswer);
      Serial.write(answer);
      PRINT_STRING(NewLine);
    } else if (readByte == 'm'){
      PRINT_STRING(TrigMass);
      massSendAsClickerStart();
      trigger = 'm';
    } else if (readByte == 's'){
      PRINT_STRING(TrigSingle);
      massSendAsClickerStart();
      trigger = 's';
    } else if (readByte == ';'){
      break;
    } else if (readByte == 't'){
      compileStats();
      showStats();
    } else if (readByte == 'n'){
      newQuestion();
      PRINT_STRING(ClearedStats);
    } else if (readByte == 'h'){
      help();
    } else if (readByte == 'f'){
      channel = 0;
      do {
        while(!Serial.available());
        readByte = Serial.read();
        if(readByte >= '0' && readByte <= '9')
          channel = (channel * 10) + (readByte - '0');
      } while(readByte != '.');
      PRINT_STRING(ChannelSet);
      Serial.println(channel);
      newQuestion();
      PRINT_STRING(ClearedStats);
      receiveAsClickerMasterStart();
    } else if (readByte == 'a'){
      trigger = 'a';
      PRINT_STRING(AutoAnswer);
    } else if (readByte == 'd'){
      trigger = 0;
      receiveAsClickerMasterStart();
      PRINT_STRING(DefaultMode);
    } else if (readByte == 'p'){
      dumpMACs();
    } else if (readByte == 'j'){
      trigger = 'j';
      jammer();
    } else if (readByte == 'b'){
      byte inputMac[MAC_SIZE];
      index = 0;
      memset(bMac, 0, MAC_SIZE);
      char hex = 0;
      char buf[] = {'0', 'x', '0', '0', 0}; //Null terminated string buffer
      do{
        while(!Serial.available()); //block until available
        readByte = Serial.read();
 
        if (index == 3){
          answer = readByte;
        }else{
          buf[2] = readByte;
          while(!Serial.available());
          buf[3] = Serial.read();
          inputMac[index] = strtol(buf, NULL, 0);
        }
        index += 1;
      }while(index < 4);
      //Now that we have our mac address and answer
      //Copy it to bMac and initiate massSendAsClickerStart
      //(following practice from parsing 's' above. Also added trigger b in loop code)
      memcpy(bMac,inputMac,MAC_SIZE);
      
      Serial.print("Received MAC: ");
      int digit;
      for(int j = 0; j < MAC_SIZE; j++){
        digit = (int)bMac[j];
        sprintf(string, STRING(MacsFormat), digit);
        Serial.print(string);
      }
      Serial.println();
      
      massSendAsClickerStart();
      trigger = 'b';
    } else if (readByte == 'l'){
       trigger = 'l'; //Runs the scan routine from loop 
    }
  }
}

void help(){
  for(int i = 0; i < (sizeof(Help)/50); i++)
    PRINT_STRING(&Help[i][0]);
}

void loop() {
  byte tmp;
  unsigned long tmp_time;
  
  //SCAN CHANNELS
  if (trigger == 'l'){
    unsigned long start_time;
    unsigned long curr_time;
    unsigned long timeout; 
    byte found_channel;
    found_channel = 0;
    
    Serial.println("Scanning For Channels");
    //Scan a bunch of times or until we found a channel
    for(byte scan = 0; scan < 10 && found_channel == 0; scan++){
      //Loop through 85 channels
      for(byte i = 1; i < 85 && found_channel == 0; i++){
        start_time = millis();
        curr_time = start_time;
        timeout = 10;
        scanChannels(i);
        //Block here until IRQ line goes low (receiving) OR we hit timeout
        while(digitalRead(IRQ) == HIGH && curr_time - start_time <= timeout){
          curr_time = millis();
        }
        if(digitalRead(IRQ) == LOW){
          found_channel = channel;
          trigger = 0;
          Serial.println("<channel>");
          Serial.println(channel);
          Serial.println("</channel>");
        }
      }
    }
    Serial.println("Stopped Scanning");
  }
  else if(trigger == 'r')
  {
    for(int i = 0; i < NUM_MACS; i++){
      tmp = (rand() % 10) + '0';
      repeatSendPacket(mac+(i*MAC_SIZE), &tmp);
    }
    PRINT_STRING(FinRandMass);
    receiveAsClickerMasterStart();
  } 
  else if(trigger == 'm')
  {
    for(int i = 0; i < NUM_MACS; i++){
      repeatSendPacket(mac+(i*MAC_SIZE), &answer);
    }
    PRINT_STRING(FinMass);
    receiveAsClickerMasterStart();
  }
  else if(trigger == 's')
  {
//    repeatSendPacket(myMAC,&answer);
    repeatSendPacket(oppositeMyMAC,&answer);
    PRINT_STRING(FinSingle);
    receiveAsClickerMasterStart();
  } 
  //Basically mimic trigger = 's', but for bMac
  else if(trigger == 'b')
  {
    repeatSendPacket(bMac, &answer);
    PRINT_STRING(FinSingle);
    receiveAsClickerMasterStart();
  }
  
  if(trigger == 0){
    while(digitalRead(IRQ) == LOW){
      recordAnswer();
    }
  }
  else if (trigger == 'a')
  {
    while(digitalRead(IRQ) == LOW){
      recordAnswer();
    }
    tmp_time = millis();
    if(tmp_time - time > 1500 || tmp_time < time){
      time = tmp_time;
      compileStats();
      if(oldAnswer != maxAnswer){
        oldAnswer = maxAnswer;
        massSendAsClickerStart();
        repeatSendPacket(oppositeMyMAC,&maxAnswer);
        PRINT_STRING(ChangedByAA);
        Serial.write(maxAnswer);
        PRINT_STRING(NewLine);
        receiveAsClickerMasterStart();
        PRINT_STRING(NewLine);
        trigger = 'a';
      }
    }
  }
  else if(trigger != 'j')
  {
    digitalWrite(CE,LOW);
  }
}
