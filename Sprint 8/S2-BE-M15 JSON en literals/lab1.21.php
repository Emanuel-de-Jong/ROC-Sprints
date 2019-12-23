<!DOCTYPE html>
<html lang="nl">
  <head>
    <style>
        /*zet de styling */
      .forum{
        position: fixed;
        top: 50%;
        left: 50%;
        /* bring your own prefixes */
        transform: translate(-50%, -50%);
        width: 25%;
        padding: 10px;
        border-radius: 15px;
        background-color: yellow;
        text-align: center;
        border-width: 5px;
        border-color: red;
        border-style: solid;
        font-family: "Palatino Linotype", "Book Antiqua", "Palatino", "serif";
        font-size: 18pt;
      }
    </style>
    <meta charset="utf-8">
    <title>Lab 1.21</title>
  </head>
  <body>
    <!-- Maak een forum -->
    <div class="forum">
      <strong><h1>LAB 1.21</h1></strong>
      <form class="form" action="" method="post">
        <input type="text" name="voornaam" placeholder="voornaam"><br>
        <input type="text" name="naam" placeholder="naam"><br>
        <input type="date" name="geboortedatum" placeholder="geboortedatum"><br>
        <input type="text" name="straat" placeholder="straat"><br>
        <input type="text" name="postcode" placeholder="postcode"><br>
        <input type="text" name="plaats" placeholder="plaats"><br>
        <input type="email" name="email" placeholder="email"><br>
        <input type="password" name="password" placeholder="password"><br>
        Minderjarig:
        <input type="radio" name="minderjarig" value="JA"> JA
        <input type="radio" name="minderjarig" value="NEE"> NEE<br>

        <button type="submit" name="submit" >Registreren</button>
        <button type="reset" name="reset" >resetten</button>
      </form>

    </div>
    <?php
    //voer de code uit als de gebruieker op submit drukt
    if (isset($_POST["submit"])){
      //zet alle gegevens in de array $gebruiker
      $gebruiker = array("voornaam" => $_POST["voornaam"], "naam" => $_POST["naam"], "geboortedatum "=> $_POST["geboortedatum"],
      "postcode" => $_POST["postcode"], "straat" => $_POST["straat"], "plaats" => $_POST["plaats"], "email" => $_POST["email"],
      "password" => $_POST["password"], "minderjarig" => $_POST["minderjarig"]);
      //laat de array zien
      print_r($gebruiker);

      //convert de array naar een json string
      $result = json_encode($gebruiker);

      //laat de json zien
      echo "<br><br>JSON:<br><br>" . $result;
    }
     ?>

  </body>
</html>
