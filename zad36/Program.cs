// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void OddElem (int Number)
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
        int sum = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if(i % 2 == 0)
            {
                sum += array[i];
            }
        }
        Console.WriteLine ($"Сумма элементов на нечетных местах = {sum} ");    
    }
    int[] array = new int[Number];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine();
    Processing (array);

    

}
Console.Write("Введите число элементов массива: ");
int Number = int.Parse(Console.ReadLine());
OddElem (Number);

