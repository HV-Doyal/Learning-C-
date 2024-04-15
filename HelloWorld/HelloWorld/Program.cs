namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,num2;
            float pi = 3.1415f;
            bool isreal = true;
            string myName = "Denis";
            char at = '@';

            number = 13;
            num2 = 11;
            Console.WriteLine("HelloWorld!" + number + pi + isreal + myName + at);
            Console.ReadLine();
        }
    }
}