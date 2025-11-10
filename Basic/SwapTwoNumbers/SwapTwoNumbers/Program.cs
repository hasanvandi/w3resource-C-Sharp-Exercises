int number_01, number_02, temp;


Console.Write("Input the First Number:");
number_01 =Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Second Number:");
number_02 = Convert.ToInt32(Console.ReadLine());


temp = number_01;
number_01 = number_02;
number_02 = temp;

Console.WriteLine("First Number:" + number_01);
Console.WriteLine("Second  Number:" + temp);

Console.ReadLine();