using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // a view index lê essa chave para exibir o valor da mensagem
        ViewData["Mensagem"] = "Bem-vindo ao sistema!";
        return View();
    }

    //action que recebe parametro pela rota: /controller/Sobre
    public IActionResult Sobre(int? id )
    {
        //id pode ser nulo poeque o trecho final da rota é opcional 
        ViewBag.Versao ="1.0";
        ViewBag.ParametroId = id;
        return View();
    }
   
    //action que recebe parametro via query string: /Home/Saudacao?nome =kessia
    public IActionResult Saudacao(string nome)
    {
        ViewData["nome"] = nome ?? "Visitante";
        
        return View();
    }
   
}
