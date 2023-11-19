using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoMs
{
    public class Cachorro : Pet
    {
        public Cachorro(string nome) : base(nome) {}

        public override string EmiteSom() => "Au Au";
    }

}
