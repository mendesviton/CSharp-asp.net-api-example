﻿using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : GenericController<PlantaModel, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {
        }
    }
}
