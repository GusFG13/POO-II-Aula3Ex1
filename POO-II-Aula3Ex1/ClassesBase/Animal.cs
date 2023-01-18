using System;


namespace POO_II_Aula3Ex1.ClassesBase
{
    internal class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }

        public int Idade { get; private set; }
        public bool Carnivoro { get; private set; }
        public bool Peconhento { get; private set; }

        public Animal(string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = CalcularIdade(dataDeNascimento);
            Carnivoro = carnivoro;
            Peconhento = peconhento;
        }

        public void Movimentar() 
        { 
            Console.WriteLine("Movimentando"); 
        }
        public void Comunicar() 
        {
            Console.WriteLine("Comunicando");
        }
        public void Alimentar() 
        {
            Console.WriteLine("Comendo");
        }

        private int CalcularIdade(DateTime dataNascimento) 
        {
            DateTime hoje = DateTime.Now;
            if (hoje.Month >= dataNascimento.Month && hoje.Day >= dataNascimento.Day) 
            {//já fez aniversário esse ano
                return hoje.Year - dataNascimento.Year;
            }
            else
            {
                return (hoje.Year - dataNascimento.Year) - 1;
            }
        }
    }
}
