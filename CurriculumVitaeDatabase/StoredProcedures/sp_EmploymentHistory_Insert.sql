CREATE PROCEDURE [dbo].[sp_EmploymentHistory_Insert]
    @Id int output,
    @Owner int,
    @Role nvarchar(50),
    @Company nvarchar(100),
    @Dates nvarchar(50),
    @Responsibilities nvarchar(500),
    @CurrentEmployment bit

AS
BEGIN
    insert into EmploymentHistory ([Owner], [Role], [Company], [Dates], [Responsibilities], [CurrentEmployment])
    values (@Owner, @Role, @Company, @Dates, @Responsibilities, @CurrentEmployment);
    select @Id = SCOPE_IDENTITY();
END

RETURN 0