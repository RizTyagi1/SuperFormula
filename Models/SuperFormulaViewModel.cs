namespace WebApplication2.Models
{
    public class SuperFormulaModel
    {
        // Horizontal / around the object

        public double M1 { get; set; }

        public double N1A { get; set; }

        public double N2A { get; set; }

        public double N3A { get; set; }


        // Vertical / top to bottom

        public double M2 { get; set; }

        public double N1B { get; set; }

        public double N2B { get; set; }

        public double N3B { get; set; }


        // Display

        public double Scale { get; set; }

        public double ParticleSize { get; set; }
    }
}