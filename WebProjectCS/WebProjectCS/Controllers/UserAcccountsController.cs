using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProjectCS.Models.Managment;
using Microsoft.AspNetCore.Http;


namespace WebProjectCS.Controllers
{
    public class UserAcccountsController : Controller
    {
        //private readonly ApplicationDbContextcs _context;

        //public UserAcccountsController(ApplicationDbContextcs context)
        //{
        //    _context = context;
        //}

        // GET: UserAcccounts
        public async Task<IActionResult> Index()
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return View(await db.userAccount.ToListAsync());
            }
        }

        // GET: UserAcccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var userAcccount = await db.userAccount
                .FirstOrDefaultAsync(m => m.UId == id);
                if (userAcccount == null)
                {
                    return NotFound();
                }

                return View(userAcccount);
            }
        }

        // GET: UserAcccounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserAcccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UId,FirstName,LastName,Email,UserName,Password,ConfirmPassword,UPriv")] UserAcccount userAcccount)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (ModelState.IsValid)
                {
                    db.Add(userAcccount);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(userAcccount);
            }
        }

        // GET: UserAcccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var userAcccount = await db.userAccount.FindAsync(id);
                if (userAcccount == null)
                {
                    return NotFound();
                }
                return View(userAcccount);
            }
        }

        // POST: UserAcccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UId,FirstName,LastName,Email,UserName,Password,ConfirmPassword,UPriv")] UserAcccount userAcccount)
        {
            if (id != userAcccount.UId)
            {
                return NotFound();
            }
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        db.Update(userAcccount);
                        await db.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!UserAcccountExists(userAcccount.UId))
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
                return View(userAcccount);
            }
        }

        // GET: UserAcccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var userAcccount = await db.userAccount
                .FirstOrDefaultAsync(m => m.UId == id);
                if (userAcccount == null)
                {
                    return NotFound();
                }

                return View(userAcccount);
            }
        }

        // POST: UserAcccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                var userAcccount = await db.userAccount.FindAsync(id);
                db.userAccount.Remove(userAcccount);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        private bool UserAcccountExists(int id)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                return db.userAccount.Any(e => e.UId == id);
            }
        }
    }
}
