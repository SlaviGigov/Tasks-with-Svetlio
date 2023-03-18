using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Assets
{
    internal class Grocery : Asset
    {
        public Grocery(int value = 0)
        {
            Value = value;
        }
        public override void Update(int assetValue, int GDPrate)
        {
            switch (GDPrate)
            {
                case -10: Value = assetValue * 1; break;
                case -3: Value = assetValue * 1; break;
                case 0: Value = (int)(assetValue * 0.99); break;
                case +3: Value = (int)(assetValue * 1.01); break;
                case +5: Value = (int)(assetValue * 1.03); break;
                case +10: Value = (int)(assetValue * 1.05); break;
            }
        }
    }
}
