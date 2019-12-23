var check2 = false;
    function submit(){
        if(check2 == false){
        //function for the last that of the month by removing one day and adding 1 month--functie voor de laatse dag van de maand
        var laatstedag = function(y,m){
            return  new Date(y, m +1, 0).getDate();
        }
        //creating some var(s)--var(s) maken
        var e=1;
        var x=0;
        var check = false;
        var extradagen = 0;
        //gets the date from teh selected month and year--pak het datum uit maand en jaar
        var maand = document.getElementById("maand").value;
        var jaar = document.getElementById("jaar").value;
        var main = document.getElementById("calendar");
        document.getElementById('maandjaar').innerHTML = maand + ' '+ jaar;
        var box = document.getElementById('box');
        //change the text selected to an int (javascript months are from 0-11) -- text om zetten naar een int met een swich (in javascript zijn de maanden van 0 tot 11 ipv 1/12)
        switch(maand){
            case "januari":maand = 0;break;
            case "februari":maand = 1;break;
            case "maart":maand = 2;break;
            case "april":maand = 3;break;
            case "mei":maand = 4;break;
            case "juni":maand = 5;break;
            case "julie":maand = 6;break;
            case "augustus":maand = 7;break;
            case "september":maand = 8;break;
            case "oktober":maand = 9;break;
            case "november":maand = 10;break;
            case "december":maand = 11;break;
        }
        //creates the date objects and teh arrays for the day -- maakt de date objects en de arrays voor de dagen
        var dagen2 = new Array('zo','ma','di','wo','do','vr','za');
        var datum = new Date(jaar,maand);
        var dag = datum.getDay();
        var maxdag = laatstedag(jaar,maand);
        for(var r=0; r < 7; r++){
            var dagenTr = document.createElement("th");
            dagenTr.setAttribute("id", "dagen");
            main.appendChild(dagenTr);
            dagenTr.innerHTML = dagen2[r];
        }
        //for loop om te checken welke week het is
        for(var k = 0; k < 6; k++){
            var row = document.createElement("tr");
            row.setAttribute("id", "row");
            main.appendChild(row);
            //for loop om te checken welke dag het is
            for(var i = 0; i < 7; i++){
                x++;
                //ifstatements to check if its the first day or last day -- ifstatement voor de rest van de dagen van de maand
                if(x<=(maxdag+extradagen) && dag<=x){
                    check = true;
                    g = document.createElement('td');
                    row.appendChild(g);
                    div = document.createElement('div');
                    div.setAttribute("id", "box");
                    g.appendChild(div);
                    div.innerHTML = e;
                    e++;
                }
                if(check == false){
                    extradagen++;
                    g = document.createElement('td');
                    div = document.createElement('div');
                    div.setAttribute("id", "box");
                    row.appendChild(g);
                    g.appendChild(div);
                }     
            }
        }
        check2 = true;
    }
    else{
        //question about if you are sure -- vraag of je het zekerweet
        if(confirm('als u de calender wilt veranderen druk dan op OK')){
            //reloads the page -- herlaad het pagina
            location.reload(); 
        }
    }
}
//all rights reserved