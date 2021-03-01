using System;

namespace Avaruus
{
    public static class Modifiers
    {
        // Muokkaa laskelmia simulaation päivitysnopeuden huomioonottaen
        public static double timerCorrection;
        // Aikakerroin. Jos timeMultiplier on 1, niin simulaatio käy reaaliajassa
        //public static double timeMultiplier = 525600; (1 vuosi on 1 minuutti)
        public static double timeMultiplier = 1000000;
        // Kuinka montaa metriä yksi pikseli vastaa
        public static double metersForPixel = 3000000000;
        // Painovoimavakio
        public static double G = 6.67384 * Math.Pow(10, -11);
    }
}