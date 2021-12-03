using AdventOfCode2021.Shared;

AppDataInput inputFile = new();
List<string> dataList = inputFile.ReadData("Day01.txt");
int result = 0;
int item1;
int item2 = -1;

for (int i = 0; i < dataList.Count; i++)
{
    item1 = int.Parse(dataList[i]);
    if(item2 == -1)
        Console.WriteLine($"{item1} (N/A - no previous measurement)");

    if (i != (dataList.Count-1))
    {
        item2 = int.Parse(dataList[i + 1]);
    }


    if (item1 < item2)
    {
        Console.WriteLine($"{item2} (increased)");
        result += 1;
    } 
    else
    {
        Console.WriteLine($"{item2} (decreased)");
    }
}

Console.WriteLine($"The number of times a depth measurement increases: {result}");