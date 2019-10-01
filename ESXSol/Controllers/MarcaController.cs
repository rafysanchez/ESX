using ESXSol.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Controllers
{
    public class MarcaController : ControllerBase
    {
        private readonly MarcaRepository _repository;
        public MarcaController(MarcaRepository repository)
        {
            _repository = repository;
        }




    }
}
