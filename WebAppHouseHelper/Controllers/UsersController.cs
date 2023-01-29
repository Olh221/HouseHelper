using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using House.Data;
using House.Domain.Entities;
using House.Domain.Services;

namespace WebAppHouseHelper.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> GetById()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> Add()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> Update()
        {
            var data = await _service.GetAll();
            return View(data); 
        }
        public async Task<IActionResult> Delete()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
