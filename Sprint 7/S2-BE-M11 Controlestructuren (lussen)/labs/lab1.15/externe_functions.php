<?php
function korting()
{
 $korting = 0;
 if (isset($_POST['student'])) {
   $korting = $korting + 15;
 }
 if (isset($_POST['Klant']))
 {
   $korting = $korting + 10;
 }
 return($korting);
}

function serviceKosten($betalen)
{
  $servicekosten = 0;
  switch($betalen)
  {
    case "Visa":
     $servicekosten = 2;
     break;
    case "MasterCard":
     $servicekosten = 2.5;
     break;
         case "PayPal":
     $servicekosten = 1.5;
     break;
    case "Ideal":
     $servicekosten = 1;
     break;
    default:
      $servicekosten = 0;
     break;
  }
  return($servicekosten);
}

function facturering()
{
  $totaal = 0;

  echo '
    <hr>
    <table>
      <tr>
        <th>Genre</th>
        <th>Artiest</th>
        <th>Album</th>
        <th>Aantal</th>
        <th>Prijs</th>
        <th>Bedrag</th>
      </tr>


  ';
  for($x=0; $x < sizeof($_POST["albumcode"]); $x++)
  {
    $genre = $_POST["genre"][$x];
    $artiest = $_POST["artiest"][$x];
    $album = $_POST["album"][$x];
    $aantal = $_POST["aantal"][$x];
    $prijs = $_POST["prijs"][$x];
    $bedrag = $prijs * $aantal;

    $totaal = $totaal + $bedrag;

    echo"
    <tr>
      <td>$genre</td>
      <td>$artiest</td>
      <td>$album</td>
      <td>$aantal</td>
      <td>$prijs</td>
      <td>$$bedrag</td>
    </tr>";
  }
  $korting = $totaal * korting() / 100;
  $servicekosten = serviceKosten($_POST['payMethode']);
  $betalen = ($totaal + $servicekosten) - ($totaal * (korting() / 100)) ;
  echo"
  <tr>
    <td>Totaal</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td>$$totaal</td>
  </tr>
  <tr>
    <td>Korting</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td>$korting%</td>
  </tr>
  <tr>
    <td>Servicekosten</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td>$$servicekosten</td>
  </tr>
  <tr>
    <td>Te betalen</td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td>$$betalen</td>
  </tr>"
  ;

}
?>
