use SoundSharpDB
go





insert into Category
values
    ('Ambient'),
    ('Blues'),
    ('Country'),
    ('Disco'),
    ('Electro'),
    ('Hardcore'),
    ('HardRock'),
    ('HeavyMetal'),
    ('Hiphop'),
    ('Jazz'),
    ('Jumpstyle'),
    ('Klassiek'),
    ('Latin'),
    ('Other'),
    ('Pop'),
    ('Punk'),
    ('Reggae'),
    ('Rock'),
    ('Soul'),
    ('Trance'),
    ('Techno');





insert into Track
values
    ('Yellow', 'Coldplay', 15, 'Parachutes', '00:04:29'),
    ('Shiver', 'Coldplay', 15, 'Parachutes', '00:04:59'),
    ('Maneater', 'Nelly Futado', 15, 'Loose', '00:04:41'),
    ('Guitar', 'Prince', 15, null , '00:04:12');







insert into AudioDevices 
values
    (1, 'ICD-BX700', 'Sony', 43.99, convert(datetime,'2010-10-01'), 21),
    (2, 'Voice Trace LF', 'Philips', 139, convert(datetime,'2010-01-10'), 21),
    (3, 'VN 500', 'Olympus', 30, convert(datetime,'2010-01-05'), 21);

insert into MemoRecorder
values
	(1, 'C90'),
	(2, 'C120'),
	(3, 'C60');

	






insert into AudioDevices
values 
    (4, 'CD9220', 'Soundmaster', 48, convert(datetime,'2018-05-08'), 21),
    (5, 'DM-24', 'Denver', 24.99, convert(datetime,'2015-12-12'), 21),
    (6, 'CDP 6600 Pink', 'Grundig', 52, convert(datetime,'2018-10-10'), 21),
    (7, 'C60HF', 'Sony', 10.99, convert(datetime,'2011-10-09'), 21);

insert into CdDiskMan
values 
(4, 700, 640, 480, 0),
(5, 700, 640, 480, 0),
(6, 700, 1080, 640, 0),
(7, 700, 1080, 640, 0);











insert into AudioDevices
values
    (8, 'iPod Touch 6', 'Apple', 219, convert(datetime,'2018-03-04'), 21),
    (9, 'Clip Sports 8GB', 'Sandisk', 59.99,convert(datetime,'2017-03-09'), 21),
    (10, 'Plenue D Goud', 'Cowan', 284, convert(datetime,'2019-02-04'), 21),
    (11, 'NW-ZX300', 'Sony', 683, convert(datetime,'2019-01-10'), 21);

insert into Mp3Player
values
	(8, 32000, 640, 480, null),
	(9, 8000, 640, 480, null),
	(10, 32000, 1080, 640, null),
	(11, 64000, 1080, 640, null);



select * from AudioDevices 
full outer join Mp3Player
on Mp3Player.AudioDeviceId = SerialId
full outer join CdDiskMan
on CdDiskMan.AudioDeviceId = SerialId
full outer join MemoRecorder
on MemoRecorder.AudioDeviceId = SerialId