
CREATE PROCEDURE ProcWithWaitForDelay
AS 
BEGIN
  WAITFOR DELAY '00:00:15'; -- Waits 15 seconds before executing. This should be flagged as a problem
  RETURN SELECT * FROM dbo.Table1

END