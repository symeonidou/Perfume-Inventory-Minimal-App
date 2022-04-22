CREATE PROCEDURE [dbo].[spPerfumes_Update]
	@Id int,
    @Name NVARCHAR(50), 
    @Designer NVARCHAR(50), 
    @Perfumer NVARCHAR(50), 
    @Launched NVARCHAR(MAX), 
    @Description NVARCHAR(MAX)
AS
begin
    update dbo.[Perfumes]
    set Name = @Name, 
        Designer = @Designer, 
        Perfumer = @Perfumer, 
        Launched = @Launched, 
        Description = @Description
    where Id = @Id;
end
