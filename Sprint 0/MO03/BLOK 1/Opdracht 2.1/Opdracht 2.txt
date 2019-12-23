from microbit import *

while True:
    display.show(Image.SWORD)
    if button_a.is_pressed():
        display.show(Image.GHOST)
    elif button_b.is_pressed():
        display.show(Image.SKULL)