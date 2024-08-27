using MeuprimeiroMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuprimeiroMvc.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Joaquim Guilherme de Souza Ramos", "jotagesr@gmail.com", 4795);
            Aluno a2 = new Aluno(2, "Luiz Guilherme Vieira de Melo", "luiz.melo@gmail.com", 1337);
            Aluno a3 = new Aluno(3, "Thiago Mazzi", "thigas@gmail.com", 9213);
            Aluno a4 = new Aluno(4, "João Rodolfo Fiamengui da Costa", "joao.rodorfo@gmail.com", 7777);
            Aluno a5 = new Aluno(5, "Bruno Henrique Martins Alves", "contato.bruno@gmail.com", 6969);
            Aluno a6 = new Aluno(6, "Ryan Rattini Ribeiro", "rya.rr@gmail.com", 2024);

            //Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicinar os Objetos Alunos na Lista Alunos
            //listaAlunos.Add(a1);
            //listaAlunos.Add(a2);
            //listaAlunos.Add(a3);
            //listaAlunos.Add(a4);
            //listaAlunos.Add(a5);
            //listaAlunos.Add(a6);
            for (int i = 0; i < listaAlunos.Count; i++)
            {
                listaAlunos.Add(listaAlunos[i]);
            }

            //Enviando a lista de alunos por parâmetro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
