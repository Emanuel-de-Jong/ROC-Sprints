<?php
$vandaag = new DateTime("now");
echo "<br>Vandaag timestamp: ".$vandaag->getTimestamp();

$eenDag = 86400;
$begin2000 = DateTime::createFromFormat("d/m/Y", "1/1/2000");
$eind2000 = DateTime::createFromFormat("d/m/Y", "31/12/2000");

$begin = $begin2000->getTimestamp();
$einde = $eind2000->getTimestamp();
$dagenIn2000 = ($einde - $begin) / $eenDag;
echo "<br>Aantal dagin in 2000: ". $dagenIn2000;

//add DateInterval
$datum = new DateTime("2001-01-01");
echo"<br>Begindatum: " . $datum->format("Y-m-d");
$datum->add(new DateInterval("P10D"));
echo "<br> Tien dagen toevoegen: " .$datum->format("Y-m-d");
//substract DateInterval
$datum->sub(new DateInterval("P10D"));
echo "<br>Tien dagen weghalen: ". $datum->format("Y-m-d");

//Formatteren
$format = '%A %d %B %Y %H:%M:%S';
$geformatteerde_datum = strftime($format);
echo "<br>Geformatterde datum: ". $geformatteerde_datum;


//lokale datuminstelling
setlocale(LC_TIME, "NL_NL");
$ned = strftime($format);
echo "<br>In het nederlands: ".$ned;

//date_format verwerken
$datum = date_create("2000-01-01");
echo "<br>Datum formatteren: " . date_format($datum, "Y-m-d");
echo "<br>Datum formatteren: " . date_format($datum, "d-m-Y");

//date_diff
$factuurdatum = date_create("2018-10-10");
echo "<br>Factuurdatum: " .date_format($factuurdatum, "Y-m-d");
$vandaag = date_create("now");
echo "<br>Vandaag: " .date_format($vandaag, "Y-m-d");
$interval = date_diff($vandaag, $factuurdatum);
echo "<br>U heeft nog: " .$interval->format("%R%a dagen om te betalen");

$now = new Datetime();
$result = $now->format('Y-m-d');
$year = $now->format('y');
$kerst1 = "$year-12-25";
$kerst0 = strtotime($kerst1);
$current_date = strtotime($result);
$diffrence = $kerst0 - $current_date;
$days = floor($diffrence/(60*60*24));

echo "<br> het is vandaag: $result";
echo "<br> u heeft nog: $days dagen tot kerst";


 ?>
