using Microsoft.AspNetCore.Mvc;

namespace Web_Programming.Controllers
{
    public class Lab1Controller : Controller
    {
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
        public IActionResult FirstViewMethod()
        {
            List<string> fruits = GetItemsList();
            return View(fruits);
        }
        public IActionResult SecondViewMethod()
        {
            return View(GetItemsList().OrderBy(x => x).ToList());
        }
        public IActionResult ThirdViewMethod()
        {
            return View(GetItemsList().OrderBy(x => x).ToList());
        }
        public List<string> GetCustomItemsList()
        {
            List<string> languages = new List<string>();

            languages.Add("C++");
            languages.Add("Python");
            languages.Add("JavaScript");
            languages.Add("Pascal");
            languages.Add("Java");
            languages.Add("Go");

            return languages;
        }

        public IActionResult CustomViewMethod()
        {
            // Получаем отсортированный список по длине строки
            //List<string> languages = GetCustomItemsList();
            return View(GetCustomItemsList().OrderBy(x => x.Length).ToList());
        }
    }
}
