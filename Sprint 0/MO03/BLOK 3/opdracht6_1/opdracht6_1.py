#Made By Emanuel de Jong

from microbit import *
import random

while True:
    display.show(Image.SQUARE)
    if accelerometer.was_gesture("shake"):
        display.show(str(random.randint(1,6)))
        sleep(1000)