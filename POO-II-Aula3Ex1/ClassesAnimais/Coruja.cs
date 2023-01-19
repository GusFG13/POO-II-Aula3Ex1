using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class Coruja : Ave, IOviparo, IVoar
    {
        public Coruja(bool rapina, bool corPena, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) 
            : base(rapina, corPena, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            throw new NotImplementedException();
        }

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
