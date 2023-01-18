using POO_II_Aula3Ex1.ClassesAnimais;
using POO_II_Aula3Ex1.ClassesBase;
namespace POO_II_Aula3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leao leao = new Leao(6, true, "Castanho", "Leão", new DateTime(2020, 05, 27), 'm', true, false);

            Console.WriteLine("Animal: " + leao.Nome);
            leao.Amamentar();
            leao.Comunicar();
            leao.Movimentar();
            Console.WriteLine("Idade: " + leao.Idade);

            Console.WriteLine();
            Leao leoa = new Leao(6, true, "Castanho", "Leão", new DateTime(2019, 09, 16), 'f', true, false);

            Console.WriteLine("Animal: " + leoa.Nome);
            leao.Amamentar();
            leao.Comunicar();
            leao.Movimentar();
            Console.WriteLine("Idade: " + leoa.Idade);
        }
    }
}