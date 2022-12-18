
Console.WriteLine("Введите размер массива");
int sizearray = int.Parse(Console.ReadLine());
double[] array = arraystart(sizearray, 1.0, 25.0);
Console.WriteLine($"{string.Join(", ", array)}->{answer(array)}");

double[] arraystart(int size, double LeftRange, double RightRange){
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (RightRange - LeftRange) + LeftRange;
    }
    return res;
}

double answer(double[] arrayvhod){
    double maxx = arrayvhod[0];
    double minn = arrayvhod[0];
    for (int i = 1; i < arrayvhod.Length; i++)
    {
        if (arrayvhod[i] > maxx)
        {
            maxx = arrayvhod[i];
        }
        if (arrayvhod[i] < minn)
        {
            minn = arrayvhod[i];
        }
    }
    return maxx - minn;
}