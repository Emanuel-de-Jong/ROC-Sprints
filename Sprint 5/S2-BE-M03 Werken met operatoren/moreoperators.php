<?php
echo <<<TEXT
De ternary operator geeft de eerste waarde terug als de uitspraak goed is en de tweede als hij fout is (b.v.b (1 > 2 ? "banaan" : "watermeloen") geeft "banaan" terug).<br>
De dot operator is ervoor, om meerdere dingen in 1 echo te laten zien (b.v.b (echo "eerste text " . "tweede text") toont "eerste text tweede text").<br>
++ maakt de variabel 1 groter, -- maakt hem 1 kleiner (b.v.b (getal = 5; getal++; echo getal) toont 6).<br>
Als er een operator voor een = staat, word de variabel aan het begin van de berekening gezet (b.v.b (getal = 5; getal += 3; echo getal) toont 8). Dit kan voor +, -, *, / en %.
TEXT;
