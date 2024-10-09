// See https://aka.ms/new-console-template for more information


//Console.WriteLine("what is your favorite animal");
//string favoriteAniaml = Console.ReadLine();
//Console.WriteLine($"you like{favoriteAniaml}");

//1
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "Type", "Bytes", "Min Value", "Max Value");
Console.WriteLine(new string('-', 80));  // Divider line

// sbyte
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
// byte
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
// short
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
// ushort
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
// int
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
// uint
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
// long
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
// ulong
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
// float
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
// double
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
// decimal
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);


//2
Console.WriteLine("Enter number");
int centry = int.Parse(Console.ReadLine());
int year = centry * 100;
int month = year * 12;
Console.WriteLine(centry + " centry = " + year + " years = " + month + " month");

//Practice loops and operators
//1
//Practice loops and operators
for (int i = 1; i <= 100; i++)
{
    // Check if divisible by both 3 and 5 (FizzBuzz)
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    // Check if divisible by 3 (Fizz)
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    // Check if divisible by 5 (Buzz)
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    // If not divisible by 3 or 5, just print the number
    else
    {
        Console.WriteLine(i);
    }
}
//1.2  it will print from 0 to 499

//3
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("input number");
int guess = int.Parse(Console.ReadLine());
if (guess >= 1 && guess < correctNumber)
{
    Console.WriteLine("bigger");
}
else if (guess <= 3 && guess < correctNumber)
{
    Console.WriteLine("smaller");
}
else
{
    Console.WriteLine("right");
}


//2
int rows = 5; // You can change the number of rows here.

// Outer loop for each row
for (int i = 1; i <= rows; i++)
{
    // Inner loop 1: Prints spaces before the stars
    for (int j = i; j < rows; j++)
    {
        Console.Write(" ");
    }

    // Inner loop 2: Prints stars for the current row
    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
    }

    // Move to the next line after printing one row
    Console.WriteLine();
}


//// Define the birth date (you can change the date to your own)
//DateTime birthDate = new DateTime(1995, 10, 6); // Format: Year, Month, Day

//// Get the current date
//DateTime currentDate = DateTime.Now;

//// Calculate the difference in days
//TimeSpan ageDifference = currentDate - birthDate;

//// Output the result
//Console.WriteLine("You are {0} days old.", ageDifference.Days);

//4
DateTime birthDate = new DateTime(1995, 10, 6); // Format: Year, Month, Day
// Get the current date
DateTime currentDate = DateTime.Now;
// Calculate the age in days
int daysOld = (currentDate - birthDate).Days;
// Output the age in days
Console.WriteLine($"You are {daysOld} days old.");

//5
Console.WriteLine(DateTime.Now);
int currentHour = DateTime.Now.Hour;
if (currentHour >= 5 && currentHour < 12)
{
    Console.WriteLine("Good Morning");
}

if (currentHour >= 12 && currentHour < 17)
{
    Console.WriteLine("Good Afternoon");
}

if (currentHour >= 17 && currentHour < 21)
{
    Console.WriteLine("Good Evening");
}

if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 5))
{
    Console.WriteLine("Good Night");
}


//6
for (int i=1;i<=4;i++ ) {
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write(j+" ");
    }
    Console.WriteLine();
}
