using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class DbInitializer
{
    public static void Initialize(ECommerceContext context)
    {
        context.Database.EnsureCreated();
        context.SaveChanges();
    }


}
