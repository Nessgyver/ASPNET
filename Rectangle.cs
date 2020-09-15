namespace ConsoleApp2
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        protected override void CalculerAire()
        {
            Aire = Largeur * Longueur;
        }

        protected override void CalculerPerimetre()
        {
            Perimetre = (Largeur + Longueur) * 2;
        }

        public override string ToString()
        {
            string commun = base.ToString();
            return string.Format(" Rectangle de longueur {0} et de largeur {1} \n {2}", Longueur, Largeur, commun);
        }
    }
}