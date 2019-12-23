use DoctorWho
go

CREATE FUNCTION fnChosenEpisodes
(
	@SeriesNumber int,
	@AuthorName varchar(100)
)
RETURNS TABLE
AS
return
	select
		Title,
		AuthorName as Author,
		DoctorName as Doctor
	from
		tblEpisode
		inner join tblAuthor
			on tblAuthor.AuthorId = tblEpisode.AuthorId
		inner join tblDoctor
			on tblDoctor.DoctorId = tblEpisode.DoctorId
	where
		AuthorName like
		case
			when @AuthorName = null then AuthorName
			else '%' + @AuthorName
		end
		and
		SeriesNumber =
		case
			when @SeriesNumber = null  then SeriesNumber
			else @SeriesNumber
		end