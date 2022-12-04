int sumOfElemets(string s)
{    
    if(s.Contains(' ')){
        Console.WriteLine("Wrong parameter!");
        return 0;
    }    
    
    int result = 0;
    for (int i = 0; i < s.Length; i++) {
        result += int.Parse(s[i].ToString());
    }
    return result;
}


Console.Clear();
Console.WriteLine("Enter number: ");
string? s = Console.ReadLine();
Console.WriteLine($" -->{sumOfElemets(s)}");
