using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _07ExemploProjetoRH.Models;

namespace _07ExemploProjetoRH.Controllers
{
    public class FuncionariosLogsController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionariosLogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FuncionariosLogs
        public async Task<IActionResult> Index(string searchNome, string searchDepartamento, string searchTipoAcao)
        {
            var logs = from l in _context.FuncionariosLog
                    select l;

            if (!string.IsNullOrEmpty(searchNome))
            {
                logs = logs.Where(l => l.Nome.Contains(searchNome));
            }
            if (!string.IsNullOrEmpty(searchDepartamento))
            {
                logs = logs.Where(l => l.Departamento.Contains(searchDepartamento));
            }
            if (!string.IsNullOrEmpty(searchTipoAcao))
            {
                logs = logs.Where(l => l.TipoAcao.ToString() == searchTipoAcao);
            }

            ViewData["CurrentFilterNome"] = searchNome;
            ViewData["CurrentFilterDepartamento"] = searchDepartamento;
            ViewData["CurrentFilterTipoAcao"] = searchTipoAcao;

            return View(await logs.ToListAsync());
        }


        // GET: FuncionariosLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var funcionarioLog = await _context.FuncionariosLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarioLog == null)
                return NotFound();

            return View(funcionarioLog);
        }
    }
}
