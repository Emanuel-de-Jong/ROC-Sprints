var main = document.getElementById("table");
//maakt een array met nederlandse steden
var cities = ['amsterdam', 'enschede', 'zwolle', 'hengelo', 'zutphen', 'roterdam', 'arnhem', 'groningen', 'leeuwarden'];
//een random stad uit de array cities
var city = cities[Math.floor(Math.random() * cities.length)];
//maak een nieuwe array voor alle goede antwoorden
var gokken = 4;
var gok=0;
var teller= 0;
var check = false;
var punt = 0;
var goed = 10;
//maak de vraagtekens
for(var i=0; i<city.length;i++){
    g = document.createElement('td');
    g.setAttribute("id", '?'+i);
    main.appendChild(g);
    g.innerHTML = '?';
}
var input = document.getElementById("guess");
input.addEventListener("keyup", function(event) {
  if (event.keyCode === 13) {
    // zet het antwoord in een var en dan haal het uit de balk
    var antwoord = document.getElementById('guess').value;
    document.getElementById('guess').innerHTML = "";
    if(goed >= 0){
        gok++;
        for(var i=0;i<=city.length;){
            //controleer of het ingevoerde juist is
            if(city.charAt(i) == antwoord){
                check = true;
                document.getElementById('?'+i).innerHTML = antwoord;
                teller++;
            }
            i++;
        }
        //if statements om te kijken of de antwoord klopt
        if(teller == city.length){
            alert('gewonnen');
        }
        if(check == true){
            check = false;
            punt++;
            gokken++;
            goed++;
            document.getElementById('gok').innerHTML = 'gok '+ gokken ;
            document.getElementById('gokken').innerHTML = goed +' gokken over';
            document.getElementById('punten').innerHTML = punt +' punten';
        }
        else{
            gokken++;
            punt--;
            goed--;
            document.getElementById('gok').innerHTML = 'gok '+ gokken ;
            document.getElementById('gokken').innerHTML = goed +' gokken over';
            document.getElementById('punten').innerHTML = punt +' punten';
        }
    }
    else{
        if(confirm('je kan niet gokken druk op OK als je opnieuw wilt beginnen')){
            location.reload(); 
        }
    }
   event.preventDefault();
  }
});
