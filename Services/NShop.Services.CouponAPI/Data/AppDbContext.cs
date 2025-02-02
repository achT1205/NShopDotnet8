using System;
using Microsoft.EntityFrameworkCore;
using NShop.Services.CouponAPI.Models;

namespace NShop.Services.CouponAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Coupon> Coupons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Coupon>().HasData(new Coupon
        {
            CouponId = 1,
            CouponCode = "10OFF",
            DiscountAmount = 10,
            MinAmont = 20
        }, new Coupon
        {
            CouponId = 2,
            CouponCode = "20OFF",
            DiscountAmount = 20,
            MinAmont = 40
        });
    }
}
