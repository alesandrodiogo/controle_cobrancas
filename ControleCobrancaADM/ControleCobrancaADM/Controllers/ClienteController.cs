using ControleCobrancaADM.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleCobrancaADM.Controllers
{
    public class ClienteController : Controller
    {
        public static IList<Clientes> _clientes = new List<Clientes>();
        public ClienteController()
        {
            if (_clientes.Count.Equals(0))
            {
                _clientes.Add(new Clientes() { Nome = "Pericles Jaime", Idade = 25, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro" }); ;
                _clientes.Add(new Clientes() { Nome = "Alesandro Diogo", Idade = 23, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro" });
                _clientes.Add(new Clientes() { Nome = "Edgar Domingos", Idade = 27, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro", });
            }

        }
        public IActionResult Listar()
        {
            return View(_clientes);
        }
    }
}
