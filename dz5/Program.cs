Console.WriteLine("Введите размер массива");
int sizearray = int.Parse(Console.ReadLine());
int[] array = arraystart(sizearray, 100, 999);
Console.WriteLine($"{string.Join(", ", array)}-> {chet(array)}");


int[] arraystart(int size, int LeftRange, int RightRange){
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return res;
}

int chet(int[] massive){
    int count = 0;
    foreach (int i in massive){
        if (i % 2 == 0) count++;
    }
    return count;
}

