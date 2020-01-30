using DiplomLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiplomLast.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            List<QuizResult> a = new List<QuizResult>();
            using (DiplomDB db=new DiplomDB())
            {
                a = db.QuizResults.ToList();
        //        user  = (List<TestViewModel>)(db.Testers.Join(db.QuizResults, // второй набор
        //p => p.id, // свойство-селектор объекта из первого набора
        //c => c.testerID, // свойство-селектор объекта из второго набора
        //(p, c) => new // результат
        //{
        //    Name = p.name,
        //    Familya = p.familiya,
        //    Fname = p.fatherName,
        //    IIN = p.iin,
        //    maxPoints=c.maxPoint,
        //    userPoints = c.userPoint,
        //    userTimes = c.userTime,
        //    maxTimes = c.maxTime,
        //    nameTest = c.name
        //}));
            }
          //  ViewBag.items = user;
            return View(a);
        }
    }
}