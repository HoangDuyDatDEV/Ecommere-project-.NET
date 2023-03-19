using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
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
    public class AdminProductsController : Controller
    {
        private readonly dbMarketsContext _context;
        public INotyfService _notifyService { get; }
        public AdminProductsController(dbMarketsContext context,INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        // GET: admin/AdminProducts
        public IActionResult Index(int page = 1, int CatID = 0)
        {
            var pageNumber = page;
            var pageSize = 20;
            List<Product> lsProducts = new List<Product>();
            if (CatID != 0)
            {
                lsProducts = _context.Products.AsNoTracking().Where(x => x.CatId == CatID).Include(x => x.Cat).OrderByDescending(x => x.ProductId).ToList();
            }
            else
            {
                lsProducts = _context.Products.AsNoTracking().Include(x => x.Cat).OrderByDescending(x => x.ProductId).ToList();
            }

            PagedList<Product> models = new PagedList<Product>(lsProducts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentCatID = CatID;
            ViewBag.CurrentPage = pageNumber;
            ViewData["Danhmuc"] = new SelectList(_context.Categories, "CatId", "CatName", CatID);
            return View(models);
        }
        public IActionResult Filter(int CatID = 0)
        {
            var url = $"/Admin/AdminProducts?CatID={CatID}";
            if (CatID == 0)
            {
                url = $"/Admin/AdminProducts";
            }
            return Json(new { status = "success", redirectUrl = url });

        }
        // GET: admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: admin/AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["Danhmuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: admin/AdminProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSellers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitsInStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                product.ProductName = Utilities.ToTitleCase(product.ProductName);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + extension;
                    product.Thumb = await Utilities.UploadFile(fThumb, @"products", image.ToLower());

                }
                if (string.IsNullOrEmpty(product.Thumb))
                    product.Thumb = "defalt.jpg";
                    product.Alias = Utilities.SEOUrl(product.ProductName);
                    product.DateModified = DateTime.Now;
                    product.DateCreated = DateTime.Now;

              
                _context.Add(product);
                await _context.SaveChangesAsync();
                _notifyService.Success("Tạo mới thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["Danhmuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // GET: admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {   
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Danhmuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // POST: admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSellers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitsInStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    product.ProductName = Utilities.ToTitleCase(product.ProductName);
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Thumb = await Utilities.UploadFile(fThumb, @"products", image.ToLower());

                    }
                    if (string.IsNullOrEmpty(product.Thumb))
                        product.Thumb = "defalt.jpg";
                    product.Alias = Utilities.SEOUrl(product.ProductName);
                    product.DateModified = DateTime.Now;
                   

                    _context.Update(product);                    
                    await _context.SaveChangesAsync();
                    _notifyService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["Danhmuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }


        // GET: admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: admin/AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa sản phẩm thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
