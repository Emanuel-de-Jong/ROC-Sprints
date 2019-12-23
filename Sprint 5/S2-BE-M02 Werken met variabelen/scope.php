<!DOCTYPE html>
<html>
<head>
</head>
<body>
<?php
$string = <<<example
echo 'Lokale variabelen kunnen alleen in de functie in die ze toegewezen zijn worden gebruikt.<br>
Globale variabelen kunnen overal in het programma worden gebruikt.<br>
Om globale variabelen in functies te kunnen gebruiken moet je er "global" voor schrijfen:<br><br>
global \$foo = test;<br>
function Example()<br>
{<br>
&nbsp &nbsp global \$foo;<br>
&nbsp &nbsp echo \$foo;<br>
&nbsp &nbsp //outputs "test"<br>
}'
example;
echo $string;
?>
</body>
</html>