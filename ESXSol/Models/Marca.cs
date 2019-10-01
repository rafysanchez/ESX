using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Models
{
    public class Marca
    {
        [Key] 
        public int MarcaId { get; set; }

        public string Nome { get; set; }


    }
}
