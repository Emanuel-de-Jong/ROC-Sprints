CASE

	WHEN @Para1 IN (SELECT TOP 1 EventName FROM tblEvent ORDER BY EventID) THEN 'Oldest'
	WHEN @Para1 IN (SELECT BOTTOM 1 EventName FROM tblEvent ORDER BY EventID) THEN 'Newest'
	WHEN @Para1 IN (SELECT TOP 1 EventName FROM tblEvent ORDER BY EventName) THEN 'First alphabetically'
	WHEN @Para1 IN (SELECT BOTTOM 1 EventName FROM tblEvent ORDER BY EventName) THEN 'Last alphabetically'
	ELSE 'Not a winner'

END