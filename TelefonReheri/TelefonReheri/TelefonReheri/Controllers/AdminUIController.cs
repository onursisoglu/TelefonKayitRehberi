using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelefonReheri.Controllers
{
    using Models;
    public class AdminUIController : Controller
    {
        TelefonRehberiEntities db = new TelefonRehberiEntities();
        // GET: AdminUI
        public ActionResult Index()
        {
            AdminUI_IndexVM vm = new AdminUI_IndexVM();
            vm.Calisanlar = db.Calisan.ToList();
            vm.Departmanlar = db.Departman.ToList();

            return View(vm);
        }


        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            Calisan yeniCalisan = new Calisan();
            yeniCalisan.AdSoyad = fc["txtAd"];
            yeniCalisan.Telefon = fc["txtTelefon"];
            yeniCalisan.DepartmanID = Convert.ToInt32(fc["Departman"]);
            yeniCalisan.IsManager = Convert.ToBoolean(fc["Statu"]);
            yeniCalisan.IsAdmin = false;
            if (fc["Yoneticisi"] == "Seçiniz")
            {
                yeniCalisan.Yoneticisi = null;
            }
            else
            {
                yeniCalisan.Yoneticisi = Convert.ToInt32(fc["Yoneticisi"]);
            }
            db.Calisan.Add(yeniCalisan);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        public ActionResult Sil(int? KID)
        {
            foreach (Calisan item in db.Calisan.ToList())
            {
                if (item.Yoneticisi == KID)
                {
                    return RedirectToAction("Index");
                }
            }

            db.KullaniciBilgisi.Remove(db.KullaniciBilgisi.FirstOrDefault(x => x.CalisanID == KID));
            db.SaveChanges();

            db.Calisan.Remove(db.Calisan.Find(KID));
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Duzenle(int? id)
        {
           Calisan cls= db.Calisan.Find(id);
            if (cls==null||!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            Admin_DuzenleVM vm = new Admin_DuzenleVM();
            vm.Calisan = cls;
            vm.Departmanlar = db.Departman.ToList();
            vm.Calisanlar = db.Calisan.ToList();
            return View(vm);
        }


        [HttpPost]
        public ActionResult Duzenle(FormCollection fc)
        {
            int id = Convert.ToInt32(fc["hdnID"]);
            Calisan clsn = db.Calisan.Find(id);

            clsn.AdSoyad = fc["txtAd"];
            clsn.Telefon = fc["txtTelefon"];
            clsn.DepartmanID=Convert.ToInt32(fc["Departman"]);
            if (fc["Yoneticisi"] == "Seçiniz")
            {
                clsn.Yoneticisi = null;
            }
            else
            {
                clsn.Yoneticisi = Convert.ToInt32(fc["Yoneticisi"]);
            }
            clsn.IsAdmin = false;
            clsn.IsManager =Convert.ToBoolean(fc["Statu"]);
         
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Ara(string metin)
        {
            List<Calisan>calisanList =db.Calisan.Where(x => x.AdSoyad.Contains(metin)).ToList();

            AdminUI_IndexVM vm = new AdminUI_IndexVM();
            vm.Calisanlar = calisanList;
            vm.Departmanlar = db.Departman.ToList();

            return View("Index",vm);
        }
    }
}