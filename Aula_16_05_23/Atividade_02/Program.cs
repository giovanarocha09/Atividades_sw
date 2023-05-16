namespace Atividade_02;
class Program
{
    static void Main(string[] args)
    {
        Fisica fis = new Fisica();
        Juridica jur = new Juridica();
    
        Console.WriteLine("Você é uma pessoa física ou juridica?");
        Console.ReadLine();
       if("física"){
        Console.WriteLine(fis.Base());
       } 
       else{
        Console.WriteLine(jur.Base());
       }

    }
}
