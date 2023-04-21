using System.Xml.Linq;

public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) {
    }

    public override string EmitirSom()
    {
        return "shiissiisisisiss";
    }
}

public class Cobra : Reptil
{
    double Comprimento { get; set; }
    public Cobra(string nome, int idade, double Comprimento_) : base(nome, idade)
    {
        Comprimento = Comprimento_;
    }

    public override string EmitirSom()
    {
        return "shiissiisisisiss";
    }
}