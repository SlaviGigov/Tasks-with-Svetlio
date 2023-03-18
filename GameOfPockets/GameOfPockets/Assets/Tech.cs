using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Assets
{
    internal class Tech : Asset
    {
        public Tech(int value = 0)
        {
            Value = value;
        }
        public override void Update(int assetValue, int GDPrate)
        {
            switch (GDPrate)
            {
                case -10: Value = (int)(assetValue * 0.95); break;
                case -3: Value = (int)(assetValue * 0.99); break;
                case 0: Value = (int)(assetValue * 1.06); break;
                case +3: Value = (int)(assetValue * 1.09); break;
                case +5: Value = (int)(assetValue * 1.1); break;
                case +10: Value = (int)(assetValue * 1.15); break;
            }
        }
    }
}
