﻿using House.Data;
using House.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppHouseHelper.Controllers
{
    public class UserControllers : Controller
    {
        private readonly IUserServices _service;

        public UserControllers(IUserServices service)
        {
            _service = service;
        }

        public async Task<IUserResult> Index()
        {
            var data = await _service.GetAll();
            return (IUserResult)View(data);
        }
    }
}