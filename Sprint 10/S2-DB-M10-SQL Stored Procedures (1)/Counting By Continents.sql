create function fnContinentSummary
(
	@Continent varchar(max), @Month varchar(max)
)
returns table
as 
return
(
	select
		ContinentName,
		COUNT(DISTINCT(EventName)) as [Number of events],
		COUNT(DISTINCT(CountryName)) as [Number of countries],
		COUNT(DISTINCT(CategoryName)) as [Number of categories]
	from tblEvent
		join tblCategory on tblEvent.CategoryID = tblCategory.CategoryID
		join tblCountry on tblEvent.CountryID = tblCountry.CountryID
		join tblContinent on tblCountry.ContinentID = tblContinent.ContinentID
	where
		ContinentName = @Continent and
		format(EventDate, 'MMMM') = @Month
	group by
		ContinentName
)