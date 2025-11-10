int number_01, number_02;

Console.Write("Input the first number:");
number_01 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first number:");
number_02 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number_01} + {number_02} = " + (number_01 + number_02));
Console.WriteLine($"{number_01} - {number_02} = " + (number_01 - number_02));
Console.WriteLine($"{number_01} * {number_02} = " + (number_01 * number_02));
Console.WriteLine($"{number_01} / {number_02} = " + (number_01 / number_02));
Console.WriteLine($"{number_01} % {number_02} = " + (number_01 % number_02));


Console.ReadLine();