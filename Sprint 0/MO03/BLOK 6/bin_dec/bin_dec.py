# Made By Emanuel de Jong

from microbit import *

array = []
answer = 0
times = 1

while True:
    if len(array) > 8:
        while True:
            display.show(Image.SAD)
	if button_a.is_pressed() and button_b.is_pressed() and len(array) == 8:
        for i in array:
            answer = i * times + answer
            times *= 2
            break
    if button_a.is_pressed():
        array.append(0)
    if button_b.is_pressed():
        array.append(1)
	sleep(100)
	
while True:
			if answer > 9:
				display.scroll(answer)
			else:
				display.show(answer)