using Microsoft.AspNetCore.Mvc;
using System;
namespace aspcore_tutorial.Controllers
{
    public class AdminController : Controller 
    {
         public IActionResult Index(){
             return Content("Ola mundo! Eu quero uma branch nova BBBBBBBBBB");
         }
    }
}