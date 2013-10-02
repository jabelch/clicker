prog_char Authors[] PROGMEM = {  "Authors: \n\n\tJoshua Belcher \n\tJulie Jacobs \n\tSeth DeCato" };

void setup() {
  Serial.begin(115200);
  while(!Serial){
    ;//Wait for serial port to connect
  }
  
  Serial.println("Clicker Exploit");
  Serial.println(Authors);
}

void loop() {
  
}
