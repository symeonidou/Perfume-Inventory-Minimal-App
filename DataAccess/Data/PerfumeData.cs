using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class PerfumeData : IPerfumeData
{
    private readonly ISqlDataAccess _db;

    public PerfumeData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<PerfumeModel>> GetPerfumes() =>
        _db.LoadData<PerfumeModel, dynamic>(
            "dbo.spPerfumes_GetsAll", new { });

    public async Task<PerfumeModel?> GetPerfume(int id)
    {
        var results = await _db.LoadData<PerfumeModel, dynamic>(
            "dbo.spPerfumes_Gets", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertPerfume(PerfumeModel perfume) =>
        _db.SaveData("dbo.spPerfumes_Insert",
            new { perfume.Name, perfume.Designer, perfume.Perfumer, perfume.Launched, perfume.Description });

    public Task UpdatePerfume(PerfumeModel perfume) =>
        _db.SaveData("dbo.spPerfumes_Update", perfume);

    public Task DeletePerfume(int id) =>
        _db.SaveData("dbo.spPerfumes_Delete", new { Id = id });
}
