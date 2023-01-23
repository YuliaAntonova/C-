/* Имеется одномерный массив array из n элементов, 
заполняемый рандомными числами.
требуется найти элемент массива, равный find с помощью метода*/
int[] array = new int[10]; 
FillArray(array); 
array[4] = 4; // принудительно добавляем 4 на 4 и 6 позиции в массиве
array[6] = 4;
PrintArray(array);  
void FillArray(int[] collection) 
{
    int length = collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) 
{
    int count = col.Length; 
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine(col[position]); 
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
       if(collection[index] == find)
       {
           position = index;
           break;
       }
        index++;
    }
    return position;
}
Console.WriteLine();
int pos = IndexOf(array, 41);
Console.WriteLine(pos);