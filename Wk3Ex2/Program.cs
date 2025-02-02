//declares variable user input for yes
double userinput;

//declares varibale dice/random number
Random Dice = new Random();


while (true)
{
    

    //promts user input to roll dice
    Console.WriteLine(" do you want to roll a dice ");
    Console.WriteLine(" For yes input 1, For no input 2, ");

    //collects user input
    userinput = Convert.ToDouble(Console.ReadLine());

    //calutes the dice rolling
    if (userinput == 1)
    {
        //caluates random number of a D6
        Console.WriteLine(" You rolled : " + Dice.Next(7));

        //promts user to play again
        Console.WriteLine(" do you want to play again? ");
        Console.WriteLine(" For yes input 1, For no input 2, ");

        //collects user input
        userinput = Convert.ToDouble(Console.ReadLine());

        if (userinput == 2)
        {
            break;
        }


    }
    //promts user to exit the program
    else if (userinput == 2)
    {
        //outputs final lines
        Console.WriteLine("Thank you for playing");
        Console.ReadLine();


    }
}

