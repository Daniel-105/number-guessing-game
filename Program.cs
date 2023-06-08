

// Number = 7
Console.WriteLine("Welcome to the game!");
Console.WriteLine("Please enter the max number of the range:");

double maxNumber = Convert.ToInt32(Console.ReadLine());
double highestSoFar = maxNumber;
double lowestSoFar = 1;

Console.WriteLine("Max number is " + maxNumber);

double machineGuess = maxNumber / 2;
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
        machineGuess = Math.Round(machineGuess + machineGuess/2); 
        Console.WriteLine("Your number is " + machineGuess);
        userResponse = Console.ReadLine();
      }
    
  }
  else if (userResponse == "lower") {
    if (highestSoFar - lowestSoFar == 1) 
    {
      Console.WriteLine("Your number is " + lowestSoFar);
      userResponse = Console.ReadLine();
    } 
    else 
    {
      highestSoFar = machineGuess; 
      machineGuess = Math.Round(machineGuess - (machineGuess - lowestSoFar) / 2); 
      Console.WriteLine("Your number is " + machineGuess);
      userResponse = Console.ReadLine();
    }
  }
}

Console.WriteLine("I won");

// 







