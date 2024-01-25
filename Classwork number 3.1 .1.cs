using System;
using System.Linq;

class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int inputArray, bool PersonGet)
    {
        Create(inputArray, PersonGet);
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

    public void Create(int inputArray, bool PersonGet)
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

    public TwoDimensionalArray(bool personGet,int length,int width)
    {
        Create(personGet, length, width);
    }
    public void Print()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");

            }
            Console.Write("\n");

        }
    }   
    private int[,] PersonGet()
    {
        Console.Write("Введите длину: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Введите ширину: ");
        int width = int.Parse(Console.ReadLine());
        int[,] array = new int[length, width];
        Console.WriteLine("Вводите значения: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return array;
    }
    private int[,] RandomGet()
    {
        Random random = new Random();
        int length = random.Next(2, 10);
        int width = random.Next(2, 10);
        int[,] array = new int[length, width];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                array[i, j] = random.Next(0, 10);
            }
        }
        return array;
    }
    public void Create(bool personGet, int length, int width)
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
   
    public decimal GetAverageValue()
    {
        decimal summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                summa += array[i, j];
            }
        }
        return summa / array.Length;
    }
    public void PrintAsMatrix()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{array[i, j]} ");
                }
                else
                {
                    Console.Write($"{array[i, array.GetLength(1)-j-1]} ");
                }

            }
            Console.Write("\n");
        }


    }

}
class SteppedArray
{
    private int[][] array;
    public SteppedArray(bool getfromperson, int inputArray)
    {
        Create(getfromperson, inputArray);

    }
    private int[][] GetFromPerson(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите количество элементов для {i+1} массива: ");
            array[i] = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < array[i].Length; j++)
            {

            }
        }
    }
    private int[][] GetFromRandom(int[][] array)
    {

    }
    public void Create(bool getfromperson, int inputArray)
    {
        if (getfromperson)
        {
            array = new int[inputArray][];
            GetFromPerson(array);
        }
        else
        {
            Random random = new Random();
            int InputArray = random.Next(2, 10);
            array = new int[InputArray][];
            GetFromRandom(array);
        }
    }
    
}


