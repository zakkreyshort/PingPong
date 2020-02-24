using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Write a number:"); 
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("Ping-Pong");
            }
            else if (index % 3 == 0)
            {
                Console.WriteLine("Ping");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Pong");
            }
            else{
                Console.WriteLine(index);
            }
        }
    }
}