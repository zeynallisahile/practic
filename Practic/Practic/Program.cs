using System;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            string lengthStr;
            int length;
            do
            {

                Console.WriteLine("Book sayini daxil edin:");
                lengthStr = Console.ReadLine();
                length = Convert.ToInt32(lengthStr);

            } while (length<0);

            Book[] books = new Book[length];
            for (int i = 0; i < length; i++)
            {
                
            }
        }
        static int Getinputint(string name,int max,int min)
        {
            int input;
            string inputstr;
            do
            {
                Console.WriteLine(name);
                inputstr = Console.ReadLine();
                input = Convert.ToInt32(inputstr);

            } while (input<min || input>max);
            return input;
        }
    }
}
