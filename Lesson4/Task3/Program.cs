string CetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = CetLettersFromString(str);
Console.WriteLine(result);