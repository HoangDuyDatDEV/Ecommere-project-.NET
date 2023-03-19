using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ShoppingWeb.Helpper;
using ShoppingWeb.Models;

namespace ShoppingWeb.Areas.admin.Controllers
{
    [Area("admin")]
    public class AdminTinDangsController : Controller
    {
        private readonly dbMarketsContext _context;
       
        public AdminTinDangsController(dbMarketsContext context)
        {
            _context = context;
        
        }

        // GET: admin/AdminTinDangs
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lstindang = _context.TinDangs.AsNoTracking().OrderByDescending(x => x.PostId);
            PagedList<TinDang> models = new PagedList<TinDang>(lstindang, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: admin/AdminTinDangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tinDang == null)
            {
                return NotFound();
            }

            return View(tinDang);
        }

        // GET: admin/AdminTinDangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/AdminTinDangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TinDang tinDang)
        {
            if (ModelState.IsValid)
            {
            
                _context.Add(tinDang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinDang);
        }

        // GET: admin/AdminTinDangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs.FindAsync(id);
            if (tinDang == null)
            {
                return NotFound();
            }
            return View(tinDang);
        }

        // POST: admin/AdminTinDangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TinDang tinDang)
        {
            if (id != tinDang.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinDang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinDangExists(tinDang.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tinDang);
        }

        // GET: admin/AdminTinDangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tinDang == null)
            {
                return NotFound();
            }

            return View(tinDang);
        }

        // POST: admin/AdminTinDangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinDang = await _context.TinDangs.FindAsync(id);
            _context.TinDangs.Remove(tinDang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinDangExists(int id)
        {
            return _context.TinDangs.Any(e => e.PostId == id);
        }
    }
}
