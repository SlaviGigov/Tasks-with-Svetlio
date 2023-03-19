namespace GameOfPocketsMVC.Models
{
    using GameOfPocketsMVC.Assets;
    public class InvestorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gold MyGold { get; set; }
        public Crypto MyCrypto { get; set; }
        public Tech MyTech { get; set; }
        public Luxury MyLuxury { get; set; }
        public Grocery MyGrocery { get; set; }
        public int Cash { get; set; }
        public int Wealth { get; set; }
    }
}
