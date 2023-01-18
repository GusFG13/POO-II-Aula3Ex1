using System;

namespace POO_II_Aula3Ex1.ClassesBase
{
    internal class Mamifero : Animal
    {
        public int QtdeDeMamas { get; private set; }
        public bool Pelos { get; private set; }

        private string _corDoPelo;
        public string CorDoPelo
        {
            get
            {
                return _corDoPelo;
            }
            private set
            {
                if (Pelos)
                {
                    _corDoPelo = value;
                }
                else
                {
                    _corDoPelo = "Não possui pelos";
                }
            }
        }

        public Mamifero(int qtdeDeMamas, bool pelos, string corDoPelo, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) 
            : base(nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
            QtdeDeMamas = qtdeDeMamas;
            Pelos = pelos;
            CorDoPelo = corDoPelo;
        }

        public void Amamentar()
        {
            if (Sexo == 'f')
                Console.WriteLine("Amamentando");
            else
                Console.WriteLine("Animal é macho");
        }
    }
}
