using TravelTipsAPI.Models;
using System.Collections.Generic;

namespace TravelTipsAPI.Interfaces {
    public interface ITravelTipRepository {
        IEnumerable<TravelTip> GetAll();
        TravelTip? GetById(int id);
        void Add(TravelTip tip);
        void Delete(int id);
    }
}
