//List, Switch Case, HashMap/Dictionary/Map

//Switch


string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

foreach (string day in week)
{
    switch (day)
    {
        case "Monday": 
            Console.Write("Go to work");
            break;

        case "Tuesday":
            Console.WriteLine("Go to work");
            break;

        case "Wednesday":
        case "Thursday":
        case "Friday":
            Console.WriteLine("Go to work");
            break;

        default:
            Console.WriteLine("Stay home");
            break;

    }
}




// Switch

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Someday" };

foreach (string day in week)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            Console.WriteLine("Go to work");
            break;
        case "Saturday":
        case "Sunday":
            Console.WriteLine("Stay home");
            break;
        default:
            Console.WriteLine("Not a week day we know of");
            break;
    }
}

// List

List<string> audiParts = new List<string>(week)
{
    "Turbo",
    "Koppling",
};

audiParts.Add("stuff");

foreach (string part in audiParts)
{
    Console.WriteLine(part);
}

// Dictionary
Dictionary<string, int> nameToBirthYear = new Dictionary<string, int>();

nameToBirthYear.Add("manuel", 2000);
nameToBirthYear.Add("arvid", 2003);
nameToBirthYear.Add("klas", 1989);
nameToBirthYear.Add("paulina", 1994);
nameToBirthYear.Add("ali", 1999);

Console.WriteLine(nameToBirthYear["manuel"]);
nameToBirthYear["manuel"] = 2001;
Console.WriteLine(nameToBirthYear["manuel"]);

nameToBirthYear.Add("X", 0);
nameToBirthYear.Add("Y", 3);
nameToBirthYear.Add("Z", 6);

nameToBirthYear["manuel"] = 2000;
string choice = Console.ReadLine().ToLower();


switch (nameToBirthYear.ContainsKey(choice))
{
    case true:
        Console.WriteLine("Their birth year is: " + nameToBirthYear[choice]);
        break;
    case false:
        Console.WriteLine("We don't have their information stored");
        break;
}


// List

List<string> audiParts = new List<string>(week) // "week" är en array sedan innan.
{
    "part1",// lägger till först i listan
    "part2",// lägger till andra plats

};

audiParts.Add(item: "Turbo"); // lägger till "turbo"
audiParts.Add(item: "Koppling");    // läggger till 


foreach (string part in audiParts)
{
    Console.WriteLine(part);
}



// Dictionary


Dictionary<string, int> nameToBirthYear = new Dictionary<string, int>(); // Endast 2 värden, En nyckel och ett värde

nameToBirthYear.Add("Dan", 1988); //Key and Value, "Dan" = Key och "1988" = Value 
nameToBirthYear.Add("Manuell", 2000);
nameToBirthYear.Add("Paulina", 1944);
nameToBirthYear.Add("Avrid", 2003);

nameToBirthYear["Arvid"] = 2001;

Console.WriteLine(nameToBirthYear["Dan"]);

nameToBirthYear.Add("X", 0);

string choice = Console.ReadLine();

if (nameToBirthYear.ContainsKey(choice))
{
    Console.WriteLine($"Birthyear = {nameToBirthYear}");
}
else
{
    Console.WriteLine("No name found");
}
