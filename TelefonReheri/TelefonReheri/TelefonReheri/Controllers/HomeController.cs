using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelefonReheri.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            TelefonRehberiEntities db = new TelefonRehberiEntities();
            string KAdi = fc["txtKullaniciAdi"];
            string sifre = fc["txtSifre"];

            KullaniciBilgisi kullanici = db.KullaniciBilgisi.FirstOrDefault(x => x.KullaniciAdi == KAdi && x.Sifre == sifre);

            if (kullanici == null)
            {
                Session["uyari"] = "Hatali Giriş";
                return View();
            }
            else
            {
                if (kullanici.Calisan.IsAdmin)
                {
                   return RedirectToAction("Index", "AdminUI");
                }
                else
                {
                  return  RedirectToAction("Index", "PublicUI");
                }
            }

        }
    }
}