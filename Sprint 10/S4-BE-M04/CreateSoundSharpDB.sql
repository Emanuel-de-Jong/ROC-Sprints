create database SoundSharpDB;
go

use SoundSharpDB;
go



create table Category(
	ID int not null primary key identity,
	CategoryName nvarchar(25) not null,
);

create table Track(
	ID int not null primary key identity,
	[Name] nvarchar(max) not null,
	Artist nvarchar(max) not null,
	Style int not null foreign key references Category(ID),
	AlbumSource nvarchar(max),
	[Length] time(7)
);

create table TrackList(
	ID int not null primary key identity,
	[Name] nvarchar(100),
	[Owner]  nvarchar(250),
);

create table TrackListTrack(
	TrackListId int not null foreign key references TrackList(ID),
	TrackId int not null foreign key references Track(ID),
	primary key (TrackListId, TrackId)
);



create table AudioDevices(
	SerialId int not null primary key,
	Model nvarchar(100) not null,
	Make nvarchar(100) not null,
	PriceExBtw smallmoney not null,
	CreationDate smalldatetime not null,
	BtwPrecentage numeric(3, 1) not null
);

create table MemoRecorder(
	AudioDeviceId int not null primary key references AudioDevices(SerialId),
	MaxCatridgetype nvarchar(10) not null
);

create table CdDiskMan(
	AudioDeviceId int not null primary key references AudioDevices(SerialId),
	MbSize int not null,
	DisplayWidth int not null,
	DisplayHeight int not null,
	IsEjected bit not null
);

create table Mp3Player(
	AudioDeviceId int not null primary key references AudioDevices(SerialId),
	MbSize int not null,
	DisplayWidth int not null,
	DisplayHeight int not null,
	TrackList int foreign key references TrackList(ID)
);