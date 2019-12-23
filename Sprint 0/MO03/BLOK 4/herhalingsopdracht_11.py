#Made By Emanuel de Jong

from microbit import *

while True:
    if pin0.is_touched():
        display.show(Image.HEART)