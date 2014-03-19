CREATE FUNCTION [dbo].[DatabaseScalarFunction1]
(
	@param1 int,
	@param2 int
)
RETURNS INT
AS
BEGIN
    WAITFOR DELAY '00:00:05';	-- This should be flagged as a problem
	RETURN @param1 + @param2
END
