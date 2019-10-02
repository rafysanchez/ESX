using ESXSol.Data;
using ESXSol.Models;
using ESXSol.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Repositories
{
    public class PatrimonioRepository
    {
        private readonly ESXDataContext _context;

        public PatrimonioRepository(ESXDataContext context)
        {
            _context = context;
        }

        public List<PatrimonioViewModel> Get()
        {
            var linhas = (from tsk in _context.Patrimonio.Include(t => t.Marcas)
                        select tsk).ToList();

 
           var l = linhas
                .Select(x => new PatrimonioViewModel
                {
                    Id = x.Id,
                    Descricao = x.Descricao,
                    MarcaId = x.MarcaId,
                    No_Tombo = x.No_Tombo,
                    Marcas = x.Marcas
                  
                })
                .ToList();
            return l;
        }

        public PatrimonioViewModel GetById(int Id)
        {
            return _context
                           .Patrimonio
                           .Include(x => x.Marcas)
                           .Select(x => new PatrimonioViewModel
                           {
                               Id = x.Id,
                               Descricao = x.Descricao,
                               MarcaId = x.MarcaId,
                               No_Tombo = x.No_Tombo,
                               Marcas = x.Marcas

                           })
                           .Where(x => x.Id == Id)
                           .SingleOrDefault();

        }

        public bool InserirPatrimonio(Patrimonio patrimonio)
        {
            try
            {
                _context.Add(patrimonio);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExcluirPatrimonio(int Id)
        {
            try
            {
                _context.Remove(_context.Patrimonio.Where(x => x.Id == Id).First());
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool AlterarPatrimonio(Patrimonio patrimonio)
        {
            try
            {
                _context.Update(patrimonio);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
