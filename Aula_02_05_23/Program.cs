namespace Aula_02_05_23;
class Program
{
    static void Main(string[] args)
    {
        FuncN1 N1 = new FuncN1();
        FuncN2 N2 = new FuncN2();
        FuncN3 N3 = new FuncN3();

        N1.Nome = "Tereza";
        N1.Idade = 48;
        N2.Nome = "Cintia";
        N2.Idade = 41;
        N3.Nome = "Fulano";
        N3.Idade = 23;
        N3.Cargo = "Gerente";

        Console.WriteLine("Nome: " + N1.Nome + " -- Idade: " + N1.Idade + " -- Lucro: " + N1.Lucro());
        Console.WriteLine("Nome: " + N2.Nome + " -- Idade: " + N2.Idade + " -- Lucro: " + N2.Lucro());
        Console.WriteLine("Nome: " + N3.Nome + " -- Idade: " + N3.Idade + " -- Lucro: " + N3.Lucro() + " -- Cargo: " + N3.Cargo);
    }
}
