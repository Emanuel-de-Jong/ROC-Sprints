select EventName, EventDate, 
CHARINDEX('this', EventDetails, 1) as thisPosition, 
CHARINDEX('that', EventDetails, 1) as thatPosition,
ABS(CHARINDEX('this', EventDetails, 1) - CHARINDEX('that', EventDetails, 1)) as Offset
from tblEvent where CHARINDEX('this', EventDetails, 1) != 0 and CHARINDEX('that', EventDetails, 1) > CHARINDEX('this', EventDetails, 1);