<?php
for ($i = 1; $i <= 100; $i++){
    if ($i % 2 == 1){
        if ($i == 99){
            echo $i;
            continue;
        }else{
            echo $i . ", ";
        }
    }
}