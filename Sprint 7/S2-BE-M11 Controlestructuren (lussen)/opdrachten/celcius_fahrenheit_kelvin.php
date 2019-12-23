<!DOCTYPE html>
<html>
<head>
</head>
<body>
<table>
    <thead>
        <tr>
            <th>Celsius</th><th>Fahrenheit</th><th>Kelvin</th>
        </tr>
    </thead>

    <tbody>
        <?php
        $teller = 50;

        while ($teller >= -50)
        {
            $celsius = $teller;
            $fahrenheit = $teller * 1.8 + 32;
            $kelvin = $teller +  273.15;

            if ($teller < 0)
            {
                echo "
              <tr bgcolor='blue'>
                <td>$celsius</td><td>$fahrenheit</td><td>$kelvin</td>
              </tr>";
            }

            else if ($teller == 0)
            {
                echo "
              <tr>
                <td>$celsius</td><td>$fahrenheit</td><td>$kelvin</td>
              </tr>";
            }

            else if ($teller > 0)
            {
                echo "
              <tr bgcolor='green'>
                <td>$celsius</td><td>$fahrenheit</td><td>$kelvin</td>
              </tr>";
            }
            $teller--;
        }
        ?>
    </tbody>
</table>
</body>
</html>