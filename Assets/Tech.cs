using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPocketsMVC.Assets
{
    public class Tech : Asset
    {
        public Tech(int value = 0)
        {
            Value = value;
        }
        public override void Update(int assetValue, int GDPrate)
        {
            switch (GDPrate)
            {
                case -10: Value = (int)(assetValue * 0.9); break;
                case -3: Value = (int)(assetValue * 0.95); break;
                case 0: Value = (int)(assetValue * 1.01); break;
                case +3: Value = (int)(assetValue * 1.03); break;
                case +5: Value = (int)(assetValue * 1.05); break;
                case +10: Value = (int)(assetValue * 1.1); break;
            }
        }
    }
}
