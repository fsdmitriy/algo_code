//int value = 11;
//Console.WriteLine(value);
//string binary = Convert.ToString(value, 2);
//Console.WriteLine(binary);

//var test = value >> 1;
//Console.WriteLine(test);
//binary = Convert.ToString(test, 2);
//Console.WriteLine(binary);

Console.WriteLine(Convert.ToString(24, 2));

int n = 11;
int ones = 0;
while (n != 0)
{
    Console.WriteLine("n = {0}", n);
    Console.WriteLine("binary n = {0}", Convert.ToString(n, 2));
    Console.WriteLine("n & 1 = {0}", (n & 1));

    ones = ones + (n & 1);
    n = n >> 1;
    Console.WriteLine("n = {0}", n);
    Console.WriteLine("binary n = {0}", Convert.ToString(n, 2));
}
Console.WriteLine(ones);