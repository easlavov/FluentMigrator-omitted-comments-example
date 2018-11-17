/*This procedure is written by Jon Doe on 17-Nov-2018*/
CREATE PROCEDURE [dbo].[Max]
    @First int,   
    @Second int   
AS   
    if @First > @Second -- sample inline comment
		return @First
    return isnull(@Second, @First)
GO  