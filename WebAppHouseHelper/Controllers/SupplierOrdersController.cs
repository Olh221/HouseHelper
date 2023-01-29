using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using House.Data;
using House.Domain.Entities;

namespace WebAppHouseHelper.Controllers
{
    public class SupplierOrdersController : Controller
    {
        private readonly AppDBContext _context;

        public SupplierOrdersController(AppDBContext context)
        {
            _context = context;
        }

        // GET: SupplierOrders
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.SupplierOrder.Include(s => s.Feedback).Include(s => s.Order).Include(s => s.Service).Include(s => s.Status);
            return View(await appDBContext.ToListAsync());
        }

        // GET: SupplierOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Feedback)
                .Include(s => s.Order)
                .Include(s => s.Service)
                .Include(s => s.Status)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }
        public async Task<IEnumerable<SupplierOrder>> GetAll()
        {
            var result = await _context.SupplierOrder.ToListAsync();
            return result;
        }

        public IActionResult GetById(SupplierOrder supplierOrder)
        {
            throw new NotImplementedException();
        }

        // GET: SupplierOrders/Create
        public IActionResult Create()
        {
            ViewData["FeedbackID"] = new SelectList(_context.Feedback, "ID", "ID");
            ViewData["OrderID"] = new SelectList(_context.Order, "ID", "ID");
            ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Description");
            ViewData["StatusID"] = new SelectList(_context.Status, "ID", "Name");
            return View();
        }

        // POST: SupplierOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,OrderPrice,OrderID,FeedbackID,StatusID,ServiceID")] SupplierOrder supplierOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FeedbackID"] = new SelectList(_context.Feedback, "ID", "ID", supplierOrder.FeedbackID);
            ViewData["OrderID"] = new SelectList(_context.Order, "ID", "ID", supplierOrder.OrderID);
            ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Description", supplierOrder.ServiceID);
            ViewData["StatusID"] = new SelectList(_context.Status, "ID", "Name", supplierOrder.StatusID);
            return View(supplierOrder);
        }

        // GET: SupplierOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            if (supplierOrder == null)
            {
                return NotFound();
            }
            ViewData["FeedbackID"] = new SelectList(_context.Feedback, "ID", "ID", supplierOrder.FeedbackID);
            ViewData["OrderID"] = new SelectList(_context.Order, "ID", "ID", supplierOrder.OrderID);
            ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Description", supplierOrder.ServiceID);
            ViewData["StatusID"] = new SelectList(_context.Status, "ID", "Name", supplierOrder.StatusID);
            return View(supplierOrder);
        }

        // POST: SupplierOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,OrderPrice,OrderID,FeedbackID,StatusID,ServiceID")] SupplierOrder supplierOrder)
        {
            if (id != supplierOrder.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierOrderExists(supplierOrder.ID))
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
            ViewData["FeedbackID"] = new SelectList(_context.Feedback, "ID", "ID", supplierOrder.FeedbackID);
            ViewData["OrderID"] = new SelectList(_context.Order, "ID", "ID", supplierOrder.OrderID);
            ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Description", supplierOrder.ServiceID);
            ViewData["StatusID"] = new SelectList(_context.Status, "ID", "Name", supplierOrder.StatusID);
            return View(supplierOrder);
        }

        // GET: SupplierOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Feedback)
                .Include(s => s.Order)
                .Include(s => s.Service)
                .Include(s => s.Status)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }

        // POST: SupplierOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            _context.SupplierOrder.Remove(supplierOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierOrderExists(int id)
        {
            return _context.SupplierOrder.Any(e => e.ID == id);
        }
    }
}
