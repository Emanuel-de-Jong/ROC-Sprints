select 
	tblAuthor.AuthorName,
	tblDoctor.DoctorName,
	count(tblEpisode.EpisodeId) as [Episodes]
from tblEpisode
full outer join tblAuthor
	on tblAuthor.AuthorId = tblEpisode.AuthorId
full outer join tblDoctor
	on tblDoctor.DoctorId = tblEpisode.DoctorId
group by tblAuthor.AuthorName, tblDoctor.DoctorName
having count(tblEpisode.EpisodeId) > 5
order by count(tblEpisode.EpisodeId) desc;