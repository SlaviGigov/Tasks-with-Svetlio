using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPocketsMVC.Assets
{
    public abstract class Asset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public abstract void Update(int assetValue, int GDPrate);


    }
}
