CREATE PROCEDURE [dbo].[sp_EmploymentHistory_GetById]
	@id int
AS
SELECT * from EmploymentHistory Where Id = @id
RETURN 0
