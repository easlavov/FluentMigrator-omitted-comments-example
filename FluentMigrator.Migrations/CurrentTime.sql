/*This view is written by Jon Doe on 17-Nov-2018*/
CREATE FUNCTION [dbo].[CurrentTime]()
	RETURNS DATE
	BEGIN
		RETURN GETDATE() -- inline comment
	END
GO  