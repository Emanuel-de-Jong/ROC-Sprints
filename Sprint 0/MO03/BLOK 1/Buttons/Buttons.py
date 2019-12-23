from microbit import *

aantal = 0

while True:
    display.show(Image.ARROW_W)
    if button_a.is_pressed():
        aantal += 1
        sleep(250)
    elif button_b.is_pressed():
        display.show(str(aantal))
        sleep(1000)
    elif button_a.is_pressed and button_b.is_pressed():
        aantal = 0
        display.scroll("RESET")