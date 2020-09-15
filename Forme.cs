namespace ConsoleApp2
{
    public abstract class Forme
    {
        private double aire;
        private double perimetre;

        protected abstract void CalculerAire();
        protected abstract void CalculerPerimetre();

        public double Aire { get => aire; set => aire = value; }
        public double Perimetre { get => perimetre; set => perimetre = value; }

        public override string ToString()
        {
            CalculerPerimetre();
            CalculerAire();
            return string.Format("Aire : {0}, \n Perimetre : {1}\n", Aire, Perimetre);
        }
    }
}