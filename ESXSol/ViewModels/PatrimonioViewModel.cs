using ESXSol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.ViewModels
{
    public class PatrimonioViewModel
    {

        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public Guid No_Tombo { get; set; }

        public IEnumerable<Marca> Marcas { get; set; }
    }
}
