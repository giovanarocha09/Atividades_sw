namespace Atividade_02;
class Importado:Produto
{
    public double Taxa {get;set;}
    public double Taxaimport{get;set;}
    public override double CalculaValor()
    {
        base.CalculaValor();

        Console.Write("Valor da taxa: ");
        Taxa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor da taxa da importação: ");
        Taxa = Convert.ToDouble(Console.ReadLine());
        
        return (Valor*(1+(Imposto/100))) + (Valor*(1+(Taxa/100)) + (Valor*(1+(Taxaimport/100))));
    }
}
