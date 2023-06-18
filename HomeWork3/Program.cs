int inputNumber = int.Parse(Console.ReadLine());
if (inputNumber < 2)
{
    Console.WriteLine("Is not a Prime Number");
}
else if (inputNumber == 2)
{
    Console.WriteLine("Is  a Prime Number");
}
else if (inputNumber % 2 == 0)
{
    Console.WriteLine("Is not a Prime Number");
}
else
{
    int divisor = 3;
    bool isPrime = true;
    while (divisor < inputNumber)
    {
        if (inputNumber % divisor == 0)
        {
            isPrime = false;
            Console.WriteLine("Is not a Prime Number");
            break;
        }
        divisor += 2;
    }
    if (isPrime)
    {
        Console.WriteLine("Is  a Prime Number");
    }
}

