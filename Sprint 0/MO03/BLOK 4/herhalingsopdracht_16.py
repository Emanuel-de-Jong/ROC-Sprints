#Made By Emanuel de Jong

from microbit import *

while True:
    display.show(Image.SAD)
    if accelerometer.was_gesture("shake"):
        display.show(Image.HAPPY)
        sleep(1000)