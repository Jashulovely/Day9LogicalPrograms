using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponCode
    {
        public void Coupon()
        {
            HashSet<string> generatedCodes = new HashSet<string>();
            Random random = new Random();
            while (true)
            {
                string couponCode = GenerateCouponCode(random);
                if (generatedCodes.Contains(couponCode))
                {
                    Console.WriteLine($"Coupon code {couponCode} is not new.");
                    break;
                }
                else
                {
                    Console.WriteLine($"New coupon code: {couponCode}");
                    generatedCodes.Add(couponCode);
                }
            }
        }
        static string GenerateCouponCode(Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder couponCode = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                couponCode.Append(chars[random.Next(chars.Length)]);
            }
            return couponCode.ToString();
        }
    }
}
