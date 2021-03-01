using System.Drawing;

namespace Avaruus
{
    class CelBody
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        // Halkaisija pikseleinä
        public int D { get; set; }
        public double XPos { get; set; }
        public double YPos { get; set; }
        public double XVel { get; set; }
        public double YVel { get; set; }
        public Color Color { get; set; }
        public bool Exists { get; set; } = true;

        public CelBody(string name, double m, int d, double xp, double yp, double xv, double yv, Color c)
        {
            Name = name;
            Mass = m;
            D = d;
            XPos = xp;
            YPos = yp;
            XVel = xv;
            YVel = yv;
            Color = c;
        }

        public CelBody(string name, double m, double xp, double yp, double xv, double yv)
        {
            Name = name;
            Mass = m;
            XPos = xp;
            YPos = yp;
            XVel = xv;
            YVel = yv;
        }
    }
}
