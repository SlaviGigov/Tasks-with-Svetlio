
namespace GameOfPockets
{
    using GameOfPockets.Assets;
    public class Investor
    {
        public string Name { get; set; }
        internal Gold MyGold;
        internal Crypto MyCrypto;
        internal Tech MyTech;
        internal Luxury MyLuxury;
        internal Grocery MyGrocery;
        internal int Cash;
        internal int Wealth;

        public Investor(string name, int cash = 0)
        {
            this.Name = name;
            this.Cash = cash;
            this.MyGold = new Gold();
            this.MyCrypto = new Crypto();
            this.MyTech = new Tech();
            this.MyLuxury = new Luxury();
            this.MyGrocery = new Grocery();
        }

        public int MyWealth()
        {
            Wealth = Cash + MyGold.Value + MyCrypto.Value + MyTech.Value + MyLuxury.Value + MyGrocery.Value;
            return Wealth;
        }


        //Implement action Sell - Read Asset + Read ammount, check amount, decrease the asset.Value, increase Cash
        //Implement Buy - Read Asset + Read amount, check amount in cash, decrease cash, increase asset.Value




    }
}
