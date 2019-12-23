<!DOCTYPE html>
<html>
<head>
</head>
<body>
<form>
    <input type="submit" value="Gooi!">
</form>
<?php
$worp = array();
$getal = 0;
$totaal = 0;

for ($i = 0; $i < 5; $i++){
    $getal = rand(1, 6);
    array_push($worp, $getal);
    $totaal += $getal;
    echo $getal;
}

echo "<br>" . $totaal;
?>
</body>
</html>