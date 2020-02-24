using Microsoft.AspNetCore.Mvc;
using System;
namespace aspcore_tutorial.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller 
    {
        [HttpGet("{nome}")]
         public IActionResult Index(string nome){
             return Content("Olá,  " + nome);
         }
         
        //tipando um parametro na rota
        //tornando o parametro opcional
        [HttpGet("soma/{numero:int?}/{nome}")]
         public IActionResult Soma(int numero, string nome){
             return Content("O número é: " + numero + " e o nome é " + nome);
         }   

        [HttpGet("produto")]
         public IActionResult QueryString(){
             var id = Request.Query["id"];
             return Content("O seu id é: " + id);

         }

    }
}