using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESXSol.Models;
using ESXSol.Repositories;
using ESXSol.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ESXSol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatrimonioController : ControllerBase
    {

        private readonly PatrimonioRepository _repository;

        public PatrimonioController(PatrimonioRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<PatrimonioViewModel>> Get()
        {
            return Ok(_repository.Get());

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PatrimonioViewModel> Get(int id)
        {
            var result = _repository.GetById(id);
            
            return Ok(result);
             
        }

        // POST api/values
        [HttpPost]
        public ResultViewModel Post([FromBody] Patrimonio value)
        {
             var ret = _repository.InserirPatrimonio(value);
           
            return new ResultViewModel
            {
                Success = true,
                Message = "Produto cadastrado com sucesso!",
                Data = value
            };

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ResultViewModel Put(int id, [FromBody]Patrimonio value)
        {
            var result = _repository.InserirPatrimonio(value);
            return new ResultViewModel
            {
                Success = true,
                Message = "Produto alterado com sucesso!",
                Data = result
            };
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ResultViewModel Delete(int id)
        {
            var result = _repository.ExcluirPatrimonio(id);
            return new ResultViewModel
            {
                Success = true,
                Message = "Produto excluido com sucesso!",
                Data = result
            };
        }
    }
}
