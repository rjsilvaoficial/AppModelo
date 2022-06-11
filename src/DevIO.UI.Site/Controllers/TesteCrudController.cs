using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {

        private readonly MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Chico",
                Email = "chico@gmail.com",
                DataNascimento = DateTime.Now.Date

            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var alunoEmail = _context.Alunos.FirstOrDefault(aluno => aluno.Email == "email@xpto");
            var alunoList1 = _context.Alunos.Select(aluno => aluno.Email == "email@xpto");
            var alunoList2 = _context.Alunos.Where(aluno => aluno.Email == "email@xpto");

            aluno.Nome = "Joao";
            _context.Update(aluno);
            // int retorno recebe a qtd de linhas afetadas por savechanges, fique atento
            int retorno = _context.SaveChanges(); 

            _context.Remove(aluno);
            _context.SaveChanges();

            return View();
        }
    }
}
