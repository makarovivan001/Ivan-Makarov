using System;
using System.Linq;

class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int inputArray, bool PersonGet)
    {
        if (PersonGet)
        {
            array = GetfromPerson(inputArray);

        }
        else
        {
            array = GetfromRandom(inputArray);
        }
    }

    private int[] GetfromPerson(int inputArray)
    {
        Console.WriteLine("Введите значения массива с клавиатуры");
        int[] array = new int[inputArray];
        for (int i = 0; i < array.Length; i++)
        {
            int value = int.Parse(Console.ReadLine());
            array[i] = value;
        }
        return array;
    }


     private int[] GetfromRandom(int inputArray)
    {
        Random random = new Random();
        int[] array = new int[inputArray];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
        }
        return array;
    }
   
     public void Print(int[] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");

        }
        Console.WriteLine();
    }
    public int GetAverageArrayValue(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
    public int[] DeliteelementsBigger100()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 100 && array[i] > -100)
            {
                count += 1;
            }
        }
        int[] new_arr = new int[count];
        int count_1 = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 100 && array[j] > -100)
            {
                new_arr[count_1] = array[j];
            }
        }
        return new_arr;
    }
    public int[] Delite_whoRepeat()
    {

        int f = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool povtor = false;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    povtor = true;
                    break;
                }
            }
            if (!povtor)
            {
                f++;
            }
        }
        int[] arr_2_new = new int[f];
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool povtor_2 = false;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    povtor_2 = true;
                    break;
                }
            }
            if (povtor_2 == false)
            {
                arr_2_new[ind] = array[i];
                ind++;
            }

        }
        return arr_2_new;
        

    }
}
class TwoDimensionalArray
{
    private int[,] array;

    public TwoDimensionalArray(bool personGet)
    {
        if (personGet)
        {
            array = PersonGet();

        }
        else
        {
            array = RandomGet();
        }
    }
    private int [,] PersonGet()
    {
        Console.Write("Введите длину: ");
        string lenght_ = Console.ReadLine();
        int lenght = 
    }
}



