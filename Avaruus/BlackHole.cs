using System;
using System.Drawing;

namespace Avaruus
{
    class BlackHole : CelBody
    {
        public double SchwarzschildR { get; set; }
        public BlackHole(string name, double m, double xp, double yp, double xv, double yv):base(name, m, xp, yp, xv, yv)
        {
            D = 0;
            Color = Color.White;
            SchwarzschildR = 2 * Modifiers.G * Mass / Math.Pow(299792458, 2) / Modifiers.metersForPixel;
        }

        public void NewSchwarzschildR()
        {
            SchwarzschildR = 2 * Modifiers.G * Mass / Math.Pow(299792458, 2) / Modifiers.metersForPixel;
        }
    }
}
