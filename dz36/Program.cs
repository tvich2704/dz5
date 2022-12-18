Console.WriteLine("Введите размер массива");
int sizearray = int.Parse(Console.ReadLine());
int[] array = arraystart(sizearray, -25, 25);
Console.WriteLine($"{string.Join(", ", array)}-> {answer(array)}");


int[] arraystart(int size, int LeftRange, int RightRange){
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return res;
}

int answer(int[] arrayVhod){
    int count = 0;
    if (arrayVhod.Length == 1) return count;
    for (int i = 0; i < arrayVhod.Length; i++){
        if (i % 2 == 1){
            count += arrayVhod[i];
        }
    }
    return count;
}