using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmallCarpetsPrice = 25; 
            int LargeCarpetsPrice = 35;
            Random rand = new Random();
            int ReceiptNumber = rand.Next(100000,1000000);
            DateTime ReceiptDate = DateTime.Now ;
            int TotalPrice = 0;
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service");
            Console.WriteLine("we now have a 30% discont on our prices list");
            Console.WriteLine("our new prices list :");
            Console.WriteLine("$25.00 Instead of $35.00 for small carpets");
            Console.WriteLine("$35.00 Instead of $50.00 For the large carpets");
            Console.WriteLine("How meny small carpets do you want to clean ?");
            int SmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How meny large carpets do you want to clean ?");
            int LargeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("New Receipt");
            Console.WriteLine("Receipt Number : " + ReceiptNumber);
            Console.WriteLine("Receipt Date : " + ReceiptDate);
            Console.WriteLine("Receipt Details : ");
            Console.WriteLine(SmallCarpets + $" Small Carpet  = {SmallCarpets * SmallCarpetsPrice:C} " );
            Console.WriteLine(LargeCarpets + $" Large Carpet  = {LargeCarpets * LargeCarpetsPrice:C} ");
            TotalPrice = (SmallCarpets*SmallCarpetsPrice)+(LargeCarpets*LargeCarpetsPrice);
            Console.WriteLine($"Your Total Price = {TotalPrice:C}" );
            Console.WriteLine("Thank you for choosing us ");
            Console.WriteLine("--------------------------------------------");

        }
    }
}
