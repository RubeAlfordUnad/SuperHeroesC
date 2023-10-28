using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {

        public abstract string Name { get; set; }


        public abstract string SalvarElMundo();

        public virtual string SalvarLaTierra()
        {
            return $"{Name} ha salvado la tierra !";
        }
    }
}
