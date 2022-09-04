// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void Difference (int Number)
{
  
    void FillArray(double [] Mass)
    {
        int length = Mass.Length;
        int index = 0;
        while (index < length)

        {
            Random rand = new Random();
            float randomFloat = (float)rand.NextDouble();
            Mass[index] = Math.Round((rand.NextDouble() * 22),2);

            index++;
        }
    }
    void PrintArray (double[] arr)
    {
        int cnt = 0;
        int length = arr.Length;
        while (cnt < length)
        {
            Console.Write ($"{arr[cnt]} ");
            cnt = cnt +1;
        }
    }
    void Processing (double[] array)
    {
        double MinNum = 1000;
        double MaxNum =-1000;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if(array[i] < MinNum)
            {
                MinNum = array[i];
            }
            if(array[i] > MaxNum)
            {
                MaxNum = array[i];
            }
        }
        double Diff = MaxNum - MinNum;
        Console.WriteLine ($"Разница минимального и максимального элементов = {Diff} ");    
    }
    double [] array = new double[Number];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine();
    Processing (array);

    

}
Console.Write("Введите число элементов массива: ");
int Number = int.Parse(Console.ReadLine());
Difference (Number);

