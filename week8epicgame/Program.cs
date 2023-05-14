//string[] heroes = {"harry potter", "supermario", "scooby-doo", "Lara croft"}
//string[] villains = { "voldermort", "dracula", "joker", "sauron", "darth vader" };

string folderpath = @"C:\Users\Auli\source\repos\textdoc\";
string herofile = "heroes.txt";
string villainfile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderpath, herofile));
string[] villains = File.ReadAllLines(Path.Combine(folderpath, villainfile));

string[] weapon = {"magic wand","plastic fork","banana","wooden sword", "lego brick"};

string hero = getrandomevaluefromarray(heroes);
string heroweapon = getrandomevaluefromarray(weapon);
Console.WriteLine($"today {hero} with {HeroeWeapon} saves the day");
 

string villain = getrandomevaluefromarray(villains);
string villainweapon = getrandomevaluefromarray(weapon);
Console.WriteLine($"today {villain} with {villainweapon} tries to take over the world!");

static string getrandomevaluefromarray(string[] somearray)
{
Random rnd = new Random();
    int randomindex = rnd.Next(0, somearray.Length);
    string randomestringfromarray = somearray[randomindex];
return randomestringfromarray;
}