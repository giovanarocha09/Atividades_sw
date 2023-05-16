namespace Atividade_02;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}

    public virtual string Base(){
        string Tudo = (this.Nome + " , seu e-mail é " + this.Email +  " e seu telefone é " + this.Tel);
        return Tudo;
    }

}
