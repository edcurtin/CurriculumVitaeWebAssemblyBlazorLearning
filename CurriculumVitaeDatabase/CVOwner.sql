CREATE TABLE [dbo].[CVOwner]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY , 
    [Name] NCHAR(50) NOT NULL, 
    [Address] NCHAR(200) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [LinkedIn] NCHAR(50) NOT NULL, 
    [WorkingModel] SMALLINT NOT NULL, 
    [TelephoneNumber] NCHAR(50) NOT NULL
)
