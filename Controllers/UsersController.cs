﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Controllers
{
    public class UsersController : Controller
    {
        private readonly StoreContext ctx;

        public UsersController(StoreContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this.ctx.Users.ToListAsync());
        }
    }
}