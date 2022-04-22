CREATE PROCEDURE [dbo].[spPerfumes_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Perfumes]
	where Id = @Id;
end