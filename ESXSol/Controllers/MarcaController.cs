using ESXSol.Models;
using ESXSol.Repositories;
using ESXSol.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly MarcaRepository _repository;
        public MarcaController(MarcaRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MarcaViewModel>> Get()
        {
            return Ok(_repository.Get());

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MarcaViewModel> Get(int id)
        {
            var result = _repository.GetById(id);

            return Ok(result);

        }

        // POST api/values
        [HttpPost]
        public ResultViewModel Post([FromBody] Marca value)
        {
            var marca = new Marca();
            marca.Nome = value.Nome;


            _repository.Save(marca);

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto cadastrado com sucesso!",
                Data = marca
            };

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ResultViewModel Put(int id, [FromBody]Marca value)
        {
            var marca = _repository.GetById(value.MarcaId);

            marca.Nome = value.Nome;
            _repository.Update(marca);

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto alterado com sucesso!",
                Data = marca
            };
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ResultViewModel Delete(int id)
        {
            var marca = _repository.GetById(id);

            _repository.Delete(id);

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto excluido com sucesso!",
                Data = marca
            };
        }


    }
}
