using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Entprog_Finals_Unwind.Data;
using Entprog_Finals_Unwind.Models;

namespace Entprog_Finals_Unwind.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusicController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Music.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Music record)
        {
            var item = new Music();
            {
                item.MusicName = record.MusicName;
                item.DateAdded = DateTime.Now;
            };

            _context.Music.Add(item);
            _context.SaveChanges();

            return RedirectToAction("index");

        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Music.Where(i => i.MusicId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Music record)
        {
            var Music = _context.Music.Where(i => i.MusicId == id).SingleOrDefault();
            Music.MusicName = record.MusicName;
            Music.DateModified = DateTime.Now;

            _context.Music.Update(Music);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Music.Where(i => i.MusicId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }

            _context.Music.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
