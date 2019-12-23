select CountryName 
from tblCountry
left join tblEvent
on tblCountry.CountryID = tblEvent.CountryID
where tblEvent.CountryID is null;