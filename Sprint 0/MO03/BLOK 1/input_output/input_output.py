from microbit import *

while True:
    if pin0.is_touched():
        display.show(Image.COW)
    elif pin1.is_touched():
        display.show(Image.RABBIT)
    elif pin2.is_touched():
        display.show(Image.DUCK)
    else:
        display.show(Image.SKULL)