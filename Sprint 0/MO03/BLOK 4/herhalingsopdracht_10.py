#Made By Emanuel de Jong

from microbit import *

while True:
    display.show(Image.HEART)
    if button_a.is_pressed():
        display.show(Image.HAPPY)
    elif button_b.is_pressed():
        display.show(Image.SAD)