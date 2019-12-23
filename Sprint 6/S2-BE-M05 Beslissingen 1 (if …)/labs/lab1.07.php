<?php


$boeken = array(
    array('titel' => 'Stoner', 'auteur' => 'John Williams', 'genre' => 'Fictie', 'prijs' => 19.99),
    array('titel' => 'De circel', 'auteur' => 'Dave Eggers', 'genre' => 'Fictie', 'prijs' => 22.50),
    array('titel' => 'Rayuela', 'auteur' => 'Cortazar', 'genre' => 'Fictie', 'prijs' => 25.50)
);

array_walk_recursive($boeken, 'prijsLijst');

function prijsLijst($item, $key){
    if ($key == 'prijs'){
        echo 'prijs: ' . $item . '<br>';
    }
}