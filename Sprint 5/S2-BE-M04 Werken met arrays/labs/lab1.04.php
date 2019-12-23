<?php
//student 1
$naam = "Karim";
$nederlands = "8.5";
$engels = "7.7";
$rekenen = "6.7";
$programmeren = "8.5";
$databases = "9.4";
//gemiddelde uitrekenen

$gemiddlede1 = ($nederlands + $engels + $programmeren + $rekenen + $databases) / 5;

//student 2
$naam2 = "Sophie";
$nederlands2 = "8.9";
$engels2 = "8.7";
$rekenen2 = "9.7";
$programmeren2 = "9.5";
$databases2 = "9.2";
//gemiddelde uitrekenen

$gemiddlede2 = ($nederlands2 + $engels2 + $programmeren2 + $rekenen2 + $databases2) / 5;

//Groeps Gemiddelde uitrekenen

$gemiddeldegroep = ($gemiddlede1 + $gemiddlede2) / 2;

echo "<table border='1'>
    <caption>
      <strong>Rapport</strong>
    </caption>
    <thead>
      <tr>
        <th>Naam</th><th>Nederlands</th><th>Engels</th>
        <th>Rekenen</th><th>Programmeren</th>
        <th>Databases</th>
        <th>Gemiddeld</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>$naam</td><td>$nederlands</td><td>$engels</td>
        <td>$rekenen</td><td>$programmeren</td>
        <td>$databases</td><td>$gemiddlede1</td>
      </tr>
      <tr>
        <td>$naam2</td><td>$nederlands2</td><td>$engels2</td>
        <td>$rekenen2</td><td>$programmeren2</td>
        <td>$databases2</td><td>$gemiddlede2</td>
      </tr>
    </tbody>
    <tfoot>
      <tr>
        <td colspan='6'>Groep gemiddeld</td><td>$gemiddeldegroep</td>
      </tr>
    </tfoot>
  </table>";

?>