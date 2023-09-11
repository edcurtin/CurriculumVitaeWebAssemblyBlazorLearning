CREATE TABLE [dbo].[EmploymentHistory]
(
	[Id] INT NOT NULL , 
    [PersonId] INT NOT NULL, 
    [Role] NCHAR(50) NOT NULL, 
    [Company] NCHAR(100) NOT NULL, 
    [Dates] NCHAR(50) NOT NULL, 
    [Responsibilities] NCHAR(500) NOT NULL, 
    [CurrentEmployment] BIT NOT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_EmploymentHistory_ToCvOwner] FOREIGN KEY ([PersonId]) REFERENCES [CVOwner]([Id]) 
)
