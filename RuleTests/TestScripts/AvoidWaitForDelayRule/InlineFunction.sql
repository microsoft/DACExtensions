CREATE FUNCTION [dbo].[InlineFunction] -- Won't even be examined since it's an inlined function
(
	@param1 int,
	@param2 char(5)
)
RETURNS TABLE AS RETURN
(
	SELECT @param1 AS c1,
		   @param2 AS c2
)
