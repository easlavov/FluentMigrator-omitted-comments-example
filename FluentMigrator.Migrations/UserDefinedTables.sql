/*This view is written by Jon Doe on 17-Nov-2018*/
CREATE VIEW [dbo].[UserDefinedTables] AS
	SELECT * FROM sys.types
		WHERE is_user_defined = 1 -- sample inline comment