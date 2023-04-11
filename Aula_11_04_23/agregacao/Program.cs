namespace agregacao;
class Program
{
    static void Main(string[] args){

        Console.WriteLine("TRABALHANDO COM AGREGAÇÃO");

        //Como instanciar um objeto

        Cartao cdc = new Cartao();
        Cliente cli = new Cliente();

        //Nome para cliente
        cli.Nome = "Gih Rocha";

        //Numero e Validade do Cartao
        cdc.Numero = "12344321";
        cdc.Validade = "23/2025";

        //Associando Cliente ao atributo de agregação do cartao
        cdc.Cliente = cli;

        //Visualização 

        Console.WriteLine("O Nome do Cliente: " + cli.Nome);
        Console.WriteLine("O número do cartão: " + cdc.Numero);
        Console.WriteLine("A data de Validade: " + cdc.Validade);
        Console.WriteLine("O Nome do Cliente AGREGADO: " + cdc.Cliente.Nome);

    }
}
