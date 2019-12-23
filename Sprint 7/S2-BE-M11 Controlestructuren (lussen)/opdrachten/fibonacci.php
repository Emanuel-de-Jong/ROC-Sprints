<?php
$numb1 = 0;
$numb2 = 1;
$numb3 = 0;
for ($i = 0; $i < 20; $i++){
    $numb3 = $numb1 + $numb2;
    echo $numb3 . ';';
    $numb1 = $numb2;
    $numb2 = $numb3;
}