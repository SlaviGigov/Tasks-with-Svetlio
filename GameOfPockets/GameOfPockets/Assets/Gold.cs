using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Assets
{
    public class Gold : Asset
    {
        public Gold(int value = 0)
        {
            Value = value;
        }
        public override void Update(int assetValue, int GDPrate)
        {
            switch (GDPrate)
            {
                case -10: Value = (int)(assetValue * 1.15); break;
                case -3: Value = (int)(assetValue * 1.1); break;
                case 0: Value = assetValue; break;
                case +3: Value = (int)(assetValue * 1.05); break;
                case +5: Value = (int)(assetValue * 0.99); break;
                case +10: Value = (int)(assetValue * 0.95); break;
            }
        }
    }
}
