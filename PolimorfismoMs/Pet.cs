using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoMs
{
    public abstract class Pet
    {
        public Pet(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; } = string.Empty;

        public int Idade { get; set; }

        public abstract string EmiteSom();
    }
}
