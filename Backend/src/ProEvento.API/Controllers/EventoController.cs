using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models; // importando o Model para a propriedade Evento


namespace ProEvento.API.Controllers
{

    // Route() é a rota. controller é o nome do arquivo que esta controlando a intermediacao entre cliente e servidor,
    // nesse caso, é o EventoController.cs.
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {

        }



        [HttpGet]
        public Evento Get()
        {
           return new Evento()
           {
               EventoId = 1,
               Tema = "Encontro Turma .Net",
               Local = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString()
           };
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Metodo Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Metodo Delete com id = {id}";
        }
    }
}
