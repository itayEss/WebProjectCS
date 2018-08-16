using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using WebProjectCS.Models;
using WebProjectCS.Models.Managment;

namespace WebProjectCS.Controllers
{
    public class BlogItemsController : Controller
    {

        public IActionResult GetAllLeafs(int? id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                List<BlogItem> list = new List<BlogItem>();

                addAllLeafs((int)id, list);

                return Json(list);
            }
        }

        private void addAllLeafs(int id, List<BlogItem> list)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                
                var blogItems = GetBlogItemLeafList((int)id);
                foreach (var item in blogItems)
                {

                    list.Add(item);
                    addAllLeafs(item.BlogItemID, list);

                }
                
            }
        }

        private List<BlogItem> GetBlogItemLeafList(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var blogList =  db.blogItem
                    .Where(m => m.RelatedID == id).ToList();
                return blogList;
            }
        }

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

        // GET: BlogItems/Create/id
        public IActionResult Create(int? id)
        {
            ViewData["ConvID"] = id;
            return View();
        }

        
        public IActionResult Comment(int? rid, int? cid)
        {
            ViewData["ConvID"] = cid;
            ViewData["RelID"] = rid;
            return View();
        }
        // POST: BlogItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogItemID,ConvID,UID,Subject,Message,RelatedID")] BlogItem blogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (ModelState.IsValid)
                {
                    blogItem.Date = new DateTime();
                    db.Add(blogItem);
                    await db.SaveChangesAsync();
                    string url = @"../../ConvBlogItems/Conversation/" + blogItem.ConvID;
                    return Redirect(url);
                }
                return View(blogItem);
            }
        }

        // GET: BlogItems/Edit/5
        public async Task<IActionResult> Edit(int? id,int? cid)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (id == null)
                {
                    return NotFound();
                }
                ViewData["ConvID"] = cid;

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
        public async Task<IActionResult> Edit(int id, [Bind("BlogItemID,ConvID,Subject,Message")] BlogItem blogItem)
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
                    string url = @"../../ConvBlogItems/Conversation/" + blogItem.ConvID;
                    return Redirect(url);
                }
                ViewData["ConvID"] = blogItem.ConvID;
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

        //DELETE ALL COMMENTS RELATED
        

        // POST: BlogItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var chiledBlogItemList = await db.blogItem.Where(p => p.RelatedID == id).ToListAsync();
                var blogItem = await db.blogItem.FindAsync(id);
                int cid = blogItem.ConvID;
                DeleteLeafs(chiledBlogItemList);
                DeleteBlogItem(blogItem);
                string url = @"../../ConvBlogItems/Conversation/" + cid;
                return Redirect(url);
            }
        }

        private async void DeleteBlogItem(BlogItem blogItem)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (blogItem != null)
                {
                    db.blogItem.Remove(blogItem);
                    await db.SaveChangesAsync();
                }
            }
        }
        private async void DeleteLeafs(List<BlogItem> list)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                while (list.Count != 0)
                {
                    foreach(BlogItem bi in list)
                    {
                        var chiledBlogItemList = await db.blogItem.Where(p => p.RelatedID == bi.BlogItemID).ToListAsync();
                        DeleteBlogItem(bi);
                        DeleteLeafs(chiledBlogItemList);
                    }
                }
            }
        }

        private bool BlogItemExists(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return db.blogItem.Any(e => e.BlogItemID == id);

            }
        }

        private bool RelatedBlogItemExists(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return db.blogItem.Any(e => e.RelatedID == id);

            }
        }

    }
}
