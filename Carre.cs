namespace ConsoleApp2
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        protected override void CalculerAire()
        {
            Aire = Longueur * Longueur;
        }

        protected override void CalculerPerimetre()
        {
            Perimetre = Longueur * 4;
        }

        public override string ToString()
        {
            string commun = base.ToString();
            return string.Format(" Carré de côté {0} \n {1}", Longueur, commun);
        }
    }
}