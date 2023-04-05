using CarRentaalManagement.Server.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentaalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes = await _unitOfWork.MakeRepository.GetAll();

            return makes == null ? NotFound() 
                : Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {

            var make = await _unitOfWork.MakeRepository.Get(q=>q.Id == id);

            return make == null ? NotFound() : Ok(make);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }
            _unitOfWork.MakeRepository.Update(make);
           

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            await _unitOfWork.MakeRepository.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.MakeRepository.Get(q=> q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            await _unitOfWork.MakeRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);
                      
            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var make = await _unitOfWork.MakeRepository.Get(q => q.Id == id);
                return make == null;
        }
    }
}
