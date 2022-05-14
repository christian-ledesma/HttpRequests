using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DTO;

namespace WebApplication1.Repository
{
    public interface IMangaRepository
    {
        Task<IEnumerable<MangaDto>> GetList();
        Task<MangaDto> GetById(int id);
        Task<MangaDto> CreateUpdate(MangaDto mangaDto);
        Task<bool> Delete(int id);
    }
}
