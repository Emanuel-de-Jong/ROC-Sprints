select top 5 * from CountriesByArea;


select
	Country, 
	KmSquared,
	KmSquared % 20,761 as [AreaLeftOver],
	KmSquared - KmSquared % 20,761 / 20,761 as [WalesUnits]
from
	CountriesByArea
order by
	Country;