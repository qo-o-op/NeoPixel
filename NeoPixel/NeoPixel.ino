#include <Adafruit_NeoPixel.h>

#define PIN 6
#define LEDS 28
Adafruit_NeoPixel leds(LEDS, PIN, NEO_GRB + NEO_KHZ800);
void setup() {
  // put your setup code here, to run once:
  leds.begin();
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  for (int i = 0; i < 16; i++)
    leds.setPixelColor(i, leds.Color(0, 10, 0));
  for(int i=16;i<28;i++)
    leds.setPixelColor(i, leds.Color(10, 0, 0));
  leds.show();
}
