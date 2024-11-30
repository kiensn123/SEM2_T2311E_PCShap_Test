using System;

namespace Bank;

public class ExchangeAccount : Account
{
    
    Foreign_currency foreign_Currency;

    public override void Check_balance()
    {

        Balance = foreign_Currency.USD_to_VND(Balance);
        Console.WriteLine($"Số dư của bạn: {Balance} đ");
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
