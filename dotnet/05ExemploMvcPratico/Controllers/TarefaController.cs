using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05ExemploMvcPratico.Models;
using _05ExemploMvcPratico.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _05ExemploMvcPratico.Controllers;

public class TarefaController : Controller
{
    private readonly TarefaContext _context;

    public TarefaController(TarefaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var tarefas = _context.Tarefas.ToList();
        return View(tarefas);
    }

    [HttpGet]
    public IActionResult Index(string filtro, DateTime? dataFiltro, string statusFiltro)
    {
        var tarefas = _context.Tarefas.AsQueryable();

        if (!string.IsNullOrEmpty(filtro))
        {
            tarefas = tarefas.Where(t => t.Titulo.Contains(filtro) || t.Descricao.Contains(filtro));
        }

        if (dataFiltro.HasValue)
        {
            tarefas = tarefas.Where(t => t.Data.Date == dataFiltro.Value.Date);
        }

        // Modificação para garantir a conversão correta do status
        if (!string.IsNullOrEmpty(statusFiltro) && Enum.TryParse<StatusTarefa>(statusFiltro, out var status))
        {
            tarefas = tarefas.Where(t => (int)t.Status == (int)status); // Garantir que Status seja comparado como int
        }

        ViewData["Filtro"] = filtro;
        ViewData["DataFiltro"] = dataFiltro?.ToString("yyyy-MM-dd");
        ViewData["StatusFiltro"] = statusFiltro;

        return View(tarefas.ToList());
    }

    public IActionResult Criar()
    {
        ViewBag.Statuses = Enum.GetValues(typeof(StatusTarefa))
            .Cast<StatusTarefa>()
            .Select(s => new SelectListItem
            {
                Value = s.ToString(),
                Text = s == StatusTarefa.EmAndamento ? "Em andamento" :
                    s == StatusTarefa.Concluida ? "Concluída" : "Pendente"
            }).ToList();

        return View();
    }

    [HttpPost]
    public IActionResult Criar(Tarefa tarefa)
    {
        if (ModelState.IsValid)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Statuses = Enum.GetValues(typeof(StatusTarefa))
            .Cast<StatusTarefa>()
            .Select(s => new SelectListItem
            {
                Value = s.ToString(),
                Text = s == StatusTarefa.EmAndamento ? "Em andamento" :
                    s == StatusTarefa.Concluida ? "Concluída" : "Pendente"
            }).ToList();

        return View(tarefa);
    }

    public IActionResult Editar(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        if (tarefa == null)
            return RedirectToAction(nameof(Index));

        ViewBag.Statuses = Enum.GetValues(typeof(StatusTarefa))
            .Cast<StatusTarefa>()
            .Select(s => new SelectListItem
            {
                Value = s.ToString(),
                Text = s == StatusTarefa.EmAndamento ? "Em andamento" :
                    s == StatusTarefa.Concluida ? "Concluída" : "Pendente"
            }).ToList();

        return View(tarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefa)
    {
        if (!ModelState.IsValid)
        {
            // Recarrega lista de Status para a view em caso de erro de validação
            ViewBag.Statuses = Enum.GetValues(typeof(StatusTarefa))
                .Cast<StatusTarefa>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s == StatusTarefa.EmAndamento ? "Em andamento" :
                        s == StatusTarefa.Concluida ? "Concluída" : "Pendente"
                }).ToList();

            return View(tarefa);
        }

        var tarefaBanco = _context.Tarefas.Find(tarefa.Id);
        if (tarefaBanco == null)
            return RedirectToAction(nameof(Index));

        tarefaBanco.Titulo = tarefa.Titulo;
        tarefaBanco.Descricao = tarefa.Descricao;
        tarefaBanco.Data = tarefa.Data;
        tarefaBanco.Status = tarefa.Status;

        _context.Tarefas.Update(tarefaBanco);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Detalhes(int id)
    {
        var tarefa = _context.Tarefas.Find(id);

        if (tarefa == null)
            return RedirectToAction(nameof(Index));
        return View(tarefa);
    }
    public IActionResult Deletar(int id)
    {
        var tarefa = _context.Tarefas.Find(id);

        if (tarefa == null)
            return RedirectToAction(nameof(Index));
        return View(tarefa);
    }

    [HttpPost]
    public IActionResult Deletar(Tarefa contato)
    {
        var tarefaBanco = _context.Tarefas.Find(contato.Id);

        _context.Tarefas.Remove(tarefaBanco);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}
