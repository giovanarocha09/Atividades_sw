namespace Atividade_02;
class Program
{
    static void Main(string[] args)
    {
        Estadual est = new Estadual();
        Nacional nac = new Nacional();
        Importado imp = new Importado();

        Console.WriteLine("Sua compra é Nacional, Estadual ou Importada?");
        string caso = Console.ReadLine();

       switch (caso)
        {
            case "Nacional":
                Console.WriteLine("O valor da sua compra é de: " + nac.CalculaValor());
                break;

            case "Estadual":
                Console.WriteLine("O valor da sua compra é de: " + est.CalculaValor());
                break;

            case "Importada":
                Console.WriteLine("O valor da sua compra é de: " + imp.CalculaValor());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
        
    }
}
