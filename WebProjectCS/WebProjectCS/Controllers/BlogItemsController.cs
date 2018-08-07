using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProjectCS.Models;
using WebProjectCS.Models.Managment;

namespace WebProjectCS.Controllers
{
    public class BlogItemsController : Controller
    {
        

        // GET: BlogItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var blogItem = await db.blogItem
                    .FirstOrDefaultAsync(m => m.BlogItemID == id);
                if (blogItem == null)
                {
                    return NotFound();
                }

                return View(blogItem);
            }
        }

        // GET: BlogItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogItemID,Date,ConvID,UID,Subject,Message,RelatedID")] BlogItem blogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (ModelState.IsValid)
                {
                    db.Add(blogItem);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Conversation", "ConvBlogItems",blogItem.ConvID);
                }
                return View(blogItem);
            }
        }

        // GET: BlogItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var blogItem = await db.blogItem.FindAsync(id);
                if (blogItem == null)
                {
                    return NotFound();
                }
                return View(blogItem);
            }
        }

        // POST: BlogItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogItemID,Date,ConvID,UID,Subject,Message,RelatedID")] BlogItem blogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id != blogItem.BlogItemID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        db.Update(blogItem);
                        await db.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!BlogItemExists(blogItem.BlogItemID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Conversation", "ConvBlogItems", blogItem.ConvID);
                }
                return View(blogItem);
            }
        }

        // GET: BlogItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var blogItem = await db.blogItem
                    .FirstOrDefaultAsync(m => m.BlogItemID == id);
                if (blogItem == null)
                {
                    return NotFound();
                }

                return View(blogItem);
            }
        }

        // POST: BlogItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var blogItem = await db.blogItem.FindAsync(id);
                db.blogItem.Remove(blogItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Conversation", "ConvBlogItems", blogItem.ConvID);
            }
        }

        private bool BlogItemExists(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return db.blogItem.Any(e => e.BlogItemID == id);

            }
        }
    }
}
