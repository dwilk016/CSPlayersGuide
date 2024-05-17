using System;

class Program
{
	public static void Main() 
	{	
		Intro();
		Console.WriteLine("Press any key when you are ready to start.");
		Console.ReadKey(true);
		
		string player1Request = "Player 1, how far away from the city do you want to station the Manticore? ";
		int manticoreRange = AskForNumberInRange(player1Request, 1, 100);
		
		int manticoreHealth = 10;
		int consolaHealth = 15;
		
		int round = 1;
		
		Console.Clear();
		Console.WriteLine("Player 2, it is your turn.");
		
		while(consolaHealth > 0 && manticoreHealth > 0)
		{
		    Console.WriteLine("------------------------------");
		    Console.WriteLine($"STATUS: Round: {round}  City: {consolaHealth}/15  Manticore: {manticoreHealth}/10");
		    Console.WriteLine($"The cannon is expected to deal {CannonDamage(round)} damage this round.");
		    int target = AskForNumberInRange("Enter desired cannon range: ", 1, 100);
		    
		    if(target == manticoreRange)
		    {
		        Console.WriteLine("That round was a DIRECT HIT!");
		        manticoreHealth -= CannonDamage(round);
		        manticoreHealth = Math.Clamp(0, manticoreHealth, 10);
		        if (manticoreHealth <= 0) break;
		    }
		    else
		    {
		        if (target > manticoreRange) Console.WriteLine("That round OVERSHOT of the target.");
		        if (target < manticoreRange) Console.WriteLine("That round FELL SHORT the target.");
		    }
		    
		    consolaHealth--;
		    round++;
		}
		
		Console.WriteLine("------------------------------");
		if (manticoreHealth < consolaHealth)
		{
		    Console.WriteLine("The Manticore has been destroyed! The City of Consolas has been saved!");
		}
		else
		{
		    Console.WriteLine("The City of Consolas has been destroyed.");
		}
		
	}
	
	static int CannonDamage(int round)
	{
	    
	    bool isFire = round % 3 == 0;
	    bool isElectric = round % 5 == 0;
	    
	    if (isFire && isElectric) return 10;
	    if (isFire) return 3;
	    if (isElectric) return 3;
	    return 1;
	}
	
	static int AskForNumberInRange(string text, int min, int max)
	{
	    Console.Write(text);
	    
	    while (true)
	    {
	        string input = Console.ReadLine();
	        
	        if (int.TryParse(input, out int value) && isInRange(value, min, max))
	        {
	            return value;
	        }
	        else
	        {
	            Console.Write($"Please Enter an Interger between {min} and {max}: ");
	        }
	    }
	}
	
	static bool isInRange(int value, int min, int max)
	{
	    return (value >= min && value <= max);
	}
	
	static void Intro()
    {
		Console.WriteLine();
		Console.WriteLine("=================================");
        Console.WriteLine("=   The Hunt for the Manticore  =");
		Console.WriteLine("=================================");
		Console.WriteLine("=   The Manticore is attacking  =");
        Console.WriteLine("=   the city of Consola. It is  =");
		Console.WriteLine("=   up to you to mount a        =");
		Console.WriteLine("=   defense. Can you save the   =");
        Console.WriteLine("=   city?                       =");
		Console.WriteLine("=================================");
        Console.WriteLine();
    }
}
