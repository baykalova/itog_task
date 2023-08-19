string[] mass1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] mass2 = new string[mass1.Length];
void SecondArrayWithIF(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}
void PrintArray(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(mass1, mass2);
PrintArray(mass2);