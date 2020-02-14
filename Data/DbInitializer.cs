using OnlineStore.Models;
using System;
using System.Linq;

namespace OnlineStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (ctx.Users.Any())
                return;

            if (ctx.Items.Any())
                return;

            var items = new Item[]
            {
                new Item{ name="Milk", price=2.20},
                new Item{ name="Bread", price=1.20},
                new Item{ name="Eggs", price=0.90},
            };

            foreach (var user in items)
            {
                ctx.Items.Add(user);
            }

            ctx.SaveChanges();

            var users = new User[]
            {
                new User{ name="Test", createdAt=DateTime.Now},
            };

            foreach(var user in users)
            {
                ctx.Users.Add(user);
            }

            ctx.SaveChanges();
        }
    }
}
