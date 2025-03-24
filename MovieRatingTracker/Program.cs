using System;
class Program
{
    static void Main ()
    {
        string movieName;
        
        // impelemnting logic to accept and test user input
        do
        {
            Console.WriteLine("Enter your movie name"); 
            movieName = Console.ReadLine(); 
        
            //checking to make sure input is not empty
            if (string.IsNullOrEmpty(movieName)) 
            {
                Console.WriteLine("Invalid entry please try again, the movie name can not be empty");
            }
       
        } while (string.IsNullOrEmpty(movieName));
        
        Console.WriteLine("You entered,"+ movieName);

    }
}
