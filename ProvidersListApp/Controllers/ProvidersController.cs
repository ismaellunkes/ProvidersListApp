using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProvidersListApp.Models;
using ProvidersListApp.Services;

namespace ProvidersListApp.Controllers
{
    public class ProvidersController : Controller
    {
        private readonly ProviderService _ProviderService;       
        public ProvidersController(ProviderService providerService)
        {
            _ProviderService = providerService;           
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            var list = await _ProviderService.FindAllAsync();
            return View(list);
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = await _ProviderService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        // GET: Addresses/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Provider provider, Company company)
        {
            if (!ModelState.IsValid)
            {
                return View(provider);
            }
            await _ProviderService.InsertAsync(provider, company);
            return RedirectToAction(nameof(Index));
        }
    }
}