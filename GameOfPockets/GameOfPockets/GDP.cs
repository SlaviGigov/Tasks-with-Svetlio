using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets
{
    public class GDP
    {
        public int GDPrate { get; set; }
        public string Outlook { get; set; }

        public GDP(int currentGDP = 0, string currentOutlook = "neutral")
        {
            this.GDPrate = currentGDP;
            this.Outlook = currentOutlook;
        }

        public void Update(int currentGDP, string currentOutlook)
        {
            
            var rnd = new Random();
            var chance = rnd.Next(0, 100);


            if (currentOutlook == "neutral")
            {
                currentGDP = NewGDPifNeutral(chance, currentGDP);
                if (chance <= 60) currentOutlook = "neutral";
                else if (chance <= 80) currentOutlook = "positive";
                else currentOutlook = "negative";
            }
            else if (currentOutlook == "positive")
            {
                currentGDP = NewGDPifPositive(chance, currentGDP);
                if (chance <= 50) currentOutlook = "positive";
                else if (chance <= 90) currentOutlook = "neutral";
                else currentOutlook = "negative";
            }
            else if (currentOutlook == "negative")
            {
                currentGDP = NewGDPifNegative(chance, currentGDP);
                if (chance <= 50) currentOutlook = "negative";
                else if (chance <= 90) currentOutlook = "neutral";
                else currentOutlook = "positive";
            }

            this.GDPrate = currentGDP;
            this.Outlook = currentOutlook;
        }

        private int NewGDPifNeutral(int chance, int now)
        {
            switch (now)
            {
                case 0:
                    if (chance <= 5) return -10;
                    else if (chance <= 20) return -3;
                    else if (chance <= 80) return 0;
                    else if (chance <= 95) return 3;
                    else return 5;

                case +3:
                    if (chance <= 5) return -3;
                    else if (chance <= 20) return 0;
                    else if (chance <= 80) return 3;
                    else if (chance <= 95) return 5;
                    else return 10;

                case 5:
                    if (chance <= 5) return -3;
                    else if (chance <= 15) return 0;
                    else if (chance <= 30) return 3;
                    else if (chance <= 80) return 5;
                    else return 10;

                case 10:
                    if (chance <= 5) return 0;
                    else if (chance <= 25) return 3;
                    else if (chance <= 85) return 5;
                    else return 10;

                case -3:
                    if (chance <= 20) return -10;
                    else if (chance <= 80) return -3;
                    else if (chance <= 95) return 0;
                    else return 3;

                case -10:
                    if (chance <= 50) return -10;
                    else if (chance <= 90) return -3;
                    else return 0;
            }
            return now;

        }

        private int NewGDPifPositive(int chance, int now)
        {
            switch (now)
            {
                case 0:
                    if (chance <= 15) return -3;
                    else if (chance <= 40) return 0;
                    else if (chance <= 80) return 3;
                    else if (chance <= 95) return 5;
                    else return 10;

                case +3:
                    if (chance <= 15) return 0;
                    else if (chance <= 40) return 3;
                    else if (chance <= 80) return 5;
                    else return 10;

                case 5:
                    if (chance <= 5) return 0;
                    else if (chance <= 20) return 3;
                    else if (chance <= 60) return 5;
                    else return 10;

                case 10:
                    if (chance <= 5) return 3;
                    else if (chance <= 20) return 5;
                    else return 10;

                case -3:
                    if (chance <= 10) return -10;
                    else if (chance <= 40) return -3;
                    else if (chance <= 75) return 0;
                    else if (chance <= 95) return 3;
                    else return 5;

                case -10:
                    if (chance <= 30) return -10;
                    else if (chance <= 70) return -3;
                    else if (chance <= 90) return 0;
                    else return +3;
            }
            return now;
        }
        internal int NewGDPifNegative(int chance, int now)
        {
            switch (now)
            {
                case 0:
                    if (chance <= 20) return -10;
                    else if (chance <= 60) return -3;
                    else if (chance <= 85) return 0;
                    else return 5;

                case +3:
                    if (chance <= 5) return -10;
                    else if (chance <= 20) return -5;
                    else if (chance <= 60) return 0;
                    else if (chance <= 85) return 3;
                    else return 5;

                case 5:
                    if (chance <= 10) return -3;
                    else if (chance <= 30) return 0;
                    else if (chance <= 60) return 3;
                    else if (chance <= 90) return 5;
                    else return 10;

                case 10:
                    if (chance <= 10) return -3;
                    else if (chance <= 30) return 0;
                    else if (chance <= 60) return 3;
                    else if (chance <= 90) return 5;
                    else return 10;

                case -3:
                    if (chance <= 60) return -10;
                    else if (chance <= 90) return -3;
                    else return 0;

                case -10:
                    if (chance <= 70) return -10;
                    else return -3;
            }
            return now;
        }
    }
}


