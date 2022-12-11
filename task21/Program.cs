Console.Clear();

double[] PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];

    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1*result[0] + b1;

    return result;
}


Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] point = new double[2];
if (k1 != k2){
   point = PointOfIntersection(b1, k1, b2, k2);
   Console.WriteLine($"Point of intersection: ({point[0]}; {point[1]})");
}
else Console.WriteLine($"No intersection point");