<h4>Reiskosten berekenen</h4>
<br>
<form action="#" method="post">
  Vertrek:
  <select name="vertrek">
    <option name="vertrek" value="1">Amsterdam</option>
    <option name="vertrek" value="2">Utrecht</option>
    <option name="vertrek" value="3">Een Haag</option>
    <option name="vertrek" value="4">Rotterdam</option>
  </select>
  Bestemming:
  <select name="bestemming">
    <option name="bestemming" value="1">Amsterdam</option>
    <option name="bestemming" value="2">Utrecht</option>
    <option name="bestemming" value="3">Een Haag</option>
    <option name="bestemming"  value="4">Rotterdam</option>
  </select>
  <br>
  <input type="submit"  name="bereken" value="Berekenen">
</form>
<br>
-------------------------------------------------------
<?php
  function Reiskosten($vertrek, $bestemming)
  {
    $reiskosten = array();
    $reiskosten[1] = array();
    $reiskosten[2] = array();
    $reiskosten[3] = array();
    $reiskosten[4] = array();

    $reiskosten[1][1] = 0; //amsterdam naar amsterdam
    $reiskosten[1][2] = 30; //amsterdam naar utrecht
    $reiskosten[1][3] = 60; //amsterdam naar den haag
    $reiskosten[1][4] = 90; //amsterdam naar rotterdam

    $reiskosten[2][1] = 30; //utrecht naar amsterdam
    $reiskosten[2][2] = 0; // utrecht naar utrecht
    $reiskosten[2][3] = 40; //utrecht naar den Haag
    $reiskosten[2][4] = 20; //utrecht naar rotterdam

    $reiskosten[3][1] = 60; //den haag naar amsterdam
    $reiskosten[3][2] = 40; //den haag naar utrecht
    $reiskosten[3][3] = 0; //den haag naar den Haag
    $reiskosten[3][4] = 10; //den haag naar rotterdam

    $reiskosten[4][1] = 90; //rotterdam naar amsterdam
    $reiskosten[4][2] = 20; //rotterdam naar utrecht
    $reiskosten[4][3] = 10; //rotterdam naar den Haag
    $reiskosten[4][4] = 0; //rotterdam naar rotterdam

    return($reiskosten[$vertrek][$bestemming]);
  }
    if(isset($_POST['bereken'])){
      $bestemming1 = (int)$_POST['bestemming'];
      $vertrek1 = (int)$_POST['vertrek'];
      $kosten =  Reiskosten($vertrek1, $bestemming1);
      echo "<br>De berekende Reiskosten zijn: $kosten euro";
    }

 ?>
