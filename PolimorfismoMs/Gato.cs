using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoMs
{
    public class Gato : Pet
    {
        public Gato(string nome, int idade) : base(nome)
        {
            this.Idade = idade;
        }

        public override string EmiteSom() => "Miau";
    }

}
