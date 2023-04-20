# Build for Play

## Final Video

## How to play
- This is a classic brick game. 
- Use the slide potentiometer to control the paddle and let the ball keep on hitting the brick the get the point.
- Some bricks need to be hit several times before they disappear and get score.
- Hitting the bricks can trigger random bonuses. Collecting them using paddle can earn extra points.
- When the game is over, press the button to restart.

## Game Interface
<img width="604" alt="game" src="https://user-images.githubusercontent.com/113642868/233463529-54f53d30-3b65-4258-818e-88af9ed48ea6.png">

## Physical Controller
![controller](https://user-images.githubusercontent.com/113642868/233463640-2929cc8d-b7b2-466b-8844-855e11269087.jpg)

## Arduino Code
```
#define slide A0
#define btn 2
int btnState = 0;
int slideValue = 0;
int value = 0;

void setup() {
  Serial.begin(115200);

  pinMode(slide, INPUT);
  pinMode(btn, INPUT);
}

void loop() {
  btnState = digitalRead(btn);
  slideValue = analogRead(slide);
  value = map(slideValue, 0, 1023, -3, 3);
  Serial.print(btnState);
  Serial.print(",");
  Serial.println(value);
  delay(30);                                                                       
}
```

## Debug
- When I tried to connect the arduino with unity for the first time, I found the frame rate was pretty low. It turned out that the delay time set in the arduino program was too long.

## Unity Code
