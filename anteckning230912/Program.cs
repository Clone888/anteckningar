// läsa in rader ut en fil, uppdatera "hangman"

string[] lines = File.ReadAllLines("../../../data.txt"); // "~" = användaremappen, "/" = nuvarande filesysytem, "../" = går upp en folder

foreach (string line in lines)
{
    Console.WriteLine(line);
}


string? input = string.Empty;
int selected;


// if (input only number)
//{

//return true, else return false
//}


while (!int.TryParse(input, out selected)) // loops until we input a number, 'tryparse' försök konvertera int till string
{
    input = Console.ReadLine(); // reads the input, be om input till det är rätt.
}

Console.WriteLine(selected); // writes a number