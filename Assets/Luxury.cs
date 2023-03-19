using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPocketsMVC.Assets
{
    public class Luxury : Asset
    {
        public Luxury(int value = 0)
        {
            Value = value;
        }
        public override void Update(int assetValue, int GDPrate)
        {
            switch (GDPrate)
            {
                case -10: Value = (int)(assetValue * 0.8); break;
                case -3: Value = (int)(assetValue * 0.9); break;
                case 0: Value = (int)(assetValue * 0.98); break;
                case +3: Value = assetValue * 1; break;
                case +5: Value = (int)(assetValue * 1.05); break;
                case +10: Value = (int)(assetValue * 1.2); break;
            }
        }
    }
}
