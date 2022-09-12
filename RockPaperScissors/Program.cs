// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Hello, another console message");


// Dictionary<string, int> play = new Dictionary<string, int>();
// play.Add("rock", 1);
// play.Add("paper", 2);
// play.Add("scissors", 3);

// int computerChoice = 1;

List<string> play = new List<string>{
  "rock",
  "paper",
  "scissors"
};

int score = 0;

Console.WriteLine("Rock, Paper, Scissors - SHOOT!");

bool playing = true;
do
{
  Random rand = new Random();
  int randomIndex = rand.Next(0, play.Count);
  string computerChoice = play[randomIndex];
  bool won = false;


  bool validInput = false;
  string? input = "";

  do
  {
    input = Console.ReadLine();
    if (input == "rock" || input == "paper" || input == "scissors")
    {
      validInput = true;
    }
    else
    {
      validInput = false;
      Console.WriteLine("These are not valid inputs. Input Rock, Paper, or Scissors");
    }
  } while (validInput == false);


  if (input == "rock" && computerChoice == "scissors")
  {
    won = true;
    Console.WriteLine("You beat the computer! " + "the computer played: " + computerChoice);
    score++;
    Console.WriteLine("Score: " + score);
  }
  else if (input == "paper" && computerChoice == "rock")
  {
    won = true;
    Console.WriteLine("You beat the computer! " + "the computer played: " + computerChoice);
    score++;
    Console.WriteLine("Score: " + score);
  }
  else if (input == "scissors" && computerChoice == "paper")
  {
    won = true;
    Console.WriteLine("You beat the computer! " + "the computer played: " + computerChoice);
    score++;
    Console.WriteLine("Score: " + score);
  }
  else if (input == computerChoice)
  {
    won = false;
    Console.WriteLine("It's a tie " + "the computer played: " + computerChoice);
  }
  else
  {
    won = false;
    Console.WriteLine("The computer beat you - sad " + "the computer played: " + computerChoice);

    Console.WriteLine("keeping playing? Type y or n:");
    string? keepPlaying = "";
    keepPlaying = Console.ReadLine();
    if (keepPlaying == "n")
    {
      playing = false;
    }
    else if (keepPlaying == "y")
    {
      playing = true;
    }
  }
} while (playing);