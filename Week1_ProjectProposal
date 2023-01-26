##Project 1

1. Sensor:
   Flex sensor

2. Function:
   Collect data on the degree of neck bending to check whether my neck bends too much and warn me

3. Connection:

4. Code:

#include "config.h"

#define flexPin A2

AdafruitIO_Feed *myFlexFeed = io.feed("flex_feed");

int interval = 5000;                  //equal to 10s
int prevTimestamp, currTimestamp = 0;

void setup() {
  Serial.begin(115200);

  while (! Serial);
  
  Serial.print("Connecting to Adafruit IO");
  io.connect();

  while (io.status() < AIO_CONNECTED) {
    Serial.print(".");
    delay(500);
  }

  Serial.println();
  Serial.println(io.statusText());
}

void loop() {
  io.run();

  currTimestamp = millis();

  int value = analogRead(flexPin);

  Serial.print("Readding Flex Value: ");
  Serial.println(value);
  
  if(currTimestamp % interval < prevTimestamp % interval){   //the measurment could never presicely to 0, so we need to compare
  Serial.print("Sending Flex Value: ");
  Serial.println(value);
  myFlexFeed->save(value);
  }

  prevTimestamp = currTimestamp;
  //delay(5000);
}
