using System;

namespace Bank;

public class Nomal_Account : Account
{
    public override void Check_balance()
    {
          System.Console.WriteLine("Số dư của bạn: "+Balance);
    }

    public override void Tranfrom(float money)
    {
       if (money > Balance)
            {
                Console.WriteLine("Số dư không đủ để chuyển khoản.");
                return;
            }
            Balance -= money;
            Console.WriteLine($"Bạn đã chuyển {money} đ, số dư của bạn: {Balance} đ");
    }
}
