using Microsoft.AspNetCore.Mvc;
using TravelTipsAPI.Interfaces;
using TravelTipsAPI.Models;

namespace TravelTipsAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TravelTipsController : ControllerBase {
        private readonly ITravelTipRepository _repository;

        public TravelTipsController(ITravelTipRepository repository) {
            _repository = repository;
        }

        // GET: api/traveltips
        [HttpGet]
        public ActionResult<IEnumerable<TravelTip>> GetAll() {
            return Ok(_repository.GetAll());
        }

        // GET: api/traveltips/2
        [HttpGet("{id}")]
        public ActionResult<TravelTip> GetById(int id) {
            var tip = _repository.GetById(id);
            if (tip == null)
                return NotFound();
            return Ok(tip);
        }

        // POST: api/traveltips
        [HttpPost]
        public ActionResult Add(TravelTip tip) {
            _repository.Add(tip);
            return CreatedAtAction(nameof(GetById), new { id = tip.Id }, tip);
        }

        // DELETE: api/traveltips/2
        [HttpDelete("{id}")]
        public ActionResult Delete(int id) {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
