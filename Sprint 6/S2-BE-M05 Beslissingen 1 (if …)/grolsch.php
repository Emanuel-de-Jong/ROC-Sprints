<?php
$leeftijd = rand(10, 30);
if ($leeftijd >= 18){
    header("Location: https://www.grolsch.nl/agegate?returnUri=/");
}else{
    header("Location: https://www.alcoholinfo.nl/publiek");
}