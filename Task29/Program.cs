// Программа, которая задает массив из 8-ми элементов и выводит их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 8);
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

int[] array = new int[8];

FillArray(array);

array[1] = 1;
array[2] = 2;
array[3] = 5;
array[4] = 7;
array[5] =19;
array[6] = 6;
array[7] = 1;
array[8] = 33;


PrintArray(array);
