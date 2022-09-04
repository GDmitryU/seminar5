// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void EvenNum (int Number)
{
  
    void FillArray(int [] Mass)
    {
        int length = Mass.Length;
        int index = 0;
        while (index < length)

        {
            Mass[index] = new Random().Next(100, 1000);

            index++;
        }
    }
    void PrintArray (int[] arr)
    {
        int cnt = 0;
        int length = arr.Length;
        while (cnt < length)
        {
            Console.Write ($"{arr[cnt]} ");
            cnt = cnt +1;
        }
    }
    void Processing (int[] array)
    {
        int count = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if(array[i]%2 == 0)
            {
                count+=1;
            }
        }
        Console.WriteLine ($"Количество четных элементов массива = {count} ");    
    }
    int[] array = new int[Number];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine();
    Processing (array);

    

}
Console.Write("Введите число элементов массива: ");
int Number = int.Parse(Console.ReadLine());
EvenNum (Number);
