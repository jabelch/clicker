clicker
=======

This is an exploit of the Response Card LCD "clicker" (or similar devices from Turning Technologies) using one of the 
many nRF24L01 wireless modules readily (and cheaply) available on e-bay.
These "clickers" are being used in applications where security is necessary, but it is lacking.
We aim to further expose the weaknesses found in this technology (see Previous Research) so users can make informed 
and responsible decisions with security in mind.
- Example Clicker:
http://www.turningtechnologies.com/response-solutions/responsecard-rf-lcd

While our current setup might seem focused and inaccessible to the majority of the public, 
this is just a simple demonstration of what can be done with some cheap hardware. 

We opted to use an Arduino given the previous research that was done. Given enough motivation, however,
another possible solution could be architected using a Raspberry Pi in conjunction with a phone, or possibly just
a phone with bluetooth thus eliminating the need for a larger laptop. 
Using such a setup would be virtually undetectable and would thwart a security response that restricts the use of laptops.
A device could even be left with an accomplice or unattended, allowing an attacker to work remotely.


###Hardware Requirements
- nRF24L01 Wireless Module:
http://www.ebay.com/sch/i.html?_trksid=p2047675.m570.l1313.TR11.TRC1.A0.XnRF24L01&_nkw=nRF24L01&_sacat=0&_from=R40

Using an Arduino to control the nRF24L01
- Arduino Mega (other models may require tweeking): http://arduino.cc/en/Main/arduinoBoardMega
- Arduino Software: http://arduino.cc/en/Main/Software


###Getting Started
- Install the Arduino Software
- Open 'answer.ino' and verify CSN, CE, and IRQ definitions.  Change these to your liking or particular setup.
- Connect your wireless module according to the definitions.  Remember, MOSI -> MOSI; MISO -> MISO.
- Compile and upload to your Arduino

###Connecting
- You can either use the serial monitor built in the Arduino Software, or another serial program like putty.
- Verify COM port.  Set connection speed to 115200
- If you use putty on Windows, you will need to specify 'Implicit CR in every LF' found in 'Terminal'.

###Previous research
- Original Reverse Engineer:
http://travisgoodspeed.blogspot.com/2010/07/reversing-rf-clicker.html

- Implementation:
http://www.taylorkillian.com/2012/11/turning-point-clicker-emulation-with.html

- Example Arduino Code:
https://code.google.com/p/taylor-killian/downloads/detail?name=answer-v1.zip

