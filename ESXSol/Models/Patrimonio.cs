using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Models
{
    public class Patrimonio
    {
        public Patrimonio()
        {
            
        }
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public Guid No_Tombo { get; set; }

        public virtual Marca Marcas { get; set; }

    }
}
