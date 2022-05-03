namespace SecondMaxArrayNumber
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите размер массива: ");
                int size = int.Parse(Console.ReadLine());
                int[] array = new int[size];


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Введите значение элемента массива {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }



                Console.WriteLine("Массив:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }



                int maxValue = 0;
                int secondMaxValue = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > maxValue)
                    {
                        secondMaxValue = maxValue;
                        maxValue = array[i];
                    }
                    else secondMaxValue = array[i];
                }


                Console.WriteLine($"Второй наибольший элемент: {secondMaxValue}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Вводить можно только цифры");
            }

            /* Второй способ
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine($"Вызываем второй наибольший элемент обратившись к ячейке {array[1]}");
            */
        }
    }
}