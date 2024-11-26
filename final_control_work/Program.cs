string[] input = { "1234", "1567", "-2", "computer science" };
int max = 3;
 
string[] result = new string[input.Length];
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= max)

    {
        result[i] = input[i];
    }

}
foreach (string resultItem in result)
{

    Console.WriteLine(resultItem);
}

