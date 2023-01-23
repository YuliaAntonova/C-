/* Имеется одномерный массив array из n элементов, 
который заполняется рандомными числами*/
int[] array = new int[10]; // создание массива из 10 элементов, по умолчанию заполнен нулями
FillArray(array); // заполнение массива
PrintArray(array);  // печать массива
void FillArray(int[] collection) // метод заполнения массива,collection - название аргумента
{
    int length = collection.Length; // получить длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // диапозон значений массива
        index++;
    }
}
void PrintArray(int[] col) // метод печати массива на экран
{
    int count = col.Length; // обозначение количества элементов
    int position = 0; // текущий номер позиции
    while (position < count)
    {
        Console.WriteLine(col[position]); // значение текущего элемента
        position++;
    }
}
