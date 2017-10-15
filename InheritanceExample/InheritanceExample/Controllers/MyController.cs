using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InheritanceExample.Controllers
{
    [Produces("application/json")]
    [Route("api/my")]
    public class MyController : Controller
    {
        private readonly MyContext _context;

        public MyController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Hunters.Include(h => h.KilledAnimals).ToListAsync());
        }
    }
}