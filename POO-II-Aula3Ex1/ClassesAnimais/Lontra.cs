using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class Lontra : Mamifero, IAquatico
    {
        public Lontra(int qtdeDeMamas, bool pelos, string corDoPelo, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) : base(qtdeDeMamas, pelos, corDoPelo, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergullho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
