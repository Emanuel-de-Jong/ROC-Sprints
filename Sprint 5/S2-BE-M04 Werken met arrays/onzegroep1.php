<?php

$leerlingnummers = ["0307897", "0308612", "0302077", "0311932", "0314452", "0308676"];

$voornaam = array('0307897' => "Emanuel", "0308612" => "Vincent", "0302077" => "Erel", "0311932" => "Job", "0314452" => "Rico", "0308676" => "Syon");

$achternaam = array('0307897' => "de Jong", "0308612" => "Gunnink", "0302077" => "Cetin", "0311932" => "van der Sluis", "0314452" => "Boerdam", "0308676" => "Foppen");

$woonplaats= array('0307897' => "Enschede", "0308612" => "Enschede", "0302077" => "Enschede", "0311932" => "Enschede", "0314452" => "Zutphen", "0308676" => "Borne");

$leeftijd= array('0307897' => "18", "0308612" => "17", "0302077" => "17", "0311932" => "16", "0314452" => "16", "0308676" => "16");

$nummer = $leerlingnummers[rand(0,5)];

echo "Voornaam: $voornaam[$nummer] <br>Achternaam: $achternaam[$nummer] <br>Woonplaats: $woonplaats[$nummer] <br>Leeftijd: $leeftijd[$nummer]";


?>