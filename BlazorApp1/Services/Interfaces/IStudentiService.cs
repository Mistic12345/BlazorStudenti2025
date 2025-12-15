using BlazorApp1.Models;

namespace BlazorApp1.Services.Interfaces
{
    public interface IStudentiService
    {
        Task<List<Studente>> GetAllStudentiAsync();

        Task<Studente?> GetStudenteByIdAsync(int id);
        Task AddStudenteAsync(Studente studente);
        Task UpdateStudenteAsync(Studente studente);
        Task DeleteStudenteByIdAsync(int id);
    }
}
