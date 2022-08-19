// See https://aka.ms/new-console-template for more information

List<int> Numbers = new List<int> { 1, 5, 233, 7 };
Console.WriteLine(Player(Numbers));

static bool Player(List<int> Numbers)
{
    int playerOne = 0, playerTwo = 0;
    int Count = Numbers.Count();
    int i = 0;
    while (Numbers.Count() > 0)
    {
        if (Numbers.Count() == 1)
        {
            if (i % 2 == 0) playerOne += Numbers[0];
            else playerTwo += Numbers[0];
            Numbers.RemoveAt(0);
        }
        else
        {
            if (Numbers[0] > Numbers[Numbers.Count() - 1])
            {
                if (Numbers[0] > Numbers[1] || Numbers[Numbers.Count - 2] > Numbers[0])
                {
                    if (i % 2 == 0) playerOne += Numbers[0];
                    else playerTwo += Numbers[0];
                    Numbers.RemoveAt(0);
                }
                else
                {
                    if (i % 2 == 0) playerOne += Numbers[Numbers.Count - 1];
                    else playerTwo += Numbers[Numbers.Count - 1];
                    Numbers.RemoveAt(Numbers.Count - 1);
                }
            }
            else
            {
                if (Numbers[Numbers.Count - 1] > Numbers[Numbers.Count - 2] || Numbers[1] > Numbers[Numbers.Count - 1])
                {
                    if (i % 2 == 0) playerOne += Numbers[Numbers.Count - 1];
                    else playerTwo += Numbers[Numbers.Count - 1];
                    Numbers.RemoveAt(Numbers.Count - 1);
                }
                else
                {
                    if (i % 2 == 0) playerOne += Numbers[0];
                    else playerTwo += Numbers[0];
                    Numbers.RemoveAt(0);
                }
            }
        }
        i++;
    }
    return playerOne > playerTwo || playerOne == playerTwo;
}
