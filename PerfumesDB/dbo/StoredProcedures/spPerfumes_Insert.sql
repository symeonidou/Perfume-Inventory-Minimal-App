CREATE PROCEDURE [dbo].[spPerfumes_Insert]
    @Name NVARCHAR(50), 
    @Designer NVARCHAR(50), 
    @Perfumer NVARCHAR(50), 
    @Launched NVARCHAR(MAX), 
    @Description NVARCHAR(MAX)
AS
begin
    insert into dbo.[Perfumes] 
    (Name, Designer, Perfumer, Launched, Description)
    values (@Name, @Designer, @Perfumer, @Launched, @Description);
end