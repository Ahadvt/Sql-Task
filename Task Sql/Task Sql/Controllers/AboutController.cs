using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Sql.Models;

namespace Task_Sql.Controllers
{
    public class AboutController:Controller
    {

        public ActionResult About()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    ID=1,
                    Img="1.jpg",
                    Order=1
                },
                   new Slider
                {
                    ID=2,
                    Img="2.jpg",
                    Order=2
                },
                      new Slider
                {
                    ID=3,
                    Img="3.jpg",
                    Order=3
                }
            };
            return View(sliders);
        }
    }
}
