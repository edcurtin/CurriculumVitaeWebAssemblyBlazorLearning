CREATE TABLE [dbo].[EmploymentHistory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Owner] INT NOT NULL, 
    [Role] NCHAR(50) NOT NULL, 
    [Company] NCHAR(100) NOT NULL, 
    [Dates] NCHAR(50) NOT NULL, 
    [Responsibilities] NCHAR(500) NOT NULL, 
    [CurrentEmployment] BIT NOT NULL,
    CONSTRAINT [FK_EmploymentHistory_ToCvOwner] FOREIGN KEY ([Owner]) REFERENCES [CVOwner]([Id]) 
)
