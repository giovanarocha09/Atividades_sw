﻿namespace projeto_pessoa;
class Pessoa{

    //para todo metodo construtor o nome é o mesmo da classe
    //Metodo Construtor para quando não for informado nenhum dado
    public Pessoa(){
        this.Nome = "Não Informado";
        this.Sobrenome = "Não Informado";
        this.Idade = 0;
    }

    //Metodo Construtor para sobre nome não obrigatorio
    //colocar dados dentro do prog principal
    public Pessoa(string nome, int idade){
        this.Nome = nome;
        this.Sobrenome = "Não Informado";
        this.Idade = idade;
    }

    private string? Nome{get;set;}
    private string? Sobrenome{get;set;}
    private int Idade{get;set;}

    public void AlteraNome(string nome){
        this.Nome = nome;
    }

    public void AlteraSobrenome(string sobrenome){
        this.Sobrenome = sobrenome;
    }

    public void AlteraIdade(int idade){
        this.Idade = idade;
    }

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Sobrenome: " + this.Sobrenome);
        Console.WriteLine("Idade: " + this.Idade);
    }

    
}
