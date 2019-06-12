using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers
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

        public IActionResult Contactos()
        {

            Contacto c1 = new Contacto
            {
                Nombre = "Minna",
                Apellidos = "Heinonen",
                Telefono = "658569874",
                Imagen = "https://okdiario.com/img/2017/09/03/todo-lo-que-debes-saber-sobre-los-peces-5-655x368.jpg"
            };

            Contacto c2 = new Contacto
            {
                Nombre = "Deivid",
                Apellidos = "Rodríguez",
                Telefono = "658596222",
                Imagen = "https://i.ytimg.com/vi/zFO-0AlgSDI/maxresdefault.jpg"
            };

            Contacto c3 = new Contacto
            {
                Nombre = "Ama",
                Apellidos = "Ama",
                Telefono = "555666999",
                Imagen = "https://fotos01.farodevigo.es/2016/07/29/646x260/gaviota.jpg"
            };

            Contacto c4 = new Contacto
            {
                Nombre = "Laura",
                Apellidos = "Hernández",
                Telefono = "111222333",
                Imagen = "https://i1.wp.com/www.sopitas.com/wp-content/uploads/2018/10/cerebro-de-ardilla--1110x580.jpg"
            };

            Contacto c5 = new Contacto
            {
                Nombre = "Natalia",
                Apellidos = "Hernández",
                Telefono = "895698789",
                Imagen = "https://www.thelocal.se/userdata/images/article/se/33428.jpg"
            };

            Contacto c6 = new Contacto
            {
                Nombre = "Maitetxu",
                Apellidos = "Etxebarria",
                Telefono = "946008987",
                Imagen = "http://photos1.blogger.com/blogger/5986/3292/1600/foca.jpg"
            };

            List<Contacto> contactos = new List<Contacto>();

            contactos.Add(c1);
            contactos.Add(c2);
            contactos.Add(c3);
            contactos.Add(c4);
            contactos.Add(c5);
            contactos.Add(c6);

            Agenda a1 = new Agenda
            {
                Propietario = "Iciar Etxebarria",
                FechaCreacion = DateTime.Today
                //FechaCreacion = new Datetime(2017,3,12)
                //FechaCreacion = Convert.ToDatetime("12/03/2017")
            };

            AgendaContactoVM misContactos = new AgendaContactoVM

            {
                Agenda = a1,
                ListaContactos = contactos
            };


            return View(misContactos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
