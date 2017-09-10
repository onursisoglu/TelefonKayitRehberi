using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelefonReheri.Models
{
    public class Admin_DuzenleVM
    {
        public Calisan Calisan { get; set; }
        public List<Departman> Departmanlar { get; set; }
        public List<Calisan> Calisanlar { get; set; }
    }
}