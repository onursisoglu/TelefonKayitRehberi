using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelefonReheri.Controllers
{
    using Models;
    public class PublicUIController : Controller
    {
        TelefonRehberiEntities db = new TelefonRehberiEntities();


        // GET: PublicUI
        public ActionResult Index()
        {
            AdminUI_IndexVM vm = new AdminUI_IndexVM();
           vm.Calisanlar= db.Calisan.ToList();
            vm.Departmanlar = db.Departman.ToList();
            return View(vm);
        }
    }
}