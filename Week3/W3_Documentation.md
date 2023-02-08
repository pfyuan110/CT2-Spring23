# Project 1

## 1. Sensor
Stretch sensor (Cord)

## 2. Function
Collect and visualize of right wrist motion data while using a computer.

## 3. Connection and Installation


## 4. Code of ESP32
```
#include "config.h"

#define stretchPin A2

AdafruitIO_Feed *myFlexFeed = io.feed("stretch_feed");

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

  int value = analogRead(stretchPin);

  Serial.print("Readding Stretch Value: ");
  Serial.println(value);
  
  if(currTimestamp % interval < prevTimestamp % interval){   //the measurment could never presicely to 0, so we need to compare
  Serial.print("Sending Stretch Value: ");
  Serial.println(value);
  myFlexFeed->save(value);
  }

  prevTimestamp = currTimestamp;
  //delay(5000);
}
````

## 5. Code of p5js
`https://editor.p5js.org/pfyuan110/sketches/_wYYSbwY_`

## 6. Data
Collected from 15:15 - 15: 45 at Feb.8.

## 7. Visualization


## 8. Attempts
#### Flex Sensor
When bending the sensor to maintain a certain status for a while, the data gradually decreased. It didn't achieve the data changes I wanted.
[See this document for details](Week2/W2_WebApp.md)
#### Stretch Sensor - sheet
It needs to pull very hard to see significant data changes. When I applied it to my body, the movement was not strong enough to make obvious change of data.
(installation pic)
