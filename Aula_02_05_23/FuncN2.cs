namespace Aula_02_05_23;
class FuncN2:Funcionario
{
    public override double Lucro(){
        return base.Lucro()* 0.02;
    }
}