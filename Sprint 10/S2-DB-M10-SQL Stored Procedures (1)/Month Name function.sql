CREATE FUNCTION IntToMonth
	(@Int int)
	RETURNS varchar(max)

AS

BEGIN

	RETURN case @Int
				when 1 then 'January'
				when 2 then 'Febuari'
				when 3 then 'March'
				when 4 then 'April'
				when 5 then 'may'
				when 6 then 'June'
				when 7 then 'July'
				when 8 then 'August'
				when 9 then 'September'
				when 10 then 'October'
				when 11 then 'November'
				when 12 then 'December'
				else 'Wrong Input!'
			end
END;