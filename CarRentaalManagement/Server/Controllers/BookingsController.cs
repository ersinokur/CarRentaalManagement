using CarRentaalManagement.Server.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentaalManagement.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public BookingsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    // GET: api/Bookings
    [HttpGet]
    public async Task<IActionResult> GetBookings()
    {
        var bookings = await _unitOfWork.BookingRepository.GetAll();

        return bookings == null ? NotFound()
            : Ok(bookings);
    }

    // GET: api/Bookings/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooking(int id)
    {
        var booking = await _unitOfWork.BookingRepository.Get(q => q.Id == id);

        return booking == null ? NotFound() : Ok(booking);
    }

    // PUT: api/Bookings/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutBooking(int id, Booking booking)
    {
        if (id != booking.Id)
        {
            return BadRequest();
        }
        _unitOfWork.BookingRepository.Update(booking);


        try
        {
            await _unitOfWork.Save(HttpContext);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await BookingExists(id))
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

    // POST: api/Bookings
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Booking>> PostBooking(Booking booking)
    {
        await _unitOfWork.BookingRepository.Insert(booking);
        await _unitOfWork.Save(HttpContext);

        return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
    }

    // DELETE: api/Bookings/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var booking = await _unitOfWork.BookingRepository.Get(q => q.Id == id);

        if (booking == null)
        {
            return NotFound();
        }

        await _unitOfWork.BookingRepository.Delete(id);
        await _unitOfWork.Save(HttpContext);

        return NoContent();
    }
            
    private async Task<bool> BookingExists(int id)
    {
        var booking = await _unitOfWork.BookingRepository.Get(q => q.Id == id);
        return booking   == null;
    }
}    
