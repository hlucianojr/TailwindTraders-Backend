﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Tailwind.Traders.Product.Api2.Infrastructure
{
    public interface IContextSeed<TContext>
        where TContext : DbContext
    {
        Task SeedAsync(TContext context);
    }
}
