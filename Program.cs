

// Number = 7
Console.WriteLine("Welcome to the game!");
Console.WriteLine("Please enter the max number of the range:");

double maxNumber = Convert.ToInt32(Console.ReadLine());
double highestSoFar = maxNumber;
double lowestSoFar = 0;

Console.WriteLine("Max number is " + maxNumber);

double machineGuess = Math.Round(maxNumber / 2);
Console.WriteLine("Your number is " + machineGuess);
string userResponse = Console.ReadLine();


while (userResponse != "yes") 
{
    if (userResponse == "higher") 
    {
      if (highestSoFar - lowestSoFar == 2) 
      {
        Console.WriteLine("Your number is " + lowestSoFar++);
        userResponse = Console.ReadLine();
      } 
      else 
      {
        lowestSoFar = machineGuess; 
        machineGuess = Math.Round(machineGuess + (highestSoFar - lowestSoFar)/2); 
        Console.WriteLine("Your number is " + machineGuess);
        userResponse = Console.ReadLine();
      }
    
  }
  else if (userResponse == "lower") {
    if (highestSoFar - lowestSoFar == 2) 
    {
      Console.WriteLine("Your number is " + lowestSoFar++);
        userResponse = Console.ReadLine();
    } 
    else 
    {
      highestSoFar = machineGuess; 
      machineGuess = Math.Round(machineGuess - (highestSoFar - lowestSoFar)/2); 
      Console.WriteLine("Your number is " + machineGuess);
      userResponse = Console.ReadLine();
    }
  }
}

Console.WriteLine("I won");

// 







