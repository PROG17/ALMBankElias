using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALMBank.Controllers
{
    public class WithdrawlDepositController : Controller
    {
        private BankRepository _repo;

        public WithdrawlDepositController(BankRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string amount, string accountName, string action)
        {
            int amount2;
            var succes = int.TryParse(amount, out amount2);

            if (succes == false)
            {
                ViewBag.Result = "Vad e de för summa..? ändra format.. int endast...";
                return View();
            }

            var result = "";
            if (action == "Withdrawl")
            {
               result =  _repo.Withdrawl(amount2, accountName);
            }
            else
            {
               result = _repo.Deposit(amount2, accountName);
            }

            ViewBag.Result = result;
            return View();
        }
    }
}