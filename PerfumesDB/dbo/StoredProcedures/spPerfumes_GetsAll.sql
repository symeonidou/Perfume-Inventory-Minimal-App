CREATE PROCEDURE [dbo].[spPerfumes_GetsAll]
AS
begin
	select *
	from dbo.[Perfumes];
end