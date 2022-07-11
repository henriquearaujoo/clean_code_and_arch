using System;

namespace CleanArch
{
    public class Coupon
    {
        public decimal Percentage { get; internal set; }

        internal bool IsExpired()
        {
            throw new NotImplementedException();
        }
    }
}