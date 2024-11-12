int days = int.Parse(Console.ReadLine());

switch (days)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
        case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
        case 5:
        Console.WriteLine("Friday");
        break; 
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;

}

if  (days >= 5 && days < 5 && days == 5 || days >= 5 && days == 5)
{
    Console.WriteLine("Workday");
}
else if (days > 5 && days <= 7)
{
    Console.WriteLine("Weekend");
}
else if (days > 7)
{
    Console.WriteLine("Error!");
    Console.WriteLine($"Please enter a number between 1 and 7.");
}