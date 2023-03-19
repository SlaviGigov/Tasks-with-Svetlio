using GameOfPocketsMVC.DataInvestors;
using GameOfPocketsMVC.Models;
using GameOfPocketsMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace GameOfPocketsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInvestorsView investorsView;

        public HomeController(IInvestorsView investorsView)
        {
            this.investorsView = investorsView;
        }

        public IActionResult Index()
        {
            var investors = this.investorsView.GetAll();
            return View(GetInvestors(investors));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private InvestorViewModel GetInvestorViewModel(Investor i)
        {
            return new InvestorViewModel
            {
                Name = i.Name,
                MyGold = i.MyGold,
                MyCrypto = i.MyCrypto,
                MyTech = i.MyTech,
                MyGrocery = i.MyGrocery,
                MyLuxury = i.MyLuxury,
                Cash = i.Cash,
                Wealth = i.Wealth
            };
        }

        private List<InvestorViewModel> GetInvestors(List<Investor> source)
        {
            var investors = new List<InvestorViewModel>();

            foreach (var item in source)
            {
                investors.Add(GetInvestorViewModel(item));
            }

            return investors;
        }
    }
}
