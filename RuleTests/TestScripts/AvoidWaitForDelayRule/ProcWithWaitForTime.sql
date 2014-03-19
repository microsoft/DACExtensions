
CREATE PROCEDURE ProcWithWaitForTime
AS 
BEGIN
  WAITFOR TIME '00:00:15'; -- Executes at 15seconds after midnight. This shouldn't cause a problem
  RETURN SELECT * FROM dbo.Table1

END