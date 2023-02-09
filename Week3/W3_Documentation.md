# Project 1

## 1. Sensor
Stretch sensor (Cord)

## 2. Description
Collect and visualize of right wrist motion data while using a computer.

## 3. Connection and Installation
![image](https://github.com/pfyuan110/CT2-Spring23/blob/main/Week3/Installation_all.jpg)

## 4. Code of ESP32
```
#include "config.h"

#define stretchPin A2

AdafruitIO_Feed *myFlexFeed = io.feed("stretch_feed");

int interval = 5000;                  
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
  
  if(currTimestamp % interval < prevTimestamp % interval){  
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
Collected from 15:15 - 15: 45 at Feb.8.<br>

![image](https://user-images.githubusercontent.com/113642868/217677558-bbf6fc1d-5a9d-40fd-92f9-63c349496368.png)

## 7. Visualization
Interestingly, through the data and visulization pattern, I found that my wrist always keeps the same angle at most of working time, whether using keyboard or mouse.

## 8. Attempts
### Flex Sensor
When bending the sensor to maintain a certain status for a while, the data gradually decreased. It didn't achieve the data changes I wanted.<br>
[See this document for details](Week2/W2_WebApp.md)

### Stretch Sensor (Sheet)
It needs to pull very hard to see significant data changes. When I applied it to my body, the movement was not strong enough to make obvious change of data.<br>

![image](https://user-images.githubusercontent.com/113642868/217680994-3ffa843a-a58e-492f-8d48-bb22f4ebf99b.jpg)

### Different installation postition
I tried to put cord inside my hand. But the data pattern was not that ideal since the cord inside my hand was more likely to be affected by the movement and deviate from its original position, which affected the accuracy of the stretch.<br>
Collected from 15:50 - 16:05 at Feb.8.

![image](https://user-images.githubusercontent.com/113642868/217679960-964d5373-f520-4a6f-b5f3-15af985c9086.png)
