using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class Morcego : Mamifero, IVoar
    {
        public Morcego(int qtdeDeMamas, bool pelos, string corDoPelo, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) : base(qtdeDeMamas, pelos, corDoPelo, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
