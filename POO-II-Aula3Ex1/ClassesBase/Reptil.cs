using System;

namespace POO_II_Aula3Ex1.ClassesBase
{
    internal class Reptil : Animal
    {

        public bool TemEscamas { get; private set; }
        public bool TemCasco { get; private set; }

        public Reptil(bool temEscamas, bool temCasco, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento)
            : base(nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }
    }
}
