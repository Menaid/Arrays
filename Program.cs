string[] lines = File.ReadAllLines("../../../data.txt");

foreach (string line in lines)
{
    Console.WriteLine(line);
}

if(lines.Length >= 2)
{
    Console.WriteLine(lines[1]);
}

