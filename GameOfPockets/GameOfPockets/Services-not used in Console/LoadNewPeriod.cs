using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Services
{
    internal class LoadNewPeriod : GDP, ILoadNewPeriod
    {
        void ILoadNewPeriod.LoadNewPeriod(List<Investor> Westeros, GDP newGDP)
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
            Console.WriteLine($"The wealth of {name.Name} is {name.MyWealth()}");

        }
    }
}
