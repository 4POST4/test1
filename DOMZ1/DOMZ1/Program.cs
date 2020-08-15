using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача №8
            // Положили срочный депозит на квартал (3 месяца) под 24% годовых. Закрыли депозит через 4 месяца
            double size_deposit;
            double interest_on_deposits = 24; //Процент по депозиту задан условиями
            Console.WriteLine("Ведите размер депозита:");
            size_deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ваш депозит:{size_deposit}");
            Console.WriteLine($"Процент по депозиту:{interest_on_deposits} % годовых");
            //Сколько средств на счету будет через 4 месяца
            double profit = size_deposit + (size_deposit * interest_on_deposits / 100) / 3;
            Console.WriteLine($"Через 4 месяца Вы получите:{profit}");


            Console.ReadKey();


        }
    }
}
