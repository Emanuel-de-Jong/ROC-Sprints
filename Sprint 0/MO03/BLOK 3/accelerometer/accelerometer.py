# Made by Emanuel de Jong and Displayport (RazenGear/Vincent Gunnink)
from microbit import *

while True:
    x_acc = accelerometer.get_x()
    display.scroll(str(x_acc))
    sleep(500)
