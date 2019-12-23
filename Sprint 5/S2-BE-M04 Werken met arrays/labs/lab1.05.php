<?php
$array = array('een', 'twee', 3, 'vier');
array_push($array, 5);
echo 'Stap 3. ' . implode(",",$array) . '<br>';
echo 'Stap 4. Datatype is: ' . gettype($array[4]) . '<br>';
array_pop($array);
echo 'Stap 6. ' . implode(",",$array) . '<br>';
array_unshift($array, 'nul');
echo 'Stap 8. ' . implode(",",$array) . '<br>';
array_shift($array);
echo 'Stap 10. Datatype [0] is: ' . gettype($array[0]) . '<br>';
echo 'Stap 12. ' . implode(",",$array) . '<br>';
array_splice($array, 1, 1);
echo 'Stap 14. ' . implode(",",$array) . '<br>';
if(array_key_exists(2, $array)){
    array_splice($array, 2, 1);
}
echo 'Stap 16. ' . implode(",",$array) . '<br>';