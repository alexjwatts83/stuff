using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuessThatAnimal.Web.Models;
using GuessThatAnimal.Web.NHibernate;
using NHibernate;
using NHibernate.Linq;
using Attribute = GuessThatAnimal.Web.Models.Attribute;

namespace GuessThatAnimal.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Question q1 = new Question()
            {
                Id = 1,
                Text = "Does the Animal have a Tail?"
            };
            Question q2 = new Question()
            {
                Id = 2,
                Text = "Is the Animal Big?"
            };
            Question q3 = new Question()
            {
                Id = 3,
                Text = "Does the Animal have a Trunk?"
            };
            Question q4 = new Question()
            {
                Id = 4,
                Text = "Does the Animal have a Long Neck?"
            };
            Question q5 = new Question()
            {
                Id = 5,
                Text = "Does the Animal have a Horn?"
            };

            var att1 = new Models.Attribute()
            {
                Id = 1,
                Text = "Has Tail",
                Question = q1
            };
            var att2 = new Models.Attribute()
            {
                Id = 2,
                Text = "Is Big",
                Question = q2
            };
            var att3 = new Models.Attribute()
            {
                Id = 3,
                Text = "Has Trunk",
                Question = q3
            };
            var att4 = new Models.Attribute()
            {
                Id = 4,
                Text = "Has Long Neck",
                Question = q4
            };
            var att5 = new Models.Attribute()
            {
                Id = 5,
                Text = "Has Horn",
                Question = q5
            };

            var elephant = new Animal()
            {
                Id = 1,
                Text = "Elephant",
                Attributes = new List<Models.Attribute>() {att1, att2, att3}
            };

            var giraffe = new Animal()
            {
                Id = 2,
                Text = "Giraffe",
                Attributes = new List<Models.Attribute>() { att1, att2, att4 }
            };

            var rhino = new Animal()
            {
                Id = 3,
                Text = "Rhino",
                Attributes = new List<Models.Attribute>() { att1, att2, att5 }
            };

            var allAnimals = new List<Animal> {elephant, giraffe, rhino};

            var vm = new IndexViewModel()
            {
                AllAnimals = new List<Animal> {elephant, giraffe, rhino}
            };

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StartGame()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}