namespace Atividade_02;
class Juridica: Contrato
{
    public string? cnpj {get;set;}
    public string? IE {get;set;}
    public string? NE {get;set;}

    public override string Base(){
        return base.Base() + " " + this.cnpj + " " + this.IE + " " + this.NE;
    }

}
