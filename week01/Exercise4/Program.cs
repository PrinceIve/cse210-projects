using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();
        int number;
        int sum = 0;

         do
        {
            Console.Write("Enter a Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) 
            {
                numbers.Add(number);
            }

        } while (number != 0);


        foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }
        
        foreach (int numb in numbers)
        {
            sum += numb;  // Add each number to sum
        }
        Console.WriteLine("The sum is: " + sum);
        

        double average = (double)sum / numbers.Count; 
        Console.WriteLine("The average is: " + average);
        
        int max = numbers[0]; 

        foreach (int num in numbers)
        {
            if (num > max)  
            {
                max = num;
            }
        }
        Console.WriteLine("The largest number is: " + max);
    }
}