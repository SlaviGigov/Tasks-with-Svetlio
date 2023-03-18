using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Assets
{
    public abstract class Asset
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public abstract void Update(int assetValue, int GDPrate);


    }
}
