﻿using System;
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
        public IEnumerable<Evento> _evento = new Evento [] 
            {
                new Evento()
                {
                    EventoID = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Goiânia",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemUrl = "Foto.jpg"
                },
                new Evento()
                {
                    EventoID = 2,
                    Tema = "C# Básico",
                    Local = "Goiânia",
                    Lote = "1º Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy"),
                    ImagemUrl = "Foto2.jpg"
                }
            };
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(px => px.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
