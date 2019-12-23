#Made By Emanuel de Jong

from microbit import *
import random

scissors = Image("00090:"
                 "90900:"
                 "09000:"
                 "90900:"
                 "00090")
                 
stone = Image("00000:"
              "09990:"
              "09990:"
              "09990:"
              "00000")

rps = [Image.SQUARE, scissors, stone]

while True:
    gesture = accelerometer.current_gesture()
    if gesture == "shake":
        display.show(random.choice(rps))