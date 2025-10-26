using TravelTipsAPI.Models;
using TravelTipsAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace TravelTipsAPI.Repositories {
    public class TravelTipRepository : ITravelTipRepository {
        private readonly List<TravelTip> _tips = new()
        {
            new TravelTip { Id = 1, City = "Paris", Country = "França", Description = "Visite a Torre Eiffel!", AirbnbLink = "https://www.airbnb.com/paris" },
            new TravelTip { Id = 2, City = "Nova York", Country = "EUA", Description = "Conheça a Times Square!", AirbnbLink = "https://www.airbnb.com/new-york" },
            new TravelTip { Id = 3, City = "Tóquio", Country = "Japão", Description = "Explore Shibuya e Akihabara!", AirbnbLink = "https://www.airbnb.com/tokyo" }
        };

        public IEnumerable<TravelTip> GetAll() => _tips;

        public TravelTip? GetById(int id) => _tips.FirstOrDefault(t => t.Id == id);

        public void Add(TravelTip tip) {
            tip.Id = _tips.Max(t => t.Id) + 1;
            _tips.Add(tip);
        }

        public void Delete(int id) {
            var tip = _tips.FirstOrDefault(t => t.Id == id);
            if (tip != null)
                _tips.Remove(tip);
        }
    }
}
