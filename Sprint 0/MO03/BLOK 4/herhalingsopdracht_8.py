#Made By Emanuel de Jong

from microbit import *

while True:
    if button_a.is_pressed():
        display.show(Image.HEART)