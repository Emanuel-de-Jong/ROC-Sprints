<!DOCTYPE html>
<html>
<head>
</head>
<body>
<?php
$kleuren = ["ruiten", "harten", "klaveren", "schoppen"];
$waardes = ["boer", "vrouw", "heer", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
for ($i = 0; $i < 5; $i++){
    $kleur = rand(0,3);
    $waarde = rand(0, 12);
    $kaart = $kleuren[$kleur] . "_". $waardes[$waarde];
    echo "<img src='http://localhost/Sprint5/S2-BE-M04/images/cards//$kaart.svg' style='width:100px;'> ";
}
?>
</body>
</html>