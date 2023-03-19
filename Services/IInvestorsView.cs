namespace GameOfPocketsMVC.Services
{
    using GameOfPocketsMVC.DataInvestors;
    using System.Collections.Generic;
    public interface IInvestorsView
    {
        List<Investor> GetAll();
    }
}
