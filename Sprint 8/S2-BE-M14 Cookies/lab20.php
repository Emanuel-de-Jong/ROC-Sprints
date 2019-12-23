<!DOCTYPE html>
<html style="background-color: darkslategray; color:white;">
    <head>
        <title>
            lab20
        </title>
    </head>
    <body>
    <form action="" name="form1" method="POST">
        <input value="" id="mail" type="email" name="mail" placeholder="E-mail">
        <input value="" id="password" type="password" name="password" placeholder="Password">
        <input type="submit" name="submit">
        <input type="checkbox" name="cookies">ik wil de cookies accepteren
    </form>
        <?php
        $mails = array('0302077@tcc-leerling.nl', '0307897@tcc-leerling.nl', '0311932@tcc-leerling.nl', '0308676@tcc-leerling.nl', '0308612@tcc-leerling.nl', '0314452@tcc-leerling.nl');
        $password = "Welkom12345!";
        $check = false;
        if(isset($_POST['submit'])){
            $gebruiker = strtolower($_POST['mail']);
            $wachtwoord = $_POST['password'];
            for ($i = 0; $i < sizeof($mails); $i++){
                if ($mails[$i] == $gebruiker) {
                    $check = true;
                }
            }
            if ($check == false) {
                echo('je wachtwoord of/en email is verkeerd');
            }
            if($check == true && $wachtwoord == $password){
                echo('je bent ingelogd');
            }
            if (isset($_POST['cookies'])) {
                setcookie("mail", $gebruiker);
            }
        }
        ?>
    </body>
</html>