CREATE PROCEDURE [dbo].[spPerfumes_Gets]
	@Id int
AS
begin
	select *
	from dbo.[Perfumes]
	where Id = @Id;
end