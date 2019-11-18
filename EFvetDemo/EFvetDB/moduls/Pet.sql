CREATE TABLE [dbo].[Pet0136]
(
	[OwnerID] INT NOT NULL,
	[PetName] nvarchar(50) NOT NULL,
	[type] nvarchar NOT NULL,
	foreign key(OwnerID) references PetOwner0136,
	primary key(OwnerID,PetName)



)
