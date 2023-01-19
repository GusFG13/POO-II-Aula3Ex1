using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class Elefante : Mamifero
    {
        public Elefante(int qtdeDeMamas, bool pelos, string corDoPelo, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) 
            : base(qtdeDeMamas, pelos, corDoPelo, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }
    }
}
