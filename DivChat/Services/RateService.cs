
using DivChat.Models;

namespace DivChat.Services
{
    public class RateService : IRateService
    {
        private static List<Rate> rates = new List<Rate>();

        public List<Rate> GetAll() { 
            return rates;
        }
        public Rate Get(int id) { 
            return rates.Find(x => x.Id == id);
        }
        public void Create(string name, int stars, string description)
        {
            int nextId;
            if (rates.Count == 0)
            {
                nextId = 1;
            }
            else
            {
                nextId = rates.Max(x => x.Id) + 1;
            }
            rates.Add(new Rate() { Id = nextId, Name = name,Stars = stars, Description = description, Date = DateTime.Now} );
            
        }
        public void Edit(int id, string name, int stars, string description) {
            Rate rate = Get(id);
            rate.Description = description;
            rate.Stars = stars;
            rate.Name = name;
            rate.Date = DateTime.Now;
        }

        public void Delete(int id) {
           rates.Remove(Get(id));
        }

        public List<Rate> GetRatesByName(string query)
        {
            List<Rate> subList = rates.Where(x => x.Name.Contains(query)).ToList();
            return subList;
        }
    }
}
