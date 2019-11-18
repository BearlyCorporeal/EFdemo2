CREATE TABLE [dbo].[Treatment0136]
(
	[OwnerID] INT NOT NULL,
	[PetName] nvarchar(50) NOT NULL,
	[ProcedureID] int not null,
	[Price] money not null,
	[Date] Date not null,
	[Notes] Nvarchar(200) not null,
	Foreign key(ProcedureID) references Procedure0136,
	Foreign key(OwnerID,PetName) references Pet0136,
	Primary Key(ProcedureID,Date,OwnerID,PetName)

	
)
