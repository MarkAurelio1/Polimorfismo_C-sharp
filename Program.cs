using System;

namespace Polimorfismo
{
    internal class Program
    {
        class Animal
        {
            public virtual void FazerSom()
            {
                Console.WriteLine("Animal fazendo som...");
            }
        }

        class Cachorro : Animal
        {
            public override void FazerSom()
            {
                Console.WriteLine("Au Au!");
            }
        }

        class Gato : Animal
        {
            public override void FazerSom()
            {
                Console.WriteLine("Miau!");
            }
        }

        //Polimorfismo é um conceito fundamental da programação orientada
        //a objetos que permite que um objeto possa se comportar de diferentes
        //maneiras em diferentes contextos. Em outras palavras, o polimorfismo permite que um objeto
        //de uma classe possa ser tratado como se fosse um objeto de outra classe.

        //Em C#, o polimorfismo é implementado usando a sobrescrita "override"
        //de métodos e a ligação tardia (ou late binding),
        //também conhecida como polimorfismo de tempo de execução.
        //Por exemplo, suponha que tenhamos uma classe base chamada "Animal"
        //e duas classes derivadas chamadas "Cachorro" e "Gato".
        //A classe "Animal" possui um método chamado "FazerSom".
        //Para implementar o polimorfismo, podemos sobrescrever o método
        //"FazerSom" nas classes "Cachorro" e "Gato" para que elas
        //façam um som específico daquele animal.

        Animal animal1 = new Cachorro();
        animal1.FazerSom(); //Saída: "Au Au!"

        Animal animal2 = new Gato();
        animal2.FazerSom(); //Saída: "Miau!"

    }
}