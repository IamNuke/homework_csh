Console.Clear();

Console.WriteLine("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++){
    array[i] = rnd.Next(1, 101);
}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Enter number of positions: ");
int k = Convert.ToInt32(Console.ReadLine());
int first = array[0], last = array[n - 1];

for (int i = 0; i < Math.Abs(k); i++){
    if (k > 0){
        for (int j = n - 1; j > 0; j--){
            array[j] = array[j - 1];
        }
        array[0] = last;
        last = array[n - 1];
    }
    else{
        for (int j = 0; j < array.Length-1; j++){
            array[j] = array[j + 1];
        }
        array[n-1] = first;
        first = array[0];
    }

}

Console.WriteLine($"[{string.Join(", ", array)}]");