using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class Jacare : Reptil, IOviparo, IAquatico
    {
        public Jacare(bool temEscamas, bool temCasco, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) 
            : base(temEscamas, temCasco, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergullho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }
    }
}
