using TravelTipsAPI.Models;
using TravelTipsAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace TravelTipsAPI.Repositories
{
    public class TravelTipRepository : ITravelTipRepository
    {
        private readonly List<TravelTip> _tips = new()
{
    new TravelTip
    {
        Id = 1,
        City = "Ubatuba",
        Country = "São Paulo - Brasil",
        Description = "Hospedagem aconchegante próxima às praias de Ubatuba, ideal para relaxar e curtir o litoral.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/24644722",
        ImageUrl = "images/ubatuba1.jpg"
    },
    new TravelTip
    {
        Id = 2,
        City = "Santo Antônio do Pinhal",
        Country = "São Paulo - Brasil",
        Description = "Chalé charmoso na serra, perfeito para descansar em meio à natureza e ao clima de montanha.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/839511205532825831",
        ImageUrl = "images/pinhal1.jpg"
    },
    new TravelTip
    {
        Id = 3,
        City = "Ubatuba",
        Country = "São Paulo - Brasil",
        Description = "Acomodação confortável em Ubatuba, ótima opção para quem quer praia e tranquilidade.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/45135248",
        ImageUrl = "images/ubatuba2.jpg"
    }
};



        public IEnumerable<TravelTip> GetAll()
        {
            return _tips;
        }

        public TravelTip? GetById(int id)
        {
            return _tips.FirstOrDefault(t => t.Id == id);
        }

        public void Add(TravelTip tip)
        {
            tip.Id = _tips.Max(t => t.Id) + 1;
            _tips.Add(tip);
        }

        public void Delete(int id)
        {
            var tip = GetById(id);
            if (tip != null)
            {
                _tips.Remove(tip);
            }
        }
    }
}
