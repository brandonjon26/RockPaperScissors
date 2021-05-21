using System;

void RockHand(int pick)
{
    if (pick == 1)
    {

        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
    ");
    }
    if (pick == 2)
    {
        Console.WriteLine(@"
     _______
-- - '  ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    }
    if (pick == 3)
    {
        Console.WriteLine(@"
    _______
-- - '   ____)____
            ______)
       __________)
      (____)
-- -.__(___)
    ");
    }

}


int myScore = 0;
int computerScore = 0;
Play();
void Play()
{
    Console.Clear();
    if (myScore == 3)
    {
        Console.WriteLine("Winner!!!");
    }
    else if (computerScore == 3)
    {
        Console.WriteLine("Loser!");
    }
    else
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"|Player: {myScore} | Computer: {computerScore} |");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Make a choice...");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");



        string pick = Console.ReadLine();
        int myPick = Int32.Parse(pick);

        Random i = new Random();
        int computerPick = i.Next(1, 3);
        RockHand(myPick);
        Console.WriteLine("VS");
        RockHand(computerPick);
        System.Threading.Thread.Sleep(750);

        if (myPick == computerPick)
        {
            Play();
        }
        else if (myPick == 1)
        {
            if (computerPick == 2)
            {
                computerScore++;
                Play();
            }
            else
            {
                myScore++;
                Play();
            }
        }
        else if (myPick == 2)
        {
            if (computerPick == 3)
            {
                computerScore++;
                Play();
            }
            else
            {
                myScore++;
                Play();
            }
        }
        else if (myPick == 3)
        {
            if (computerPick == 1)
            {
                computerScore++;
                Play();
            }
            else
            {
                myScore++;
                Play();
            }
        }
    }

}