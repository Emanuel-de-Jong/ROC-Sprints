select 
	EventName, 
	FORMAT(EventDate, 'dd MMM yyyy') as [Event date],
	DATEDIFF(day, EventDate, '2000/04/10') as [Days offset],
	ABS(DATEDIFF(day, EventDate, '2000/04/10')) as [Days difference]
from tblEvent
order by EventDate 
DESC;