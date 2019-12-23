<html>
<table border='1'>
    <caption>
        <strong>Onze Groep</strong>
    </caption>
    <thead>
    <tr>
        <th>Naam</th><th>Student Nummer</th><th>Woonplaats</th><th>Leeftijd</th>

    </thead>
    <tbody>
    <?php
    $leerlingnummers = ["0307897", "0308612", "0302077", "0311932", "0314452", "0308676"];

    $voornaam = array('0307897' => "Emanuel", "0308612" => "Vincent", "0302077" => "Erel", "0311932" => "Job", "0314452" => "Rico", "0308676" => "Syon");

    $achternaam = array('0307897' => "de Jong", "0308612" => "Gunnink", "0302077" => "Cetin", "0311932" => "van der Sluis", "0314452" => "Boerdam", "0308676" => "Foppen");

    $woonplaats= array('0307897' => "Enschede", "0308612" => "Enschede", "0302077" => "Enschede", "0311932" => "Enschede", "0314452" => "Zutphen", "0308676" => "Borne");

    $leeftijd= array('0307897' => "18", "0308612" => "17", "0302077" => "17", "0311932" => "16", "0314452" => "16", "0308676" => "16");

    $teller = -50;

    for ($i = 0; $i < count($leerlingnummers); $i++ )
    {
        $naam = $voornaam[$leerlingnummers[$i]];
        $Studentnummer = $leerlingnummers[$i];
        $woonplaats1 = $woonplaats[$leerlingnummers[$i]];
        $leeftijd1 = $leeftijd[$leerlingnummers[$i]];
        echo "
          <tr>
            <td><h2>$naam</h2></td><td><h4>$Studentnummer</h4></td><td><I>$woonplaats1</I></td><td><I>$leeftijd1</I></td>
          </tr>";
    }

    ?>
    </tbody>
</table>
</html>