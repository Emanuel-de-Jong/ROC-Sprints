from microbit import *

i = 9

while i >= 1:
    display.show(str(i))
    sleep(1000)
    i -= 1
display.show(Image.HAPPY)