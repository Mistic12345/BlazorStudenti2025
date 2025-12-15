using BlazorApp1.Data;
using BlazorApp1.Models;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services.Repositories
{
    public class StudentiService : IStudentiService
    {
        private readonly WebAppContext _context;

        public StudentiService(WebAppContext context)
        {
            _context = context;
        }

        public async Task AddStudenteAsync(Studente studente)
        {
             await _context.studenti.AddAsync(studente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudenteByIdAsync(int id)
        {
            Studente? studente = await _context.studenti.FindAsync(id);
            if(studente != null)
            {
               _context.studenti.Remove(studente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Studente>> GetAllStudentiAsync() => await _context.studenti.ToListAsync();


        public async Task<Studente?> GetStudenteByIdAsync(int id) => await _context.studenti.FirstOrDefaultAsync(s => s.Id == id);
       
        // Esercizio per domani: implementare UpdateStudenteAsync
        public async Task UpdateStudenteAsync(Studente studente)
        {
            throw new NotImplementedException();
        }
    }
}
