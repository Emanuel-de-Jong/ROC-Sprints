<?php
$randNumb = 0;
$counter = 0;
$average = 0;
do{
    $counter++;
    $throw = array();
    for ($i = 0; $i < 5; $i++){
        $randNumb = rand(1, 6);
        array_push($throw, $randNumb);
    }
    foreach ($throw as $numb){
        $average += $numb;
    }
}while (count(array_unique($throw)) != 1);
echo 'Het heeft ' . $counter . ' worpen geduurt om een yahtzee te krijgen<br>';
echo 'Het totaal gemiddelde per worp is ' . round(($average / $counter), 0) . '<br>';
echo 'Het getal dat 5 keer geworpen is, is ' . $throw[0];