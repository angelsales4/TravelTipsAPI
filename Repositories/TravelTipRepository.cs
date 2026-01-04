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
        Description = "Hospedagem aconchegante próxima às praias de Ubatuba, ideal para relaxar a dois.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/24644722",
        ImageUrl = "images/ubatuba1.jpg",
        TripType = "casal"
    },

    new TravelTip
    {
        Id = 2,
        City = "Santo Antônio do Pinhal",
        Country = "São Paulo - Brasil",
        Description = "Chalé charmoso na serra, perfeito para uma viagem romântica.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/839511205532825831",
        ImageUrl = "images/pinhal1.jpg",
        TripType = "casal"
    },

    new TravelTip
    {
        Id = 3,
        City = "Ubatuba",
        Country = "São Paulo - Brasil",
        Description = "Acomodação confortável para casal, ótima opção para curtir a praia.",
        AirbnbLink = "https://www.airbnb.com.br/rooms/45135248",
        ImageUrl = "images/ubatuba2.jpg",
        TripType = "casal"
    },

    // VIAGEM COM AMIGOS
    new TravelTip
{
    Id = 4,
    City = "Praia do Saco",
    Country = "São Sebastião - SP, Brasil",
    Description = "Casa perfeita para viagem com amigos em Maresias, perto da Praia do Saco.",
    AirbnbLink = "https://www.airbnb.com.br/rooms/45712424",
    ImageUrl = "images/praia-saco-maresias.jpg",
    TripType = "amigos"
},

new TravelTip
{
    Id = 5,
    City = "Praia de Guaecá",
    Country = "São Sebastião - SP, Brasil",
    Description = "Hospedagem ideal para grupos de amigos na Praia de Guaecá.",
    AirbnbLink = "https://www.airbnb.com.br/rooms/3004569",
    ImageUrl = "images/guaeca-sao-sebastiao.jpg",
    TripType = "amigos"
},

new TravelTip
{
    Id = 6,
    City = "Ilhabela",
    Country = "São Paulo - Brasil",
    Description = "Casa espaçosa para curtir Ilhabela com amigos.",
    AirbnbLink = "https://www.airbnb.com.br/rooms/46921539",
    ImageUrl = "images/ilhabela.jpg",
    TripType = "amigos"
}




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
