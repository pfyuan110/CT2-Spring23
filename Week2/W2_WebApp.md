# Project 1

## 1. Sensor
Flex senor<br>
Stretch sensor (technically)

## 2. Function
Collect data on the degree of neck bending and visualize it using p5js.

## 3. Connection
Still figuring out how to process and analog the data from stretch sensor, so I use flex sensor as a test.

![43115e301a688aee023a9b22c237fc9](https://user-images.githubusercontent.com/113642868/215972845-3e31568f-a30a-4129-b615-9573af1c0552.jpg)

## 4. Code of ESP32
The same as Week 1.

## 5. Code of p5js
`https://editor.p5js.org/pfyuan110/sketches/yYzrSy-_W`

## 6. Result
### Data
It seems like 5s interval is not suitablt for flex sensor. When the sensor was kept bent at the same status, its value would gradually decrease in a short time. 
![image](https://user-images.githubusercontent.com/113642868/215972047-8375feeb-e801-4cbd-ba1c-c0b75be8bd2c.png)

### Visualization
> Start building a small web app that would allow you to access the data and perceive it as meaningful information. See if your manner of presentation can reveal any hidden patterns or relationships in the data.
> 
Still working on the data collection. So the pattern could not show anything meaningful at this time.

![image](https://raw.githubusercontent.com/pfyuan110/CT2-Spring23/main/Week2/result%20of%20p5js.png)

### In Class Update
- Cord Stretch Sensor is better than sheet sensor.
- The degree of neck stretching is too subtle. So I decided to change the detection to my wrist and collect the data when using mouse, computer, and so on.
