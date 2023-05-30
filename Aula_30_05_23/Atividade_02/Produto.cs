namespace Atividade_02;
class Produto
{
    public string? Descricao {get;set;}
    public double Valor {get;set;}
    public double Imposto {get;set;}

    public virtual  double CalculaValor(){

        Console.Write("Desrção do Produto: ");
        Descricao = Console.ReadLine();

        Console.Write("Digite o Valor: ");
        Valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o Valor do Imposto: ");
        Imposto = Convert.ToDouble(Console.ReadLine());
        
        return Valor*(1+(Imposto/100));
    }
}
