function afmelden(){
    var antwoord = confirm('Wilt u zich afmelden?');
    if(antwoord == true){
        alert('U wordt afgemeld!!!');
    }
}

function begroeten(){
    var nu = new Date();
    var uur = nu.getHours();
    if(uur <= 11){
        document.write('<br>Goedemorgen!');
    }else if(uur <= 17){
        document.write('<br>Goedemiddag!');
    }else{
        document.write('<br>Goedeavond!');
    }
}

function dollarKoers(){
    return(1.36);
}
function euroKoers(){
    return(0.74);
}
function dollar_naar_euro(dollars){
    return(dollars * euroKoers());
}

function wissel(bedrag, valuta){
    if(valuta == 'euro'){
        return(bedrag * dollarKoers());
    }
    else if(valuta == 'dollar'){
        return(bedrag * euroKoers());
    }
}