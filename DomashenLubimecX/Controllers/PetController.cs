using Microsoft.AspNetCore.Mvc;
using DomashenLubimecX.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomashenLubimecX.Models;

namespace DomashenLubimecX.Controllers
{
    public class PetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Info()
        {
            var petInfo = await _context.PetInfos.FirstOrDefaultAsync();
            /*
            if (petInfo == null)
            {
                return NotFound("Пухчо е игриво котенце, което обича да се гушка, да гони лазерче и да спи на слънце.");
            }
            */
            return View(petInfo);
        }
    }
}
