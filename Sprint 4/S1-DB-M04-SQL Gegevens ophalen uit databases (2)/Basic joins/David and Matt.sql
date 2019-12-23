select tblDoctor.DoctorName, tblEpisode.Title 
from tblEpisode
inner join tblDoctor 
on tblEpisode.DoctorId = tblDoctor.DoctorId
where year(EpisodeDate) = 2010;