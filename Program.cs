namespace Metod
{
    internal class Program
    {

        public static int Add(int firstNumber, int secondNumber, int thirdNumber)
        {

            return firstNumber * secondNumber * thirdNumber;

        }

        static void ShowDivider()
        {

            Console.WriteLine("**************Devider****************");
        
        }

        public static int GetNumberFromUser()

        {
            Console.WriteLine("Pleace inter your number");
            string numstr = Console.ReadLine();
            int num = int.Parse(numstr);
            return num;
        }

       

        static void Main(string[] args)
        {

            ShowDivider();

            int num1 = GetNumberFromUser();


            int num2 = GetNumberFromUser();


            int num3 = GetNumberFromUser();

            int resualt = Add(num1, num2, num3);

            Console.WriteLine(resualt);


        }
    }
}