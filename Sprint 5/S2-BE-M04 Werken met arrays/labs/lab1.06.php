<?php
$playlist = array(
    array('genre' => 'Hiphop', 'auteur' => 'John Williams', 'titel' => 'My Girl'),
    array('genre' => 'Jazz', 'auteur' => 'John Coltrane', 'titel' => 'New York'),
    array('genre' => 'Hiphop', 'auteur' => 'Shakira', 'titel' => 'Obsession')
);

array_walk_recursive($playlist, 'printArray');

$trackToAdd = array('genre' => 'Latin', 'auteur' => 'Caetano Veloso', 'titel' => 'Cafe Atlantico');
$playlist = array_merge($playlist, $trackToAdd);

echo '<br>';
printTrack($playlist);

function printArray($item, $key){
    echo "<br><i>$key: $item</i>";
}

function printTrack($tracks){
    $i = 0;
    foreach ($tracks as $track){
        echo "Track $i: ";
        echo implode("|", $track) . '<br>';
        $i++;
    }
}