namespace GameOfPocketsMVC.DataInvestors
{
    using GameOfPocketsMVC.Assets;
    public class Investor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Gold MyGold { get; set; }
        public Crypto MyCrypto { get; set; }
        public Tech MyTech { get; set; }
        public Luxury MyLuxury { get; set; }
        public Grocery MyGrocery { get; set; }
        public int Cash { get; set; }
        public int Wealth { get; set; }

        public Investor(string name)
        {
            this.Name = name;
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
    }
}
