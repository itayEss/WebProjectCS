﻿using System;
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
    public class ConvBlogItemsController : Controller
    {


        // GET: ConvBlogItems
        public async Task<IActionResult> Conversation(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var blogItem = db.blogItem
                    .Where(b => b.RelatedID == id);
                return View(await blogItem.ToListAsync());
            }
        }

        // GET: ConvBlogItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var convBlogItem = await db.ConvBlogItem
                    .FirstOrDefaultAsync(m => m.ConvBlogItemID == id);
                if (convBlogItem == null)
                {
                    return NotFound();
                }

                return View(convBlogItem);
            }
        }

        // GET: ConvBlogItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConvBlogItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConvBlogItemID,ConvName,ConvCreatorName")] ConvBlogItem convBlogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (ModelState.IsValid)
                {
                    db.Add(convBlogItem);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Blog", "App");
                }
                return View(convBlogItem);
            }
        }

        // GET: ConvBlogItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var convBlogItem = await db.ConvBlogItem.FindAsync(id);
                if (convBlogItem == null)
                {
                    return NotFound();
                }
                return View(convBlogItem);
            }
        }

        // POST: ConvBlogItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConvBlogItemID,ConvName,ConvCreatorName")] ConvBlogItem convBlogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id != convBlogItem.ConvBlogItemID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        db.Update(convBlogItem);
                        await db.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ConvBlogItemExists(convBlogItem.ConvBlogItemID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Blog", "App");

                }
                return View(convBlogItem);
            }
        }

        // GET: ConvBlogItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var convBlogItem = await db.ConvBlogItem
                    .FirstOrDefaultAsync(m => m.ConvBlogItemID == id);
                if (convBlogItem == null)
                {
                    return NotFound();
                }

                return View(convBlogItem);
            }
        }

        // POST: ConvBlogItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var convBlogItem = await db.ConvBlogItem.FindAsync(id);
                db.ConvBlogItem.Remove(convBlogItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Blog", "App");
            }
        }
        private bool ConvBlogItemExists(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return db.ConvBlogItem.Any(e => e.ConvBlogItemID == id);
            }
        }
    }
}