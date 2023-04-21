using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();

    }
    public void AdicionarAnimal(Animal animal)
    {
        _animais.Add(animal);
    }

    public static void EmitirSomDeTodosOsAnimais()
    {
        Animal[] superheroes = new Animal[2];

        Reptil a = new Reptil("joana", 23);
        Mamifero b = new Mamifero("Comedor_de_casadas", 100);

    
        a.EmitirSom();

        b.EmitirSom();
    }
}