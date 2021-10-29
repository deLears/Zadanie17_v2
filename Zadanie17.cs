using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie17
{
    class Zadanie17
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>(000, "Mister1");
            account1.AccountNumber = 005;

            Account<object> account2 = new Account<object>(000, "Mister1");
            account1.AccountNumber = 006;


            Console.WriteLine(account1.GetSaldo());
            Console.WriteLine("{0}", account2.GetOwner());

            Console.ReadKey();
        }
    }
    public class Account<T>
    {
        public T AccountNumber { get; set; }
        private int AccountSaldo { get; set; }
        string AccountOwner { get; set; }

        public Account(int saldo, string owner)
        {
            GetSaldo();
            this.AccountSaldo = saldo;
            this.AccountOwner = owner;
        }
         public int GetSaldo()
        {
            int saldo = 0;
            Console.WriteLine("Введите сальдо счета:");
            saldo = Convert.ToInt32(Console.ReadLine());
            return saldo;
        }
        public  string GetOwner()
        {
            Console.WriteLine("Введите ФИО владельца счета:");
            string owner = Convert.ToString(Console.ReadLine());
            return owner;
        }


    }
}

