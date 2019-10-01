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
    public class MarcaRepository
    {
        private readonly ESXDataContext _context;

        public MarcaRepository(ESXDataContext context)
        {
            _context = context;
        }

        public IEnumerable<MarcaViewModel> Get()
        {
            return _context
                .Marca
                .Select(x => new MarcaViewModel
                {
                    MarcaId = x.MarcaId,
                    Nome = x.Nome
                  
                })
                .ToList();
        }
        public Marca GetById(int id)
        {
            return _context.Marca.Find(id);
        }
        public void Save(Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();
        }
        public void Update(Marca marca)
        {
            _context.Entry<Marca>(marca).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            _context.Marca.Remove(_context.Marca.Where(x=>x.MarcaId==Id).First());
            _context.SaveChanges();
        }
    }
}
