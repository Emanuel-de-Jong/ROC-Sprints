#Made By Emanuel de Jong

from microbit import *

while True:
    if pin0.is_touched():
        display.show(Image.HEART)
    elif pin1.is_touched():
        display.show(Image.HAPPY)
    elif pin2.is_touched():
        display.show(Image.SAD)