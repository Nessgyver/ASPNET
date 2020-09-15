namespace ConsoleApp2
{

    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        protected override void CalculerAire()
        {
            double p = Perimetre / 2;
            Aire = System.Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        protected override void CalculerPerimetre()
        {
            Perimetre = A + B + C;
        }

        public override string ToString()
        {
            string commun = base.ToString();
            return string.Format(" Triangle de coté A={0}, B={1}, C={2} \n {3}", A, B, C, commun);
        }
    }
}