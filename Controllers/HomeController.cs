using Kutuphane_Projesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane_Projesi.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Kitaps.ToList();
            return View(degerler);
        }
        
        [HttpGet]
        public IActionResult YeniKitap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKitap(Kitap k)
        {
            c.Kitaps.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KitapGetir(int id)
        {
            var kitap = c.Kitaps.Find(id);
            return View("KitapGetir", kitap);
        }

        public IActionResult Guncelle(Kitap k)
        {
            var ktp = c.Kitaps.Find(k.KitapID);
            ktp.KitapAd = k.KitapAd;
            ktp.Yazar = k.Yazar;
            ktp.Tur = k.Tur;
            ktp.BaskiYili = k.BaskiYili;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public IActionResult Sil(int id)
        {
            var degerler = c.Kitaps.Find(id);
            c.Kitaps.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");
           
        }
    }
}
