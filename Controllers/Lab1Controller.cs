using Microsoft.AspNetCore.Mvc;

namespace Web_Programming.Controllers
{

    public class Lab1Controller : Controller
    {
        public IActionResult FirstViewMethod()
        {
            List<string> fruits = GetItemsList();
            return View(fruits);
        }
        public IActionResult SecondViewMethod()
        {
            return View(GetItemsList().OrderBy(x => x).ToList());
        }

        public List<string> GetItemsList()
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Peach");
            fruits.Add("Pear");
            fruits.Add("Pineapple");

            return fruits;
        }
    }
}
