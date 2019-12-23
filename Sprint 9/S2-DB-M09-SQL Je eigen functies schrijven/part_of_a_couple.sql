use DoctorWho
go

create function fnEpisodeDescription
	(
		@Title as varchar(max)
	)
returns varchar(max)
as
begin

	if charindex('Part 1', @Title) != 0
		return 'Single episode'
	else if charindex('Part 2', @Title) != 0
		return 'First part'
	return 'Single episode'

end