// See https://aka.ms/new-console-template for more information
int[] gas = { 2, 3, 4 };
int[] cost = { 3, 4, 3 };
Console.WriteLine(StationIndex(gas, cost));
static int StationIndex(int[] gas, int[] cost)
{
    int index = -1;
    for (int i = 0; i < gas.Length; i++)
    {
        int currentGas = 0;
        for (int j = i; j < i + gas.Length; j++)
        {
            if (j < (i + gas.Length - 1))
            {
                if (j < gas.Length)
                {
                    currentGas += gas[j];
                    currentGas -= cost[j];
                }
                else
                {
                    currentGas += gas[j%gas.Length];
                    currentGas -= cost[j%gas.Length];
                }
                if(currentGas < 0) break;
            }
            else
            {
                index = i;
                break;
            }
        }
    }

    return index;
}
