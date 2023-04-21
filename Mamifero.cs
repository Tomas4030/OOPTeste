public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "ai calica miau";
    }
}

public class Le�o : Reptil
{
    double TamanhoDoGrupo { get; set; }
    public Le�o(string nome, int idade, int TamanhoDoGrupo_) : base(nome, idade)
    {
        TamanhoDoGrupo = TamanhoDoGrupo_;
    }

    public override string EmitirSom()
    {
        return "ai calica miau";
    }
}