<!DOCTYPE html>
<html>
<head>
</head>
<body>
<?php
$age = 18;
$string = <<<verschil
With double quotes, you display the content of the variable. E.g. "age = $age";
<br> With single quotes, you display the name of the variable itself. E.g age = '\$age';
verschil;
echo $string;
?>
</body>
</html>