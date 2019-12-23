#Made By Emanuel de Jong

from microbit import *

while True:
    if button_a.is_pressed():
        display.show(str(random.randint(1, 4)))
    if button_b.is_pressed():
        display.show(str(random.randint(5, 9)))