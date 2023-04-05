using CarRentaalManagement.Server.IRepository;
using CarRentaalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentaalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
             

        // GET: api/Colours
        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            var colors  = await _unitOfWork.ColourRepository.GetAll();

            return colors == null ? NotFound()
                : Ok(colors);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            var color = await _unitOfWork.ColourRepository.Get(q => q.Id == id);

            return color == null ? NotFound() : Ok(color);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {

            if (id != colour.Id)
            {
                return BadRequest();
            }
            _unitOfWork.ColourRepository.Update(colour);


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            await _unitOfWork.ColourRepository.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            var booking = await _unitOfWork.ColourRepository.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.ColourRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            var booking = await _unitOfWork.ColourRepository.Get(q => q.Id == id);
            return booking == null;
        }
    }
}
