namespace projeto_desconto;
class Program
{
    static void Main(string[] args){
    
        //para declarar tudo/Produto p1 = new Produto();
       //para declarar só o nome/ Produto p1 = new Produto("ABC");
       //para declarar nome e desconto/ Produto p1 = new Produto("ABC");
       Produto p1 = new Produto("ABC", 10);
       p1.MostrarDados();
    }
}
