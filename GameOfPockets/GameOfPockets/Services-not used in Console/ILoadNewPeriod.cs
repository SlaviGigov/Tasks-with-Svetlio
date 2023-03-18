using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfPockets.Services
{
    internal interface ILoadNewPeriod
    {
        void LoadNewPeriod(List<Investor> Westeros, GDP newGDP);
    }
}
