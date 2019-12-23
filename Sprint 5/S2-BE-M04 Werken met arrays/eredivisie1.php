<?php
$clubs = array(
    array(1, "PSV", "Eindhoven", 18, 16, 1, 1),
    array(2, "Ajax", "Amsterdam", 18, 15, 2, 1),
    array(5, "AZ", "Alkmaar", 18, 8, 4, 6),
    array(8, "Heracles", "Almelo", 18, 8, 2, 8)
);
foreach ($clubs as $club){
    print_r($club);
    echo "<br>";
}