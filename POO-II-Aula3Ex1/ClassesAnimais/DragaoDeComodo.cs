using POO_II_Aula3Ex1.ClassesBase;

namespace POO_II_Aula3Ex1.ClassesAnimais
{
    internal class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(bool temEscamas, bool temCasco, string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento) 
            : base(temEscamas, temCasco, nome, dataDeNascimento, sexo, carnivoro, peconhento)
        {
        }

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
