from microbit import *
import random

#Made by Emanuel de Jong

a0 = Image("00000:"
           "00000:"
           "00900:"
           "00000:"
           "00000")
           
a1 = Image("90000:"
           "00000:"
           "00000:"
           "00000:"
           "00009")
           
a2 = Image("90000:"
           "00000:"
           "00900:"
           "00000:"
           "00009")
           
a3 = Image("90009:"
           "00000:"
           "00000:"
           "00000:"
           "90009")
           
a4 = Image("90009:"
           "00000:"
           "00900:"
           "00000:"
           "90009")
           
a5 = Image("90009:"
           "00000:"
           "90009:"
           "00000:"
           "90009")
           
dice = [a0, a1, a2, a3, a4, a5]

while True:
    display.show(Image.HAPPY)
    if accelerometer.was_gesture("shake"):
        display.show(dice, loop=True, wait=False, delay=100)
        sleep(4000)
        display.show(random.choice(dice))
        sleep(1500)
        sleep(10)