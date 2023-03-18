using System;
using System.Collections.Generic;

namespace GameOfPockets
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("***GAME of POCKETS - WIN MAX WEALTH***");
            Console.WriteLine("New Game is loaded. Increase your wealth by investing in Gold / Crypto / Tech / Luxury / Grocery. The return of the assets depends on the economics (GDP rate).");
            var Westeros = LoadNewGame();
            var currentGDP = new GDP();
            Print(Westeros, currentGDP);

            var command = EnterNewCommand();

            while (command != "End")
            {
                if (command == "Play")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        LoadNewPeriod(Westeros, currentGDP);
                        Print(Westeros, currentGDP);
                    }
                    command = EnterNewCommand();
                }

                else if (command == "Edit")
                {
                    BuyOrSell(Westeros[0]);
                    command = EnterNewCommand();
                }
                else
                {
                    Console.Write("Wrong command! Please write again: ");
                    command = Console.ReadLine();
                }
            }


            List<Investor> LoadNewGame()
            {
                List<Investor> Westeros = new List<Investor>();
                Console.Write("Enter your name: ");
                var MyAccount = new Investor(Console.ReadLine(), 5000);
                BuyOrSell(MyAccount);
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

                return Westeros;

            }

            void Print(List<Investor> Westeros, GDP currentGDP)
            {

                Console.WriteLine();
                Console.WriteLine($"Current GDP rate: {currentGDP.GDPrate} %");
                Console.WriteLine($"Current GDP outlook: {currentGDP.Outlook}");
                
                foreach (var item in Westeros)
                {
                    Console.WriteLine($"{item.Name} has wealth of {item.Wealth}");
                }
                Console.WriteLine();
            }


            void LoadNewPeriod(List<Investor> Westeros, GDP newGDP)
            {
                foreach (var item in Westeros)
                {
                    UpdatePockets(item, newGDP.GDPrate);
                }

                newGDP.Update(newGDP.GDPrate, newGDP.Outlook);
            }

            //UpDate the investors portfolios
            static void UpdatePockets(Investor name, int GDPrate)
            {
                name.MyGold.Update(name.MyGold.Value, GDPrate);
                name.MyCrypto.Update(name.MyCrypto.Value, GDPrate);
                name.MyTech.Update(name.MyTech.Value, GDPrate);
                name.MyLuxury.Update(name.MyLuxury.Value, GDPrate);
                name.MyGrocery.Update(name.MyGrocery.Value, GDPrate);
                name.MyWealth();
            }

            void BuyOrSell(Investor MyAccount)
            {
                Console.Write($"Buy/Sell Gold, you have available {MyAccount.Cash} cash, current GOLD {MyAccount.MyGold.Value} and the NEW amount is: ");
                var temp = MyAccount.MyGold.Value;
                MyAccount.MyGold.Value = int.Parse(Console.ReadLine());
                MyAccount.Cash -= MyAccount.MyGold.Value - temp;

                Console.Write($"Buy/Sell Crypto, you have available {MyAccount.Cash} cash, current Crypto {MyAccount.MyCrypto.Value} and the NEW amount is: ");
                temp = MyAccount.MyCrypto.Value;
                MyAccount.MyCrypto.Value = int.Parse(Console.ReadLine());
                MyAccount.Cash -= MyAccount.MyCrypto.Value - temp;

                Console.Write($"Buy/Sell Tech, you have available {MyAccount.Cash} cash, current Tech {MyAccount.MyTech.Value} and the NEW amount is: ");
                temp = MyAccount.MyTech.Value;
                MyAccount.MyTech.Value = int.Parse(Console.ReadLine());
                MyAccount.Cash -= MyAccount.MyTech.Value - temp;

                Console.Write($"Buy/Sell Luxury, you have available {MyAccount.Cash} cash, current Luxury {MyAccount.MyLuxury.Value} and the NEW amount is: ");
                temp = MyAccount.MyLuxury.Value;
                MyAccount.MyLuxury.Value = int.Parse(Console.ReadLine());
                MyAccount.Cash -= MyAccount.MyLuxury.Value - temp;

                Console.Write($"Buy/Sell Grocery, you have available {MyAccount.Cash} cash, current Grocery {MyAccount.MyGrocery.Value} and the NEW amount is: ");
                temp = MyAccount.MyGrocery.Value;
                MyAccount.MyGrocery.Value = int.Parse(Console.ReadLine());
                MyAccount.Cash -= MyAccount.MyGrocery.Value - temp;
            }

            string EnterNewCommand()
            {
                Console.Write($"Enter a command \n -> 'Play' for loading new year of 4 Quater periods; \n -> 'Edit' for Buy/Sell your assets; \n -> 'End' to finish the game; \n: ");
                return Console.ReadLine();
            }
        }
    }
}
