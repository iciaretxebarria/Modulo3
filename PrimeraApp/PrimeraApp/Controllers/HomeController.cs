using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeraApp.Models;

namespace PrimeraApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["edad"] = 30;

            //List<string> compras = new List<string>();
            //compras.Add("pizza");
            //compras.Add("cecina");
            //compras.Add("lechuga");

            //ViewData["compras"] = compras;

            List<Animal> animales = new List<Animal>();

            Animal a1 = new Animal

            {
                Especie = "Cannis Lupus",
                Genero = "Cannis",
                Familia = "Cánido",
                Imagen = "~/imagenes/Canis_lupus_265b.jpg"
            };

            Animal a2 = new Animal

            {
                Especie = "Hamster",
                Genero = "Phodopus",
                Familia = "Cricétido",
                Imagen = "http://hamster.org.es/img-hamster.org.es/hamster-sirio.jpg?w=1400"
            };

            Animal a3 = new Animal

            {
                Especie = "Conejo",
                Genero = "Lepórido",
                Familia = "Mamífero lagomorfo",
                Imagen = "https://pm1.narvii.com/6799/8c45316637f71933f0629b43bd52141f936fea81v2_128.jpg"
            };

            Animal a4 = new Animal

            {
                Especie = "Quokka",
                Genero = "Setonix",
                Familia = "Macropodidae",
                Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLGIH1EduYrBacm6De_Flcp3rR1hGj4wyUzw_-XhF1ch6Cil_icg"
            };


            animales.Add(a1);
            animales.Add(a2);
            animales.Add(a3);
            animales.Add(a4);

            return View(animales);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

    }
}
