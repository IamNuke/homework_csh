//Console.Clear();

string Swap(string str, int i, int j)
{
    var charArray = str.ToCharArray();
    char temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    return new String(charArray);
}

void Reshuffle(string str, int k, int length)
{
    if (k == length)
    {
        Console.WriteLine($"{str}");
        return;
    }    
    for (int i = k; i <= length; i++)
    {
        str = Swap(str, k, i);
        Reshuffle(str, k + 1, length);      
    }
}


Console.WriteLine("Enter text: ");
string? text = Console.ReadLine();
Console.WriteLine($"Reshuffle");
Reshuffle(text, 0, text.Length - 1);
