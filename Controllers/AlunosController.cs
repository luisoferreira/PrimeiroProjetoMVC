using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers
{
    public class AlunosController : Controller
    {

        private static List<Aluno> _alunos = new()
        {
            new Aluno { Id = 1, Nome = "Ronaldo", Email = "fenomeno@gmail.com", Idade = 50},
            new Aluno { Id = 1, Nome = "Cafu", Email = "cafu@hotmail.com", Idade = 56}
        };

        // GET /Alunos - listar todos os alunos
        public IActionResult Index()
        {
            return View(_alunos);
        }

        //GET /Alunos/Detalhes/1 -mostrar um aluno especifico
        public IActionResult Detalhes(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET /Alunos/Criar -retomar a view de criação de alunos
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        // POST /Alunos/criar -recebe dados da View Criar()
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno); //retoma para tela de cadatro com erros de validação
            }

            // if(_alunos.Any())
            // {
            //     aluno.Id = _alunos.Max(a => a.Id + 1);
            // }
            // else
            // {
            //     aluno.Id =1;
            // }

            aluno.Id = _alunos.Any() ? _alunos.Max(a => a.Id) + 1 : 1;
            _alunos.Add(aluno);
            
            return RedirectToAction("Index");
        }

    }
}
    
