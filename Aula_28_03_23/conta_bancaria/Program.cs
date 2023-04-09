namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conta bancaria");
        Conta conta = new Conta();

        conta.Depositar(500);
        conta.AjustaLimite(500);
        conta.Sacar(900);

        Console.WriteLine("Valor total na sua conta: "+ conta.MostraSaldo());
    }
}
