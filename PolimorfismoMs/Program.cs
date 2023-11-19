

using PolimorfismoMs;

internal class Program
{
    public static void Main(string[] args)
    {
        var p1 = new Pessoa("Marcus", new DateOnly(1982, 05, 07));
        var p2 = new Pessoa("Yuri", new DateOnly(1997, 12, 14));
        var p3 = new Pessoa("Manoel", new DateOnly(1987, 05, 11));
        
        p1.AlterarNome("Marcus Antonio Souza Da Silva");

        p1.Pets.Add(new Cachorro("doguinho"));
        p1.Pets.Add(new Gato("gatinho", 02));


        Console.WriteLine($" Eu me chamo {p2.Nome}");
        Console.WriteLine($" E tenho {p1.Pets.Count} Pets");
        Console.WriteLine($" meu cachorro se chama {"Doguinho"} e meu gato se chama {"Gatinho"}");

        foreach (var animal in p1.Pets)
        {
            Console.WriteLine($" Meu {animal.GetType().Name} faz {animal.EmiteSom()}");
        }
    }
}