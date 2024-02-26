namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of " + apples + "apple(s): ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + apples + "apple(s) " + totalPrice);
            Console.WriteLine("The value of original price is " + totalPrice);
            int totalPrice1 = (int)totalPrice;
            Console.WriteLine("The value of converted price is " + totalPrice1);

        }
    }
}