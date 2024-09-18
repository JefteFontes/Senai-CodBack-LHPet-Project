using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Jefte F. de Araujo", "123.456.789-00", "jefte@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "David R. da Silva", "234.567.890-11", "david@sp.senai.br", "Bug");
        Cliente cliente3 = new Cliente(03, "Hyann G. Oliveira", "345.678.901-22", "hyann@sp.senai.br", "Pinguim");
        Cliente cliente4 = new Cliente(04, "Samuel C. Santos", "456.789.012-33", "samuel@sp.senai.br", "Byron");
        Cliente cliente5 = new Cliente(05, "Evaldo C. Rodrigues", "567.890.123-44", "evaldo@sp.senai.br", "Pantufa");

        //Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        //Instancia do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Mundo Animal Suprimentos", "11.234.567/0001-33", "suporte@mundoanimal.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Rações Premium Distribuidora", "12.345.678/0002-44", "vendas@racoespremium.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "PetBrinquedos Importadora", "13.456.789/0003-55", "comercial@petbrinquedos.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Banho e Tosa Equipamentos Ltda", "14.567.890/0004-66", "contato@banhoetosaequip.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "VetMed Produtos Veterinários", "15.678.901/0005-77", "vendas@vetmed.com");

        //Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
