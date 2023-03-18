using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Services
{
    public class Visualize
    {
        public void Print(List<Investor> Westeros, GDP currentGDP)
        {
            Console.WriteLine($"Current GDP rate: {currentGDP.GDPrate}");
            Console.WriteLine($"Current GDP outlook: {currentGDP.Outlook}");
            
            foreach (var item in Westeros)
            {
                Console.WriteLine($"{0} has wealth of {1}", item.Name, item.Wealth);
            }
        }
    }
}
