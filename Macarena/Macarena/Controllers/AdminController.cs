using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MACARENA.Models;
using MACARENA.Migrations;
using System.IO;

namespace MACARENA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        MacarenaDB macarenaContext = new MacarenaDB();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public virtual ICollection<CitiesController> Cities { get; set; }
        public virtual ICollection<HotelsController> Hotels { get; set; }
        public virtual ICollection<RoomsController> Rooms { get; set; }
        public virtual ICollection<RezervationsController> Rezervations { get; set; }
        
        #region // Blog

        public ActionResult Blog()
        {
            using (MacarenaDBContext context = new MacarenaDBContext())
            {
                var blog = context.Blog.ToList();
                return View(blog);
            }
        }
        public ActionResult BlogEkle()
        {
            return View();
        }
        public ActionResult BlogDuzenle(int BlogID)
        {
            using (MacarenaDBContext context = new MacarenaDBContext())
            {
                var _blogDuzenle = context.Blog.Where(x => x.ID == BlogID).FirstOrDefault();
                return View(_blogDuzenle);
            }
        }
        public ActionResult BlogSil(int BlogID)
        {
            try
            {
                using (MacarenaDBContext context = new MacarenaDBContext())
                {
                    context.Blog.Remove(context.Blog.First(d => d.ID == BlogID));
                    context.SaveChanges();
                    return RedirectToAction("Blog", "Admin");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Silerken hata oluştu", ex.InnerException);
            }
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog b, HttpPostedFileBase file)
        {
            try
            {
                using (MacarenaDBContext context = new MacarenaDBContext())
                {
                    Blog _blog = new Blog();
                    if (file != null && file.ContentLength > 0)
                    {
                        MemoryStream memoryStream = file.InputStream as MemoryStream;
                        if (memoryStream == null)
                        {
                            memoryStream = new MemoryStream();
                            file.InputStream.CopyTo(memoryStream);
                        }
                        _blog.BlogFoto = memoryStream.ToArray();
                    }
                    _blog.BlogBaslik = b.BlogBaslik;
                    _blog.BlogIcerik = b.BlogIcerik;
                    _blog.Tarih = DateTime.Now;
                    context.Blog.Add(_blog);
                    context.SaveChanges();
                    return RedirectToAction("Blog", "Admin");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Eklerken hata oluştu");
            }
        }
        [HttpPost]
        public ActionResult BlogDuzenle(Blog b, HttpPostedFileBase file)
        {
            try
            {
                using (MacarenaDBContext context = new MacarenaDBContext())
                {
                    var _blogDuzenle = context.Blog.Where(x => x.ID == b.ID).FirstOrDefault();
                    if (file != null && file.ContentLength > 0)
                    {
                        MemoryStream memoryStream = file.InputStream as MemoryStream;
                        if (memoryStream == null)
                        {
                            memoryStream = new MemoryStream();
                            file.InputStream.CopyTo(memoryStream);
                        }
                        _blogDuzenle.BlogFoto = memoryStream.ToArray();
                    }
                    _blogDuzenle.BlogBaslik = b.BlogBaslik;
                    _blogDuzenle.BlogIcerik = b.BlogIcerik;
                    _blogDuzenle.Tarih = DateTime.Now;
                    context.SaveChanges();
                    return RedirectToAction("Blog", "Admin");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Güncellerken hata oluştu " + ex.Message);
            }

        }

        #endregion
      

    }
}