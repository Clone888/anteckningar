// Läsa in input

var input = Console.ReadLine();
Console.WriteLine(" Your input was " + input);


// Byta ut bokstäver
var word = "hejdå";
word = word.Remove(3, 1).Insert(3, "a");
Console.WriteLine(word);


//loopa igenom i en array
var everything = "a word";
foreach(var item in everything)
{
    Console.Write("_" + item);
}


//Booleans
var answer = false;
if(!answer)
{
    Console.WriteLine("Answer is false");
}

if (answer)
{
    Console.WriteLine("Answer is true");
}



//Hämta data ifrån strings
Console.WriteLine(" The length of the word: " + input + " is: " + input.Length);

// string manipulation och metorder
Console.WriteLine(" My input word, when capialized" + input.ToUpper());
Console.WriteLine(" My input word, when lowercase" + input.ToLower());

// metoder

for (int i = 0; i < word.Length; i++)
{
    var letter = word[i];
    Console.WriteLine("The letter at the pos " + i + "is ");
}