CREATE TRIGGER [ServerTrigger1]
	ON ALL SERVER
	FOR LOGON
	AS
	BEGIN
		WAITFOR DELAY '00:00:05'; -- This should be flagged as a problem
		SET NOCOUNT ON
	END
