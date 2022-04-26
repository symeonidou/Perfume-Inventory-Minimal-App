namespace PerfumesInventoryAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All of my API endpoint mapping
        app.MapGet("/Perfumes", GetPerfumes);
        app.MapGet("/Perfumes/{id}", GetPerfume);
        app.MapPost("/Perfumes", InsertPerfume);
        app.MapPut("/Perfumes", UpdatePerfume);
        app.MapDelete("/Perfumes", DeletePerfume);
    }

    private static async Task<IResult> GetPerfumes(IPerfumeData data)
    {
        try
        {
            return Results.Ok(await data.GetPerfumes());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetPerfume(int id, IPerfumeData data)
    {
        try
        {
            var results = await data.GetPerfume(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertPerfume(PerfumeModel perfume, IPerfumeData data)
    {
        try
        {
            await data.InsertPerfume(perfume);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdatePerfume(PerfumeModel perfume, IPerfumeData data)
    {
        try
        {
            await data.UpdatePerfume(perfume);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeletePerfume(int id, IPerfumeData data)
    {
        try
        {
            await data.DeletePerfume(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}