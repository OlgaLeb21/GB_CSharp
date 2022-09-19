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
Console.Write("Enter a character limit: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int count = 0;
    for (int j = 0; j < OldArray[i].Length; j++)
    {
        count += 1;
    }
    if (count > k) 
    {
        OldArray[i] = "";
    }
}

for (int i = 0; i < n - 1; i++) 
{   
    for (int j = 0; j < n - 1; j++) 
    {
        if (OldArray[j] == string.Empty) 
        {
            string temp = OldArray[j];
            OldArray[j] = OldArray[j+1];
            OldArray[j+1] = temp;
        }
    }    
}

for (int i = 0; i < n; i++)
{   
    Console.WriteLine($"String {i + 1} = {OldArray[i]}");
}

int countElements = 0;
for (int i = 0; i < n; i++)
{   
    if (OldArray[i] != string.Empty) 
    {
        countElements += 1;
    }
}

Console.WriteLine();
Console.WriteLine($"The new array will have {countElements} elements");

for (int i = 0; i < countElements; i++) 
{
    NewArray[i] = OldArray[i];
}

Console.WriteLine();

for (int i = 0; i < countElements; i++)
{
    Console.WriteLine($"String {i + 1} = {NewArray[i]}");
}
if (countElements == 0)
{
    Console.WriteLine("New array has no elements");
}

Console.WriteLine();
Console.WriteLine("End of the program");
