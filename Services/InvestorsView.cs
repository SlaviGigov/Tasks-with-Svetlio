using GameOfPocketsMVC.DataAccess;
using GameOfPocketsMVC.DataInvestors;
using System.Collections.Generic;
using System.Linq;

namespace GameOfPocketsMVC.Services
{
    public class InvestorsView : IInvestorsView
    {
        private readonly AppDbContext db;

        public InvestorsView(AppDbContext db)
        {
            this.db = db;
        }

        public List<Investor> GetAll()
        {
            return this.db.Investors.ToList();
        }
    }
}
