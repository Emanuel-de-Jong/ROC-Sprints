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
?>
