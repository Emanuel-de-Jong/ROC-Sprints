<!DOCTYPE html>
<html>
  <head>
  </head>
  <body>
      <?php
      $achternaam = $_POST["achternaam"];
      $voornaam = $_POST["voornaam"];
      $Straat = $_POST["Straat"];
      $Postcode = $_POST["Postcode"];
      $plaats = $_POST["plaats"];
      $EMail = $_POST["EMail"];
      $opleiding = $_POST["opleiding"];
        echo '<h1>Uw gegevens zijn:</h1><br>';
        echo "<h2>
        Achternaam: $achternaam<br>
        Voornaam: $voornaam<br>
        Straat: $Straat<br>
        Postcode: $Postcode<br>
        Plaats: $plaats<br>
        E-mailadres: $EMail<br><br>
        U word ingeschreven voor de volgende opleiding:<br>
        $opleiding
        </h2>";
        ?>
  </body>
</html>
