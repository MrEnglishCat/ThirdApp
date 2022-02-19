using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int[] array = new int[10];
        int choiceUser = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1,3);
        }
        int choiceRandom = array[random.Next(array.Length-1)];
        Console.WriteLine("Enter the number:");

        try
        {
            choiceUser = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);            
        }
        finally
        {
            if (choiceRandom == choiceUser)
            {
                Console.WriteLine($@"You are WIN! Congratulations! ");
                Console.WriteLine($@"Choice of Random: {choiceRandom}");
                Console.WriteLine($@"Choice of User: {choiceUser}");
            }
            else
            {
                Console.WriteLine($@"You are NOT win!");
                Console.WriteLine($@"Choice of Random: {choiceRandom}");
                Console.WriteLine($@"Choice of User: {choiceUser}");
            }            
        }
           
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 3 == 0)
                Console.WriteLine();
            Console.Write($@"{array[i]} ");
        }


        Console.ReadLine();
    } 
}
