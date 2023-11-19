using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoMs
{
    public class Pessoa
    {
        
            public Pessoa(string nome, DateOnly idade)
            {
                this.Nome = nome;
                this.Idade = idade;
            }

            public string Nome { get; private set; }
            public DateOnly Idade;
            public List<Pet> Pets = new();

            public void AlterarNome(string nome) => Nome = nome;
        
    }
}
