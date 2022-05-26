using DivChat.Models;

namespace DivChat.Services
{
    public interface IRateService
    {
        public List<Rate> GetAll();
        public Rate Get(int id);

        public void Create(string name, int stars, string description);
        public void Edit(int id, string name, int stars, string description);

        public void Delete(int id);

        public List<Rate> GetRatesByName(string query);

    }
}
