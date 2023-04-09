namespace Exercicio_Aluno;
class Program
{
    static void Main(string[] args){

        Aluno aluno1 = new Aluno();
        
        Console.WriteLine();
        Console.Write("Digite seu nome: ");
        aluno1.nome = Console.ReadLine();

        Console.Write("Digite a primeira nota( no modo double): ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        
        Console.Write("Digite a segunda nota( no modo double): ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
        
        aluno1.mensagem();
        Console.WriteLine();
    }
}
