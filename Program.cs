

// Number = 7
Console.WriteLine("Welcome to the game!");
Console.WriteLine("Please enter the max number of the range:");

int maxNumber = Convert.ToInt32(Console.ReadLine()); // 10
int highestSoFar = maxNumber;
int lowestSoFar = 1;

Console.WriteLine("Max number is " + maxNumber);

int machineGuess = maxNumber / 2;
Console.WriteLine("Your number is " + machineGuess);
string userResponse = Console.ReadLine();


while (userResponse != "yes") 
{
  if (highestSoFar - lowestSoFar == 2) {
    Console.WriteLine("Your number is " + lowestSoFar++);
    userResponse = Console.ReadLine();
  } 
  else if (userResponse == "higher") {
    lowestSoFar = machineGuess;
    machineGuess = Math.Floor(machineGuess + machineGuess/2); // 8
  }
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
}


// 







