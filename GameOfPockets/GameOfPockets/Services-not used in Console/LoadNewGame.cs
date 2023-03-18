using System;
using System.Collections.Generic;
using System.Text;
using GameOfPockets.Services;

namespace GameOfPockets.Services
{
    public class LoadNewGame : ILoadNewGame
    {
        public List<Investor> Westeros { get; set; }
        public GDP currentGDP { get; set; }

        void ILoadNewGame.LoadNewGame()
        {
            currentGDP = new GDP();

            var MyAccount = new Investor("MyAccount", 5000);
            Westeros.Add(MyAccount);

            var Stark = new Investor("Stark");
            Stark.MyGold.Value = 1000;
            Stark.MyCrypto.Value = 100;
            Stark.MyTech.Value = 1000;
            Stark.MyLuxury.Value = 900;
            Stark.MyGrocery.Value = 2000;
            Westeros.Add(Stark);

            var Lannister = new Investor("Lannister");
            Lannister.MyGold.Value = 2000;
            Lannister.MyCrypto.Value = 500;
            Lannister.MyTech.Value = 300;
            Lannister.MyLuxury.Value = 2000;
            Lannister.MyGrocery.Value = 200;
            Westeros.Add(Lannister);

            var Targaryen = new Investor("Targaryen");
            Targaryen.MyGold.Value = 200;
            Targaryen.MyCrypto.Value = 1000;
            Targaryen.MyTech.Value = 3000;
            Targaryen.MyLuxury.Value = 500;
            Targaryen.MyGrocery.Value = 300;
            Westeros.Add(Targaryen);

            var KingsLanding = new Investor("KingsLanding");
            KingsLanding.MyGold.Value = 2000;
            KingsLanding.MyCrypto.Value = 500;
            KingsLanding.MyTech.Value = 500;
            KingsLanding.MyLuxury.Value = 1000;
            KingsLanding.MyGrocery.Value = 1000;
            Westeros.Add(KingsLanding);

            var NightWatch = new Investor("NightWatch");
            NightWatch.MyGold.Value = 1000;
            NightWatch.MyCrypto.Value = 1000;
            NightWatch.MyTech.Value = 1000;
            NightWatch.MyLuxury.Value = 1000;
            NightWatch.MyGrocery.Value = 1000;
            Westeros.Add(NightWatch);

            foreach (var item in Westeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
