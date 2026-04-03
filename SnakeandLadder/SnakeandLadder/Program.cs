using System;

class Program
{
    static void Main()
    {
        int player1 = 0;
        int player2 = 0;
        int diceCount = 0;

        Console.Write("Enter number of players (1 or 2): ");
        int players = int.Parse(Console.ReadLine());

        int currentPlayer = 1;
        Random rand = new Random();

        while (true)
        {
            Console.WriteLine("\nPlayer " + currentPlayer + " Turn");
            Console.Write("Press Y to roll dice: ");
            char ch = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (ch != 'Y')
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            int dice = rand.Next(1, 7);
            diceCount++;
            Console.WriteLine("Dice: " + dice);

            int option = rand.Next(0, 3); // 0 NoPlay, 1 Ladder, 2 Snake

            if (option == 0)
                Console.WriteLine("No Play");
            else if (option == 1)
                Console.WriteLine("Ladder");
            else
                Console.WriteLine("Snake");

            // Apply move
            if (currentPlayer == 1)
            {
                player1 = Move(player1, dice, option);
                Console.WriteLine("Player 1 Position: " + player1);

                if (player1 == 100)
                {
                    Console.WriteLine("🎉 Player 1 Wins!");
                    break;
                }
            }
            else
            {
                player2 = Move(player2, dice, option);
                Console.WriteLine("Player 2 Position: " + player2);

                if (player2 == 100)
                {
                    Console.WriteLine("🎉 Player 2 Wins!");
                    break;
                }
            }

            // Change turn (if not ladder)
            if (option != 1)
            {
                if (players == 2)
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
            else
            {
                Console.WriteLine("Extra Turn (Ladder!)");
            }
        }

        Console.WriteLine("Total Dice Rolls: " + diceCount);
    }

    static int Move(int pos, int dice, int option)
    {
        if (option == 1) // Ladder
            pos += dice;
        else if (option == 2) // Snake
            pos -= dice;

        if (pos < 0)
            pos = 0;

        if (pos > 100)
            pos -= dice;

        return pos;
    }
}