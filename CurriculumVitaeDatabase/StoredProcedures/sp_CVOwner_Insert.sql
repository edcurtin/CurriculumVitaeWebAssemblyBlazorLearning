CREATE PROCEDURE [dbo].[sp_CVOwner_Insert]
    @Id int output,
    @Name nvarchar(50),
    @Address nvarchar(200),
    @DateOfBirth date,
    @Email nvarchar(50),
    @LinkedIn nvarchar(50),
    @WorkingModel smallint,
    @TelephoneNumber nvarchar(50)

AS
BEGIN
    insert into CVOwner (Name, Address, DateOfBirth, Email, LinkedIn, WorkingModel, TelephoneNumber)
    values (@Name, @Address, @DateOfBirth, @Email, @LinkedIn, @WorkingModel, @TelephoneNumber);
    select @Id = SCOPE_IDENTITY();
END

RETURN 0
