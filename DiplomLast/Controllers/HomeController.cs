using DiplomLast.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DiplomLast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FirstPageAutorize(string ss)
        {
            ViewBag.role = ss;
            return View();
        }




        public ActionResult Index()
        {
            //HttpCookie cookies = new HttpCookie("iin", "970319300858");
            //Response.SetCookie(cookies);
            //Session["iin"] = "970319300858";
            //try
            //{
            //    HttpCookie cookies = new HttpCookie("iin", "email");
            //    Response.SetCookie(cookies);
            //    DiplomDB db = new DiplomDB();
            //    var tester = new Tester();
            //    db.Testers.Add(tester);
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Session.Clear();
            //    var cookie = Request.Cookies["iin"];
            //    var a = cookie.Value;

            //    Request.Cookies.Clear();


            //    throw ex;
            //}



            // List<string> roles = new List<string> { "Роль не определена" };
            // ApplicationUserManager userManager = HttpContext.GetOwinContext()
            //                                         .GetUserManager<ApplicationUserManager>();
            // ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            // if (user != null)
            //     roles = userManager.GetRoles(user.Id).ToList();
            //int a= roles.BinarySearch("Роль не определена");
            //      a = roles.BinarySearch("admin");
            // User.Identity.GetUserRole();

            return View();
            // return View();
        }
        //  [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            var cookie = Request.Cookies["iin"];
            ViewBag.Message = "Your application description page.";
            //   return RedirectToAction(Url.Action("TestView", "Home", new { iin = "122222222222" },null));
            //return RedirectToAction("TestView", "Home", new { iin = "122222222222" });
            return View();
        }



        //tester wich not tested
        public ActionResult getTesterNotQuiz(string iin)
        {
            if (iin == null)
            {
                using (DiplomDB db = new DiplomDB())
                {
                    var testers = (from u in db.Testers.ToList() where u.resultQuizID == null select u).ToList();
                    if (testers != null)
                        return View(testers);
                    else return View("Списк пуст");
                }
            }
            else
            {
                using (DiplomDB db = new DiplomDB())
                {
                    List<Tester> list = new List<Tester>();
                    list.Add(db.Testers.FirstOrDefault(p => p.iin == iin));
                    ViewBag.iin = "true";
                    return View(list);
                }

            }

        }
        public ActionResult AddQuizresult(string iin, decimal point, string name)
        {
            try
            {
                using (DiplomDB db = new DiplomDB())
                {
                    var tester = db.Testers.FirstOrDefault(p => p.iin == iin);
                    QuizResult qr = new QuizResult();
                    var id = db.QuizResults.Max(quizrez => quizrez.id);
                    qr.id = id + 1;
                    qr.maxPoint = 100;
                    qr.userPoint = point;
                    qr.name = name;
                    qr.testerDate = DateTime.Today;
                    qr.testerID = tester.id;
                    db.QuizResults.Add(qr);
                    db.SaveChanges();

                }
                ViewBag.mes = "1";
            }
            catch (Exception ex)
            {
                ViewBag.mes = "0";
                throw ex;
            }

            return View();
        }
        public ActionResult TestView(string email)
        {
            //string email = "bola@mail.ru";
            ViewBag.email = email;
            return View();
        }

        //list Tester with quiz
        public ActionResult TestersQuiz()

        {
            return View(getTestersQuizList());
        }

        [HttpGet]
        //one tester with quiz
        public ActionResult getTesterQuiz(string iin)
        {
            // string iin = "122222222222";
            return View(getOneTesterView(iin));
        }
        [HttpGet]

        //send quizresult to meil
        public ActionResult SendTestresultMail()
        {
            var cookie = Request.Cookies["iin"];
            IdentityMessage message = new IdentityMessage();
            QuizResultXmlObject.quizReport retObj = new QuizResultXmlObject.quizReport();
            using (DiplomDB db = new DiplomDB())
            {
                int a = 2;
                Tester tester = db.Testers.FirstOrDefault(p => p.iin == cookie.Value);
                message.Destination = tester.email;
                var quizresult = db.QuizResults.FirstOrDefault(p => p.testerID == a);
                Serialaizble serial = new Serialaizble();
                retObj = serial.DeSerialize<QuizResultXmlObject.quizReport>(quizresult.testXml);
                message.Subject = "Ваш тест по" + quizresult.name;
            }
            message.Body = ViewToString("ShowTestResultUser", retObj);
            message.Subject = "vssssssssssssssssssssss";
            //  message.Destination = "bolatbek_19.03.97@mail.ru";


            EmailService es = new EmailService();
            es.SendMail(message);
            Session.Clear();
            return Redirect("Index");
         //   return View();
        }

        //mesege to rabotnik
        public ActionResult sendMessege(string email, string msg, string sub)
        {
            IdentityMessage message = new IdentityMessage();
            message.Subject = sub; message.Destination = email; message.Body = msg;
            EmailService es = new EmailService();
            es.SendMail(message);
            return View();
        }
        [HttpGet]
        public ActionResult ShowTestResultUser2(int id)
        {
            //  var cookie = Request.Cookies["iin"];

            QuizResultXmlObject.quizReport retObj = new QuizResultXmlObject.quizReport();
            using (DiplomDB db = new DiplomDB())
            {
                var quizresult = db.QuizResults.FirstOrDefault(p => p.id == id);
                Serialaizble serial = new Serialaizble();
                retObj = serial.DeSerialize<QuizResultXmlObject.quizReport>(quizresult.testXml);
            }

            return View(retObj);
        }










        //tester
        public ActionResult ShowTestResultUser()
        {
            var cookie = Request.Cookies["iin"];

            QuizResultXmlObject.quizReport retObj = new QuizResultXmlObject.quizReport();
            using (DiplomDB db = new DiplomDB())
            {
                Tester tester = db.Testers.FirstOrDefault(p => p.iin == cookie.Value);
                var quizresult = db.QuizResults.Last(p => p.testerID == tester.id);
                Serialaizble serial = new Serialaizble();
                retObj = serial.DeSerialize<QuizResultXmlObject.quizReport>(quizresult.testXml);
            }

            return View(retObj);
        }
        [HttpGet]
        public ActionResult EmailVerify(string email)
        {

            return Json(new EmailAddressAttribute().IsValid(email));

        }
        [ValidateInput(false)]
        public ActionResult QuizResult(ModelIspring a)
        {

            //HttpWebResponse responce = (HttpWebResponse)request.GetResponse();

            //using (StreamReader stream = new StreamReader(
            //        responce.GetResponseStream(), Encoding.UTF8))
            //{
            //    s = stream.ReadToEnd();
            //}

            //string browser = HttpContext.Request.Browser.Browser;
            //string user_agent = HttpContext.Request.UserAgent;
            //string url = HttpContext.Request.RawUrl;
            //string ip = HttpContext.Request.UserHostAddress;
            //string sadasdid = HttpContext.Request.Cookies["iin"].Value;

            QuizResult res = new QuizResult();

            res.name = a.qt;

            res.testXml = a.dr;
            res.userPoint = Convert.ToDecimal(a.sp);
            Serialaizble serial = new Serialaizble();
            QuizResultXmlObject.quizReport serialObject = serial.DeSerialize<QuizResultXmlObject.quizReport>(a.dr);
            res.userTime = (serialObject.summary.time).ToString();
            res.maxTime = serialObject.quizSettings.timeLimit.ToString();
            res.maxPoint = Convert.ToDecimal(serialObject.quizSettings.maxScore);

            using (DiplomDB db = new DiplomDB())
            {
                var cookie = Request.Cookies["iin"];
                Tester tester = db.Testers.FirstOrDefault(p => p.iin == "970319300858");
                tester.resultQuizID = 1;
                //var aqq = (from u in db.Testers.ToList() where u.email == a.COMPANY select u.id).FirstOrDefault();
                res.testerID = tester.id;
                //var iddd = (from u in db.Testers.ToList() where u.email == a.COMPANY select u.id).FirstOrDefault();
                var id = db.QuizResults.Max(quizrez => quizrez.id);
                res.id = id + 1;
                res.testerDate = DateTime.Today;
                db.QuizResults.Add(res);
                db.SaveChanges();
                int iddd = res.id;
                //HttpCookie cookie_quiz = new HttpCookie("QuizResultId", iddd.ToString());
                //Response.SetCookie(cookie_quiz);
            }
            //  Response.Redirect(Url.Action("TestResultView", "Home", new { quiz = serialObject, email = a.COMPANY }));
            //return RedirectToAction("TestResultView", "Home", new { quiz = serialObject, email = a.COMPANY });

            return Json("bake");
        }



















        //helper methods
        private string ViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        OneTesterView getOneTesterView(string iin)
        {
            using (DiplomDB db = new DiplomDB())
            {
                Tester oneTester = db.Testers.FirstOrDefault(p => p.iin == iin);
                OneTesterView oneTesterView = new OneTesterView();
                oneTesterView.iin = oneTester.iin;
                oneTesterView.fio = oneTester.familiya + oneTester.name + oneTester.fatherName;
                oneTesterView.email = oneTester.email;
                oneTesterView.birthDate = oneTester.birthDate;
                oneTesterView.phoneNumber = "+7" + oneTester.phoneNumber;
                oneTesterView.obrazavanyeID = oneTester.obrazovanye.name;
                if (oneTester.pol == true) oneTesterView.pol = "муж"; else oneTesterView.pol = "жен";
                oneTesterView.universityID = oneTester.university.name;
                oneTesterView.spretsialist = oneTester.spretsialist;
                oneTesterView.opitRboty = oneTester.opitRboty;
                oneTesterView.adressID = oneTester.Adress.name + (db.Gorods.First(p => p.id == oneTester.Adress.idOBlast)).name +
                    (db.Gorods.First(p => p.id == oneTester.Adress.idOBlast)).Oblast.name + (db.Gorods.First(p => p.id == oneTester.Adress.idOBlast)).Oblast.Country.name;

                if (oneTester.birthDate != null)
                {
                    DateTime day = (DateTime)oneTester.birthDate;
                    DateTime nowDate = DateTime.Today;
                    int age = nowDate.Year - day.Year;
                    if (day > nowDate.AddYears(-age)) age--;
                    oneTesterView.age = age;
                }
                ////
                oneTesterView.quizResults = (from u in db.QuizResults.ToList()
                                             where u.testerID == oneTester.id
                                             select u).ToList();
                foreach (QuizResult item in oneTesterView.quizResults)
                {
                    item.testXml = null;
                }

                return oneTesterView;
            }
        }

        List<TestViewModel> getTestersQuizList()
        {
            List<TestViewModel> testerQuiz = new List<TestViewModel>();
            using (DiplomDB db = new DiplomDB())
            {
                var list = (db.Testers.Join(db.QuizResults, // второй набор
          p => p.id, // свойство-селектор объекта из первого набора
          c => c.testerID, // свойство-селектор объекта из второго набора
          (p, c) => new // результат
          {
              Name = p.name,
              Familya = p.familiya,
              Fname = p.fatherName,
              IIN = p.iin,
              maxPoints = c.maxPoint,
              userPoints = c.userPoint,
              userTimes = c.userTime,
              maxTimes = c.maxTime,
              nameTest = c.name,
              date = c.testerDate
          }));

                var a = db.Countries.ToList();

                foreach (var p in list)
                {
                    TestViewModel tesjnhbjnt = new TestViewModel();
                    tesjnhbjnt.Familya = p.Familya;
                    tesjnhbjnt.Name = p.Name;
                    tesjnhbjnt.Fname = p.Fname;
                    tesjnhbjnt.IIN = p.IIN;
                    tesjnhbjnt.maxPoints = p.maxPoints;
                    tesjnhbjnt.maxTimes = p.maxTimes;
                    tesjnhbjnt.nameTest = p.nameTest;
                    tesjnhbjnt.userPoints = p.userPoints;
                    tesjnhbjnt.userTimes = p.userTimes;
                    tesjnhbjnt.date = p.date;
                    testerQuiz.Add(tesjnhbjnt);
                }

                return testerQuiz;
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TesterGet([Bind(Include = "id,iin,familiya,name,fatherName,spretsialist,birthDate,phoneNumber,email,pol,opitRboty,adressID,semeynoePolojenyeID,obrazavanyeID,universityID,zhelaemayaVakansya,resultQuizID")]Tester model, int gorod)
        {
            if (!IsValidEmail(model.email))
                return Json("Email неверный");


            model.Adress.idOBlast = gorod;
            using (DiplomDB db = new DiplomDB())
            {
                db.Testers.Add(model);
                db.SaveChanges();
                ViewBag.messege = model.email;
            }
            return Redirect(Url.Action("TestView"));
        }

        public ActionResult TesterGet()
        {
            var cookie = Request.Cookies["iin"];
            DiplomDB db = new DiplomDB();
            ViewBag.semeynoePolojenie = db.semeynoePolojenies.ToList();
            // var p = db.university.ToList();
            ViewBag.university = db.universities.ToList();
            // var c= db.obrazovanye.ToList();
            ViewBag.obrazavanye = db.obrazovanyes.ToList();
            //   var aa= db.Country.ToList();
            //  var bb = db.Region.ToList();
            // var hh = db.Region.FirstOrDefault();
            List<TesterViewModels> l = new List<TesterViewModels>();
            foreach (var item in db.Countries.ToList())
            {
                TesterViewModels v = new TesterViewModels();
                v.id = item.id;
                v.name = item.name;
                l.Add(v);
            }
            ViewBag.country = l;
            //  List<Vakansya> v= db.Vakansya.ToList();

            ViewBag.vakansya = db.Vakansyas.ToList();
            //   var ppp = db.Vakansya.FirstOrDefault();

            var countryList = from coun in db.Countries select coun;

            return View();
        }
        //helper method
        [HttpGet]
        public ActionResult GetDropdawn(string name, int id = 1)
        {
            //  var cookie = Request.Cookies["iin"];
            DiplomDB db = new DiplomDB();
            List<TesterViewModels> l = new List<TesterViewModels>();
            if (name == "country")
            {
                var sortedList = from u in db.Oblasts.ToList()
                                 where u.idCountry == id
                                 select u;

                foreach (var item in sortedList)
                {
                    TesterViewModels v = new TesterViewModels();
                    v.id = item.id;
                    v.name = item.name;
                    l.Add(v);
                }
                ViewBag.mess = "Oblast";
                ViewBag.listoblast = l;
            }
            else if (name == "oblast")
            {
                var gorod = from u in db.Gorods.ToList()
                            where u.idOBlast == id
                            select u;
                //var region = from u in db.Regions.ToList()
                //             where u.idOBlast == id
                //             select u;
                foreach (var item in gorod)
                {
                    TesterViewModels v = new TesterViewModels();
                    v.id = item.id;
                    v.name = item.name;
                    l.Add(v);
                }
                //List<TesterViewModels> ll = new List<TesterViewModels>();
                //foreach (var item in gorod)
                //{
                //    TesterViewModels v = new TesterViewModels();
                //    v.id = item.id;
                //    v.name = item.name;
                //    ll.Add(v);
                //}
                ViewBag.listgorod = l;
                //ViewBag.listregion = ll;
                //ViewBag.mess1 = "Gorod";
                //ViewBag.mess = "Gorod";
            }

            return PartialView();
        }
     

    }

}


