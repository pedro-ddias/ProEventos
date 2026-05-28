using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEnumerable<Evento> _evento = new Evento[] {
            new Evento() { EventoId = 1, Tema = "Angular e .NET", Local = "Belo Horizonte", DataEvento = "2024-06-01", QtdPessoas = 250, Lote = "1º Lote", ImagemURL = "foto.png" },
            new Evento() { EventoId = 2, Tema = "Angular e .NET", Local = "São Paulo", DataEvento = "2024-07-01", QtdPessoas = 350, Lote = "2º Lote", ImagemURL = "foto.png" }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }
    }
}
