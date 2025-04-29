using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05ExemploMvcPratico.Models;
using _05ExemploMvcPratico.Context;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult Index(string filtro, DateTime? dataFiltro, bool? statusFiltro)
    {
        var tarefas = _context.Tarefas.AsQueryable();

        // Filtro por título ou descrição
        if (!string.IsNullOrEmpty(filtro))
        {
            tarefas = tarefas.Where(t => t.Titulo.Contains(filtro) || t.Descricao.Contains(filtro));
        }

        // Filtro por data
        if (dataFiltro.HasValue)
        {
            tarefas = tarefas.Where(t => t.Data.Date == dataFiltro.Value.Date);
        }

        // Filtro por status (só aplica se o filtro foi enviado)
        if (statusFiltro.HasValue)
        {
            tarefas = tarefas.Where(t => t.Status == statusFiltro.Value);
        }

        // Armazenar os filtros na ViewData para manter os valores nos inputs
        ViewData["Filtro"] = filtro;
        ViewData["DataFiltro"] = dataFiltro?.ToString("yyyy-MM-dd");
        ViewData["StatusFiltro"] = statusFiltro;

        return View(tarefas.ToList());
    }



    public IActionResult Criar()
    {
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
        return View();
    }
    public IActionResult Editar(int id)
    {
        var tarefa = _context.Tarefas.Find(id);

        if (tarefa == null)
            return RedirectToAction(nameof(Index));
        return View(tarefa);
    }
    [HttpPost]
    public IActionResult Editar(Tarefa tarefa)
    {
        var tarefaBanco = _context.Tarefas.Find(tarefa.Id);

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
