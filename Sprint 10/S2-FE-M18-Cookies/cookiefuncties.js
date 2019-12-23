function maakCookie(naam, waarde, dagen){
    if (dagen){
        var datum = new Date();
        datum.setTime(datum.getTime() + (dagen*24*60*60*1000));
        var verloopdatum = '; expires= ' + datum.toGMTString();
    }else{
        var verloopdatum = '';
    }
    document.cookie = naam + '=' + waarde + verloopdatum + ';path=/';
}

function leesCookie(naam){
    var naamCookie = naam + '=';
    var cookieArray = document.cookie.split(';');
    for(var i = 0; i < cookieArray.length; i++){
        var dezeCookie = cookieArray[i];
        dezeCookie = dezeCookie.trim();
        if (dezeCookie.indexOf(naamCookie) == 0){
            return dezeCookie.substring(naamCookie.length, dezeCookie.length);
        }
    }
    return null;
}

function verwijderCookie(naam){
    naam = naam + '=';
    var cookieArray = document.cookie.split(';');
    for(var i = 0; i < cookieArray.length; i++){
        var dezeCookie = cookieArray[i].trim();
        if (dezeCookie.indexOf(naam) == 0){
            var datum = new Date();
            datum.setTime(datum.getTime() - (1*24*60*60*1000));
            document.cookie = naam + dezeCookie.substring(naam.length, dezeCookie.length) + '; expires= ' + datum.toGMTString() + '; path=/';
        }
    }
}