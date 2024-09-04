using System;

namespace NShop.Services.CouponAPI.Models.Dto;

public class CouponDto
{
    public int CouponId { get; set; }
    public string? CouponCode { get; set; } = default;
    public double DiscountAmount { get; set; }
    public int MinAmont { get; set; }
}
