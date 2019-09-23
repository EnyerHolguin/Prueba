using PruebaHolguin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHolguin.DAL.Scripts
{
    public class Contexto : DbContex
    {
        public Dbset<Basedato> dato { get; set; }
        public Contexto() : base("conStr")
        {   }

    }
    
}
