using DataAccess.Models;

namespace DataAccess.Data;

public interface IPerfumeData
{
    Task DeletePerfume(int id);
    Task<PerfumeModel?> GetPerfume(int id);
    Task<IEnumerable<PerfumeModel>> GetPerfumes();
    Task InsertPerfume(PerfumeModel perfume);
    Task UpdatePerfume(PerfumeModel perfume);
}