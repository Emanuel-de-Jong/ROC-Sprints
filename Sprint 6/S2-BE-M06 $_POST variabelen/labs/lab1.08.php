<!DOCTYPE html>
<html>
<head>
</head>
<body>
<strong><h1>Inschrijfformulier</h1></strong>
<form action="lab08.verwerken.php" method="post">
  <table border="1">
    <tr>
      <td><h2>Achternaam</h2></td>
      <td><input type="text" name="achternaam"></td>
    </tr>
    <tr>
      <td><h2>Voornaam</h2></td>
      <td><input type="text" name="voornaam"></td>
    </tr>
    <tr>
      <td><h2>Straat</h2></td>
      <td><input type="text" name="Straat"></td>
    </tr>
    <tr>
      <td><h2>Postcode</h2></td>
      <td><input type="text" name="Postcode"></td>
    </tr>
    <tr>
      <td><h2>Plaats</h2></td>
      <td>
        <select name="plaats">
          <option name="plaats" value="Hengelo">Hengelo</option>
          <option name="plaats" value="Borne">Borne</option>
          <option name="plaats" value="Enchede">Enchede</option>
          <option name="plaats" value="Almelo">Almelo</option>
        </select>
    </td>
    </tr>
    <tr>
      <td><h2>E-mailadres</h2></td>
      <td><input type="text" name="EMail"></td>
    </tr>
  </table>
Kies een opleiding:<br>
  <input type="radio" name="opleiding" value="ICT" checked> ICT<br>
  <input type="radio" name="opleiding" value="Engels"> Engels<br>
  <input type="radio" name="opleiding" value="Techniek"> Techniek<br>
  <input type="radio" name="opleiding" value="Nederlands"> Nederlands
  <br>
  <input type="submit" value="Versturen"> <input type="reset" value="reset">
</form>
</body>
</html>