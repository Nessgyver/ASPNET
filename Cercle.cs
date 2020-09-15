using System;

namespace ConsoleApp2
{
    internal class Cercle : Forme
    {
        private int rayon;

        public int Rayon { get => rayon; set => rayon = value; }

        protected override void CalculerPerimetre()
        {
           Perimetre =  2 * Math.PI * Rayon;
        }

        protected override void CalculerAire()
        {
            Aire = Math.PI * (Rayon * Rayon) ;
        }


        public override string ToString()
        {
            string commun = base.ToString();
            return string.Format( " Cercle de rayon {0} \n {1}", Rayon, commun);
        }
    }
}