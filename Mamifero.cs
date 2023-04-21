public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "ai calica miau";
    }
}

public class Leão : Reptil
{
    double TamanhoDoGrupo { get; set; }
    public Leão(string nome, int idade, int TamanhoDoGrupo_) : base(nome, idade)
    {
        TamanhoDoGrupo = TamanhoDoGrupo_;
    }

    public override string EmitirSom()
    {
        return "ai calica miau";
    }
}