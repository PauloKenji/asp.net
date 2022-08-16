using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models; 

namespace ExemploAspNetMvc.Controllers;

public class UserResquest{

    public string Nome { get; set; }
    public string Email { get; set; }
    public int Idade { get; set; }
}

public class HomeController : Controller
{
    

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }
    
    public IActionResult Formulario(){
        return View();
    }

    public String TesteQueryString([FromQuery]  String q, String nome)
    {
        return $"Chegou aqui {q} para {nome}";
    }   

    public String TestFormData([FromForm] UserResquest userRequest, [FromHeader] string valor)
    {
        return $"Nome: {userRequest.Nome}, Email: {userRequest.Email}, valor: {valor}";    
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
