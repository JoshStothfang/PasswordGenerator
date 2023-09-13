int length;
bool numbers;
bool symbols;

var password = "";

var rand = new Random();

Console.Write("Length of password?: ");

try
{
    length = Convert.ToInt32(Console.ReadLine());

    if (length < 8 || length > 100)
    {
        Console.WriteLine("Length must be greater than 7 and less than 101.");
        return;
    }
}
catch
{
    Console.WriteLine("Length must be an integer.");
    return;
}


Console.Write("Include Numbers?(y/n): ");

var input = Console.ReadLine();

if (input == "y" || input == "Y")
{
    numbers = true;
}
else if (input == "n" || input == "N")
{
    numbers = false;
}
else
{
    Console.WriteLine("Invalid entry.");
    return;
}


Console.Write("Include Symbols?(y/n): ");

var input2 = Console.ReadLine();

if (input2 == "y" || input2 == "Y")
{
    symbols = true;
}
else if (input2 == "n" || input2 == "N")
{
    symbols = false;
}
else
{
    Console.WriteLine("Invalid entry.");
    return;
}


if (numbers == true && symbols == false)
{
    var codes = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
                            65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                            97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122};

    for (int i = 0; i < length; i++)
    {
        password = password + (char)codes[rand.Next(0, codes.Length)];
    }
}
else if (numbers == false && symbols == true)
{
    var codes = new int[] { 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47,
                            58, 59, 60, 61, 62, 63, 64,
                            65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                            91, 92, 93, 94, 95, 96,
                            97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122,
                            123, 124, 125, 126};

    for (int i = 0; i < length; i++)
    {
        password = password + (char)codes[rand.Next(0, codes.Length)];
    }
}
else if (numbers == true && symbols == true)
{
    for (int i = 0; i < length; i++)
    {
        password = password + (char)rand.Next(33, 127);
    }
}
else
{
    var codes = new int[] { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                            97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122};

    for (int i = 0; i < length; i++)
    {
        password = password + (char)codes[rand.Next(0, codes.Length)];
    }
}

Console.WriteLine(password);


