using ControleCobrancaADM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ControleCobrancaADM.Controllers
{
    public class ClienteController : Controller
    {
        public static IList<Clientes> _clientes = new List<Clientes>();
        public ClienteController()
        {
            if (_clientes.Count.Equals(0))
            {
                _clientes.Add(new Clientes() { Id = 1, Nome = "Pericles Jaime", Idade = 25, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro" }); ;
                _clientes.Add(new Clientes() { Id = 2, Nome = "Alesandro Diogo", Idade = 23, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro" });
                _clientes.Add(new Clientes() { Id = 3, Nome = "Edgar Domingos", Idade = 27, Pais = "Angola", Morada = "Luanda/Angola", DataNascimento = DateTime.Now, EstadoCivil = "Solteiro", });
            }
             
        }
        public IActionResult Listar()
        {
            return View(_clientes);
        }
        public IActionResult Edit(int id)
        {
            var cliente = _clientes.FirstOrDefault(x => x.Id.Equals(id));
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Edit([FromForm] Clientes cliente)
        {
            var clienteSelecionado = _clientes.FirstOrDefault(x => x.Id.Equals(cliente.Id));
            clienteSelecionado.Nome = cliente.Nome;
            clienteSelecionado.Idade = cliente.Idade;
            clienteSelecionado.Pais = cliente.Pais;
            clienteSelecionado.Morada = cliente.Morada;
            clienteSelecionado.DataNascimento = cliente.DataNascimento;
            clienteSelecionado.EstadoCivil = cliente.EstadoCivil;
            return RedirectToAction("Listar");
        }

        public IActionResult Novo() 
        { 
            return View(new Clientes());
        }
        [HttpPost]
        public IActionResult Novo([FromForm] Clientes clienteNovo)
        {
            _clientes.Add(clienteNovo);
            return RedirectToAction("Listar");
        }
        /*[HttpDelete]
        public IActionResult Deletar([FromForm] Clientes cliente, int id)
        {
            _clientes.RemoveAt(cliente.Id);
            return View("Listar");
        }*/
    }
}
