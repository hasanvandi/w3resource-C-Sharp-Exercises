Console.Write("Enter the number:");
int number = int.Parse(Console.ReadLine());

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{number} * {i} = " + number * i);
}

Console.ReadLine();