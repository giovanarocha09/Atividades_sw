namespace Atividade_02;
class Nacional:Produto
{

    public double Taxa {get;set;}
    public override double CalculaValor()
    {
        base.CalculaValor();

        Console.Write("Valor da taxa: ");
        Taxa = Convert.ToDouble(Console.ReadLine());

        return Valor*((1+(Imposto/100) + (1+(Taxa/100))));
}
}