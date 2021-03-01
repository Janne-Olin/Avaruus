using System;
using System.Collections.Generic;
using System.Drawing;

namespace Avaruus
{
    class Simulation
    {
        // Lista johon luodut taivaankappaleet lisätään
        public List<CelBody> Bodies { get; set; }
        public Simulation()
        {
            Bodies = new List<CelBody>();
        }

        public void Gravity()
        {
            foreach (CelBody body in Bodies)
            {
                if (!body.Exists)
                {
                    continue;
                }

                foreach (CelBody body2 in Bodies)
                {
                    if (body2 == body)
                    {
                        continue;
                    }

                    if (!body2.Exists)
                    {
                        continue;
                    }

                    // Kappaleiden etäisyys
                    double distance;
                    // F = voima
                    double F;
                    // X-akseliin kohdistuva voima
                    double Fx = 0;
                    // Y-akseliin kohdistuva voima
                    double Fy = 0;

                    // Kappaleiden sijaintien ero x- ja y-akselilla
                    double xDiff = 0;
                    double yDiff = 0;

                    double velocity;
                   
                    // Lasketaan kappaleiden etäisyys
                    distance = Math.Abs(Math.Pow((body.XPos - body2.XPos), 2)) + Math.Abs(Math.Pow((body.YPos - body2.YPos), 2));
                    distance = Math.Sqrt(distance);
                    distance = distance * Modifiers.metersForPixel;

                    if (body2 is BlackHole)
                    {
                        BlackHole bh = (BlackHole)body2;

                        if (distance <= bh.SchwarzschildR * Modifiers.metersForPixel)
                        {
                            Collision(body, bh);
                            bh.NewSchwarzschildR();
                            break;
                        }
                    }

                    // Lasketaan kappaleiden välillä vaikuttava voima
                    F = Modifiers.G * ((body.Mass * body2.Mass) / Math.Pow(distance, 2));
                    F = F / Modifiers.timerCorrection * Modifiers.timeMultiplier;

                    // Lasketaan kappaleiden x- ja y-akselin erotus
                    xDiff = Math.Abs(body.XPos - body2.XPos);
                    yDiff = Math.Abs(body.YPos - body2.YPos);

                    //Fx = sqrt(F ^ 2 / ([y / x] ^ 2 + 1))
                    // Lasketaan x- ja y-akseleihin vaikuttava voima
                    if (xDiff != 0 && yDiff != 0)
                    {
                        Fx = Math.Sqrt(Math.Pow(F, 2) / (Math.Pow((yDiff / xDiff), 2) + 1));
                        Fy = (yDiff / xDiff) * Fx;
                        //Fy = Math.Sqrt(Math.Pow(F, 2) / (Math.Pow((xDiff / yDiff), 2) + 1));
                    }
                    else if (xDiff == 0)
                    {
                        Fy = F;
                        Fx = 0;
                    }
                    else if (yDiff == 0)
                    {
                        Fy = 0;
                        Fx = F;
                    }

                    if (body.XPos > body2.XPos)
                    {
                        Fx = -Fx;
                    }

                    if (body.YPos > body2.YPos)
                    {
                        Fy = -Fy;
                    }

                    // Lasketaan voiman vaikutus kappaleen liikenopeuteen
                    body.XVel += Fx / body.Mass;
                    body.YVel += Fy / body.Mass;
                    
                    velocity = Math.Sqrt(Math.Abs(Math.Pow(body.XVel, 2)) + Math.Abs(Math.Pow(body.YVel, 2)));

                    if (velocity >= 2.998E+8)
                    {
                        // Ei anneta kappaleen saavuttaa tai ylittää valon nopeutta
                        if (body.XVel != 0 && body.YVel != 0)
                        {
                            body.XVel = Math.Sqrt(Math.Pow(2.998E+8 - 1, 2) / (Math.Pow((yDiff / xDiff), 2) + 1));
                            body.YVel = (yDiff / xDiff) * body.XVel;                            
                        }


                        //body.XVel -= Fx / body.Mass;
                        //body.YVel -= Fy / body.Mass;
                    }
                    
                }

                // Päivitetään kappaleen sijainti
                body.XPos += body.XVel / Modifiers.metersForPixel / Modifiers.timerCorrection * Modifiers.timeMultiplier;
                body.YPos += body.YVel / Modifiers.metersForPixel / Modifiers.timerCorrection * Modifiers.timeMultiplier;
            }
        }

        private void Collision(CelBody smaller, CelBody bigger)
        {
            bigger.XVel = (smaller.Mass * smaller.XVel + bigger.Mass * bigger.XVel) / (smaller.Mass + bigger.Mass);
            bigger.YVel = (smaller.Mass * smaller.YVel + bigger.Mass * bigger.YVel) / (smaller.Mass + bigger.Mass);

            bigger.Mass += smaller.Mass;
            smaller.Exists = false;
        }

        public void CreateNewBody(string name, double mass, int d, int xPos, int yPos, double xVel, double yVel, Color c)
        {
            Bodies.Add(new CelBody(name, mass, d, xPos, yPos, xVel, yVel, c));
        }

        public void CreateNewBH(string name, double mass, int xPos, int yPos, double xVel, double yVel)
        {
            Bodies.Add(new BlackHole(name, mass, xPos, yPos, xVel, yVel));
        }

        public void Remove()
        {
            for (int i = Bodies.Count - 1; i >= 0; i--)
            {
                if (!Bodies[i].Exists)
                {
                    Bodies.RemoveAt(i);
                }
            }
        }

        public void CreateSolarSystem(double xP, double yP, double xV, double yV)
        {
            // Luodaan taivaankappaleet
            Bodies.Add(new CelBody("Sun", 1.9891 * Math.Pow(10, 30), 24, xP, yP, xV, yV, Color.Yellow));
            Bodies.Add(new CelBody("Mercury", 3.3011 * Math.Pow(10, 23), 6, xP - 20, yP, xV, yV + 48000, Color.DarkSlateGray));
            Bodies.Add(new CelBody("Venus", 4.8675 * Math.Pow(10, 24), 8, xP - 36, yP, xV, yV + 35000, Color.SandyBrown));
            Bodies.Add(new CelBody("Earth", 5.9737 * Math.Pow(10, 24), 8, xP - 50, yP, xV, yV + 29780, Color.Blue));
            Bodies.Add(new CelBody("Mars", 6.4171 * Math.Pow(10, 23), 6, xP - 75, yP, xV, yV + 24000, Color.Red));
            Bodies.Add(new CelBody("Jupiter", 1.8982 * Math.Pow(10, 27), 16, xP - 260, yP, xV, yV + 13000, Color.Brown));
            Bodies.Add(new CelBody("Saturn", 5.6834 * Math.Pow(10, 26), 14, xP - 450, yP, xV, yV + 9680, Color.SandyBrown));
            Bodies.Add(new CelBody("Uranus", 8.6810 * Math.Pow(10, 25), 12, xP - 950, yP, xV, yV + 6800, Color.LightSkyBlue));
            Bodies.Add(new CelBody("Neptune", 1.02413 * Math.Pow(10, 26), 12, xP - 1500, yP, xV, yV + 5430, Color.DeepSkyBlue));

            //Bodies.Add(new CelBody("Sun2", 1.9891 * Math.Pow(10, 30), 24, 6000, 4200, -20000, 0, Color.Yellow));
            //Bodies.Add(new CelBody("Moon", 7.342 * Math.Pow(10, 22), 6, 3950, 3998, 300, 29780, Color.Pink));
        }


    }
}
