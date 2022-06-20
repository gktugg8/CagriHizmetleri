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
    public class CagriController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var listele = c.CagriOperatorleris.Include(x=>x.musteri).ToList();
            return View(listele);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(CagriOperatorleri d)
        {
            c.CagriOperatorleris.Add(d);
            c.CagriOperatorleris.Add(d);
            c.CagriOperatorleris.Add(d);
            c.CagriOperatorleris.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var CalisanSil = c.CagriOperatorleris.Find(id);
            c.CagriOperatorleris.Remove(CalisanSil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MusteriSec()
        {
            List<SelectListItem> degerler = (from x in c.Musterilers.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Ad,
                                                Value = x.ID.ToString()
                                            }).ToList();

            ViewBag.dgr = degerler;
            return View();
        }
        public IActionResult MusteriSec(CagriOperatorleri d)
        {
            var per = c.Musterilers.Where(x => x.ID == d.musteri.ID).FirstOrDefault();
            d.musteri = per;
            c.CagriOperatorleris.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CalisanGetir(int id)
        {
            var calisanGetir = c.CagriOperatorleris.Find(id);
            return View("CalisanGetir", calisanGetir);
        }
        public IActionResult Guncelle(CagriOperatorleri d)
        {
            var g = c.CagriOperatorleris.Find(d.ID);
            g.ID = d.ID;
            g.Ad = d.Ad;
            g.Soyad = d.Soyad;
           
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult MusteriYok()
        {
            var listele = c.CagriOperatorleris.ToList();
            return View(listele);
        }



    }
}
