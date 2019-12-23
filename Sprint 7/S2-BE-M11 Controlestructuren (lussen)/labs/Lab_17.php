<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8">
  </head>
  <body>
    <h3>Voorbeeld van de do-while-lus</h3><br>
    <?php
      echo "Reken het saldo uit zolang het lager is dan 2000<br>";
      $saldo = 100;
      $rente = 0.1;
      $maand = 1;
      echo "<br>Beginsaldo is: $saldo";
      echo "<br>START...";
      do
      {
        if ($maand == 2) {
          echo "<br>Februari betaalt geen rente";
        }else{
          $saldo = $saldo + ($saldo * $rente);
          echo "<br>Maand: $maand je saldo is: " round($saldo, 2);
        }
        $maand++;
      } while ($saldo < 2000);
      echo "<br>...FINISH";
      ?>
  </body>
</html>