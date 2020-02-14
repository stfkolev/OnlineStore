using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Controllers
{
    public class ItemsController : Controller
    {
        private readonly StoreContext ctx;
        public ItemsController(StoreContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this.ctx.Items.ToListAsync());
        }
    }
}