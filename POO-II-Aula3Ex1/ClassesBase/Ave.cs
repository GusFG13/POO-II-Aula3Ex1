using System;

namespace POO_II_Aula3Ex1.ClassesBase
{
    internal class Ave : Animal
    {
        public bool Rapina { get; private set; }
        public bool CorPena { get; private set; }

        public Ave(bool rapina, bool corPena, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento)
            : base(nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
            Rapina = rapina;
            CorPena = corPena;
        }

        public void Ciscar() 
        {
            Console.WriteLine("Ciscando");
        }
    }
}
