using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiplomLast.Models;
using System.ComponentModel.DataAnnotations;
using ARSoft.Tools.Net.Dns;

namespace DiplomLast.Controllers
{
    public class TestersController : Controller
    {
        private DiplomDB db = new DiplomDB();

        // GET: Testers
        public async Task<ActionResult> Index()
        {
            var testers = db.Testers.Include(t => t.Adress).Include(t => t.obrazovanye).Include(t => t.semeynoePolojenie).Include(t => t.university).Include(t => t.Vakansya);
            return View(await testers.ToListAsync());
        }

        // GET: Testers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = await db.Testers.FindAsync(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            return View(tester);
        }

        // GET: Testers/Create
        public ActionResult Create()
        {
            ViewBag.adressID = new SelectList(db.Adresses, "id", "name");
            ViewBag.obrazavanyeID = new SelectList(db.obrazovanyes, "id", "name");
            ViewBag.semeynoePolojenyeID = new SelectList(db.semeynoePolojenies, "id", "name");
            ViewBag.universityID = new SelectList(db.universities, "id", "name");
            var slist = new SelectList(db.Countries, "id", "name");
            var a = slist.ToList();
            ViewBag.country = a;
            ViewBag.zhelaemayaVakansya = new SelectList(db.Vakansyas, "id", "name");
            return View();
        }

        // POST: Testers/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,iin,familiya,name,fatherName,spretsialist,birthDate,phoneNumber,email,pol,opitRboty,adressID,semeynoePolojenyeID,obrazavanyeID,universityID,zhelaemayaVakansya,resultQuizID,gorod")] Tester tester,int gorod,string adress)
        {
            Tester tester1 =  db.Testers.FirstOrDefault(p=>p.email==tester.email);
            Tester tester2 = db.Testers.FirstOrDefault(p => p.iin == tester.iin);
            int a = 1;
            if (tester1 != null) { ModelState.AddModelError("email", "Существует пользватель с таким email-ом"); a = 2; }
            if (tester1 != null) { ModelState.AddModelError("iin", "Существует пользватель с таким iin-ом"); a = 2; }
            if (a == 2) {
                ViewBag.adressID = new SelectList(db.Adresses, "id", "name");
                ViewBag.obrazavanyeID = new SelectList(db.obrazovanyes, "id", "name");
                ViewBag.semeynoePolojenyeID = new SelectList(db.semeynoePolojenies, "id", "name");
                ViewBag.universityID = new SelectList(db.universities, "id", "name");
                //var slist = new SelectList(db.Countries, "id", "name");
                //var a = slist.ToList();
                ViewBag.country = new SelectList(db.Countries, "id", "name").ToList();
                ViewBag.zhelaemayaVakansya = new SelectList(db.Vakansyas, "id", "name");
                return View();
            } 
            if (ModelState.IsValid)
            {                
                tester.Adress = new Adress();
                tester.Adress.name = adress;
                tester.Adress.idOBlast = gorod;
                db.Testers.Add(tester);
             
                try
                {
                    await db.SaveChangesAsync();
                    HttpCookie cookie = new HttpCookie("iin", tester.iin);
                    HttpCookie cookies = new HttpCookie("email",tester.email);                   
                    Response.SetCookie(cookies);
                    Response.SetCookie(cookie);


                }
                catch (Exception EX)
                {
                    Request.Cookies.Clear();
                    return HttpNotFound();
                    throw EX;
                }
               
                return RedirectToAction("Details",new {id=tester.id});
            }

            ViewBag.adressID = new SelectList(db.Adresses, "id", "name", tester.adressID);
            ViewBag.obrazavanyeID = new SelectList(db.obrazovanyes, "id", "name", tester.obrazavanyeID);
            ViewBag.semeynoePolojenyeID = new SelectList(db.semeynoePolojenies, "id", "name", tester.semeynoePolojenyeID);
            ViewBag.universityID = new SelectList(db.universities, "id", "name");
            ViewBag.universityID = new SelectList(db.universities, "id", "name", tester.universityID);
            ViewBag.zhelaemayaVakansya = new SelectList(db.Vakansyas, "id", "name", tester.zhelaemayaVakansya);
            return View(tester);
        }

        // GET: Testers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = await db.Testers.FindAsync(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            ViewBag.adressID = new SelectList(db.Adresses, "id", "name", tester.adressID);
            ViewBag.obrazavanyeID = new SelectList(db.obrazovanyes, "id", "name", tester.obrazavanyeID);
            ViewBag.semeynoePolojenyeID = new SelectList(db.semeynoePolojenies, "id", "name", tester.semeynoePolojenyeID);
            ViewBag.universityID = new SelectList(db.universities, "id", "name", tester.universityID);
            ViewBag.zhelaemayaVakansya = new SelectList(db.Vakansyas, "id", "name", tester.zhelaemayaVakansya);
            ViewBag.universityID = new SelectList(db.universities, "id", "name");
            ViewBag.country = new SelectList(db.Countries, "id", "name").ToList();
            return View(tester);
        }

        // POST: Testers/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,iin,familiya,name,fatherName,spretsialist,birthDate,phoneNumber,email,pol,opitRboty,adressID,semeynoePolojenyeID,obrazavanyeID,universityID,zhelaemayaVakansya,resultQuizID")] Tester tester, int gorod)
        {
            if (ModelState.IsValid)
            {
                tester.Adress.idOBlast = gorod;
                db.Entry(tester).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Details", new { id = tester.id });
            }
            ViewBag.adressID = new SelectList(db.Adresses, "id", "name", tester.adressID);
            ViewBag.obrazavanyeID = new SelectList(db.obrazovanyes, "id", "name", tester.obrazavanyeID);
            ViewBag.semeynoePolojenyeID = new SelectList(db.semeynoePolojenies, "id", "name", tester.semeynoePolojenyeID);
            ViewBag.country = new SelectList(db.Countries, "id", "name"/*, tester.country*/);
            ViewBag.universityID = new SelectList(db.universities, "id", "name", tester.universityID);
            ViewBag.zhelaemayaVakansya = new SelectList(db.Vakansyas, "id", "name", tester.zhelaemayaVakansya);
            ViewBag.country = new SelectList(db.Countries, "id", "name").ToList();
            return View(tester);
        }

        // GET: Testers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = await db.Testers.FindAsync(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            return View(tester);
        }

        // POST: Testers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Tester tester = await db.Testers.FindAsync(id);
            db.Testers.Remove(tester);
            await db.SaveChangesAsync();
            return RedirectToAction("TestView", "Home", new { email = tester.email });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    
        public ActionResult EmailVerify(string email)
        {
            var resolver = new DnsStubResolver();
            var records = resolver.Resolve<MxRecord>("gmail.com", RecordType.Mx);
            foreach (var record in records)
            {
                Console.WriteLine(record.ExchangeDomainName?.ToString());
            }
            var addr = new System.Net.Mail.MailAddress(email);
            return Json((new EmailAddressAttribute().IsValid(email)).ToString());
         
        }




        //HELPER
        //private void AddErrors(DiplomDB result)
        //{
        //    foreach (var error in result.Errors)
        //    {
        //        ModelState.AddModelError("", error);
        //    }
        //}

    }
}
