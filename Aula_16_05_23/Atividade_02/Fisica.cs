namespace Atividade_02;
class Fisica: Contrato
{
    public string? cpf {get;set;}
    public int idade {get;set;}

    public override string Base(){
        return base.Base() + " " + this.cpf + " " + this.idade;
    }

}
