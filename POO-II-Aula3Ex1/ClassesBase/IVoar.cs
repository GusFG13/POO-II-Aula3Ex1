namespace POO_II_Aula3Ex1.ClassesBase
{
    internal interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public void Voar();
        public void Chocar();
    }
}
