<!DOCTYPE html>
<html>
<head>
</head>
<body>
<p>~Give your BSN~</p>
<form method="post">
    <input type="text" name="bsn">
    <input type="submit" name="submit">
</form>
<br>
<?php
if(isset($_POST['submit'])){
    $bsn = $_POST['bsn'];
    if(!is_numeric($bsn)){
        echo 'Ongeldig! '.$bsn.' is geen nummer.';
    }elseif (strlen($bsn) != 9){
        echo 'Ongeldig! '.$bsn.' is geen 9 getalen lang.';
    }else{
        $bsnClone = $bsn;
        $sum = -1 * $bsnClone % 10;
        for ($multiplier = 2; $bsnClone > 0; $multiplier++) {
            $val = ($bsnClone /= 10) % 10;
            $sum += $multiplier * $val;
        }
        if (!($sum != 0 && $sum % 11 == 0)) {
            echo 'Ongeldig! ' . $bsn . ' voldoet niet aan de elfproef.';
        }else{
            echo 'Geldig!';
        }
    }
}
?>
</body>
</html>