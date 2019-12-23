# Made by RazenGear
from microbit import *

steps = 0

while True:
    if steps < 10 and accelerometer.was_gesture("shake"):
        steps += 1
        sleep(150)
        display.show(str(steps))
    if steps > 9 and accelerometer.was_gesture("shake"):
        steps += 1
        sleep(150)
        display.scroll(str(steps))