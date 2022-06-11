using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_BackEnd_Eterna.DAL;
using Project_BackEnd_Eterna.ViewModels;
using System.Threading.Tasks;

namespace Project_BackEnd_Eterna.Containers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public async Task<IActionResult> Index()
        {

            ServiceVM model = new ServiceVM
            {
                Carts = await _context.Carts.ToListAsync(),
                Statistics = await _context.Statistics.FirstOrDefaultAsync()
            };

            return View(model);
        }

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
    }
}
