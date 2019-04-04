using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClienteFibonacci.Controllers
{
    public class FibonacciController : Controller
    {
        // GET: Fibonacci
        public ActionResult Index()
        {
            return View();
        }

        // POST: Fibonacci
        [HttpPost]
        public ActionResult Index(int num)
        {
            int[] FibonacciArray;
            ServicioFibonacci.ServicioFibonacciClient client = new ServicioFibonacci.ServicioFibonacciClient("BasicHttpBinding_IServicioFibonacci");
            FibonacciArray = client.GetNumerosFibonacci(num);
            return View(FibonacciArray);
        }
    }
}