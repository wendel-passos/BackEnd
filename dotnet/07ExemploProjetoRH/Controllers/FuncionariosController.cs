using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _07ExemploProjetoRH.Models;
using System.Text.Json;

namespace _07ExemploProjetoRH.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index(string searchNome, string searchDepartamento, DateTime? searchAdmissao)
        {
            var funcionarios = _context.Funcionarios
                .Where(f => f.Ativo)
                .AsQueryable();


            if (!string.IsNullOrEmpty(searchNome))
            {
                funcionarios = funcionarios.Where(f => f.Nome.Contains(searchNome));
            }

            if (!string.IsNullOrEmpty(searchDepartamento))
            {
                funcionarios = funcionarios.Where(f => f.Departamento.Contains(searchDepartamento));
            }

            if (searchAdmissao.HasValue)
            {
                funcionarios = funcionarios.Where(f => f.DataAdmissao.HasValue && f.DataAdmissao.Value.Date == searchAdmissao.Value.Date);
            }

            ViewData["CurrentFilterNome"] = searchNome;
            ViewData["CurrentFilterDepartamento"] = searchDepartamento;
            ViewData["CurrentFilterAdmissao"] = searchAdmissao?.ToString("yyyy-MM-dd");

            return View(await funcionarios.ToListAsync());
        }


        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Endereco,Ramal,EmailProfissional,Departamento,Salario,DataAdmissao")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionario);
                await _context.SaveChangesAsync();

                // Grava log de inclusão
                var log = new FuncionarioLog(funcionario, TipoAcao.Inclusao)
                {
                    Timestamp = DateTimeOffset.Now
                };
                _context.FuncionariosLog.Add(log);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Endereco,Ramal,EmailProfissional,Departamento,Salario,DataAdmissao")] Funcionario funcionario)
        {
            if (id != funcionario.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();

                    

                    // Grava log de atualização
                    var log = new FuncionarioLog(funcionario, TipoAcao.Atualizacao)
                    {
                        Timestamp = DateTimeOffset.Now,
                        JSON = JsonSerializer.Serialize(funcionario),
                    };
                    _context.FuncionariosLog.Add(log);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario != null)
            {
                funcionario.Ativo = false;

                var log = new FuncionarioLog(funcionario, TipoAcao.Remocao)
                {
                    Timestamp = DateTimeOffset.Now
                };
                _context.FuncionariosLog.Add(log);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }



        private bool FuncionarioExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }
    }
}
