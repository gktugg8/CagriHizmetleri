using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CagriHizmetleri.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CagriHizmetleri.Controllers
{
    
    public class MusteriController : Controller
    {
        Context c = new Context();
       
        public IActionResult Index()
        {
            var listele = c.Musterilers.ToList();
            return View(listele);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Musteriler d)
        {
            c.Musterilers.Add(d);
            c.Musterilers.Add(d);
            c.Musterilers.Add(d);
            c.Musterilers.Add(d);
            c.Musterilers.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var MusteriSil = c.Musterilers.Find(id);
            c.Musterilers.Remove(MusteriSil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriGetir(int id)
        {
            var musteriGetir = c.Musterilers.Find(id);
            return View("MusteriGetir", musteriGetir);
        }
        public IActionResult Guncelle(Musteriler d)
        {
            var g = c.Musterilers.Find(d.ID);
            g.ID = d.ID;
            g.Ad = d.Ad;
            g.Soyad = d.Soyad;
            g.Mail = d.Mail;
            g.Telefon = d.Telefon;
            g.Sorun = d.Sorun;
            c.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
