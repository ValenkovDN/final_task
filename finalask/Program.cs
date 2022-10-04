/*Написать программу, которая из имеющегося массива строг формируюет массив из строк,
длина которых меньше либо равна 3 символа. Првоначальный массив можно ввети с 
клавиауры, либо задать на старте выполнения алгоритма. При решении не рекомендуюется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

int n = 5;                       // Создали переменную, в которой задаем длину первого массива.
string[] array = new string[n]; //Задаем наш исходный массив, который будем преобразовывать.
string[] massiv = new string[array.Length]; //Создаем второй массив, в котором будут элементы длиной не более 3 символов.
int a = 3;                       // Создали переменную, в которой задаем длину элемента по которой будем преобразовывать массив.   
int j = 0;                       // Создали пременную, для обозначения текущего индекса второго масива.

Vvod(array);                     // Функция заполнения данными первого массива.
Vivod(array);                    // Функця выводящая первый массив на экран.
Transformations(array, massiv);  //Функция выводящаяна экран второй массив после преобразовния первого массива.


void Vvod(string[] ar)
{
    Console.WriteLine($"Заполните массив. Введите {n} элементов(типа текст или символ или число): ");
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = Console.ReadLine();
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

void Vivod(string[] arr)
{
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

void Transformations(string[] arr, string[] arra)
{
    Console.WriteLine("Преобразованный массив, с длиной элементов не более 3 символов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= a)
        {
            massiv[j] = array[i];
            Console.Write($"{massiv[j]} ");
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}