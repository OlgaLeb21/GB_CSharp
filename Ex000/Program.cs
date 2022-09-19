Console.Write("Enter the number of lines: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] OldArray = new string[n];
string[] NewArray = new string[n];

for (int i = 0; i < n; i++)
{
    OldArray[i] = Console.ReadLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{   
    Console.WriteLine($"String {i + 1} = {OldArray[i]}");
}

Console.WriteLine();
