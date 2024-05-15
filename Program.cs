namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TipCalculator();
        }
        static void TipCalculator()
        { 
            Console.WriteLine("Welcome to tip calculator.");
            Console.WriteLine();
            Console.WriteLine("Please enter your bill total: ");
            decimal totalBill = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the wanted tip percentage: (e.g) 10% 15% 20%. ");
            decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());
            decimal totalPrice = (tipPercentage/100 * totalBill + totalBill);
            Console.WriteLine("Your total bill including the tip is: " + totalPrice);
        }        
    }




    //Design a tip calculator : enter the bill total, tip % and display grand total after adding tip. 
}
