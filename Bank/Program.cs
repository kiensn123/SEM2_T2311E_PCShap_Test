using System;

namespace Bank;
class Program
{
    static void Main(string[] args)
    {

           Foreign_currency foreignCurrency = new Foreign_currency
                {
                    USD = 24000, // 1 USD = 24,000 VND
                    VND = 1
                };

            Console.WriteLine("Chọn loại tài khoản: 1. Tài khoản thường, 2. Tài khoản ngoại tệ");
            int accountType = int.Parse(Console.ReadLine());

            Account account;
            if (accountType == 1)
            {
                account = new Nomal_Account { Balance = 25000000 }; // Số dư ban đầu: 25 triệu VND
            }
            else
            {
                account = new ExchangeAccount
                {
                    Balance = 1000,      
                };
            }

            Console.WriteLine("Nhập số tiền bạn muốn chuyển khoản:");
            float amount = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSố dư trước khi chuyển khoản:");
            account.Check_balance();

            account.Tranfrom(amount);

            Console.WriteLine("\nSố dư sau khi chuyển khoản:");
            account.Check_balance();
    }
}