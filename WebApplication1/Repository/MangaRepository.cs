using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class MangaRepository : IMangaRepository
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;

        public MangaRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<MangaDto> CreateUpdate(MangaDto mangaDto)
        {
            Manga manga = _mapper.Map<MangaDto, Manga>(mangaDto);
            if (manga.Id > 0)
            {
                _db.Mangas.Update(manga);
            }
            else
            {
                _db.Mangas.Add(manga);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Manga, MangaDto>(manga);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Manga manga = await _db.Mangas.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (manga == null) return false;
                _db.Mangas.Remove(manga);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<MangaDto> GetById(int id)
        {
            Manga manga = await _db.Mangas.Where(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<MangaDto>(manga);
        }

        public async Task<IEnumerable<MangaDto>> GetList()
        {
            List<Manga> list = await _db.Mangas.ToListAsync();
            return _mapper.Map<List<MangaDto>>(list);
        }
    }
}
