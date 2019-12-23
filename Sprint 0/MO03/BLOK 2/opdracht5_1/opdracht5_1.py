from microbit import *
import random

#Made by Emanuel de Jong

nameGirls = ["Maria"]
nameBoys = ["Vincent", "Thomas", "Pepijn", "Gusten", "Emanuel"]

while True:
    if button_a.was_pressed():
        display.scroll(random.choice(nameGirls))
    elif button_b.was_pressed():
        display.scroll(random.choice(nameBoys))