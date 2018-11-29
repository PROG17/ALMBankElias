using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALMBank.Controllers
{
    public class TransferController : Controller
    {
        private BankRepository _repo;

        public TransferController(BankRepository repo)
        {
            _repo = repo;
            //kommentar 2.0
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string amount, string fromAccountName, string toAccountName)
        {
            if (fromAccountName == null || toAccountName == null || amount == null)
            {
                ViewBag.Result = "Fyll i alla fält!"; //Ändrar för buildtest

                return View();
            }


            int amount2;
            var succes = int.TryParse(amount, out amount2);

            if (succes == false)
            {
                ViewBag.Result = "Vad e de för summa..? ändra format.. int endast...";
                return View();
            }

            var result = _repo.Transfer(amount2, fromAccountName, toAccountName);
            ViewBag.Result = result;

            return View();
        }
    }
}