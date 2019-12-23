use WorldEvents
go

select CountryName
from tblCountry
where CountryID =
	(select CountryID
	from tblEvent
	where count(CountryID) > 8)
order by CountryName;