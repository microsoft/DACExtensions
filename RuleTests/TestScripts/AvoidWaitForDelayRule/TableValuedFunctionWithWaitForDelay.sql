CREATE FUNCTION [dbo].[TableValuedFunctionWithWaitForDelay]
(
	@param1 int,
	@param2 char(5)
)
RETURNS @returntable TABLE
(
	c1 int,
	c2 char(5)
)
AS
BEGIN
    WAITFOR DELAY '00:00:05';  -- This should be flagged as a problem
	INSERT @returntable
	SELECT @param1, @param2
	RETURN
END
