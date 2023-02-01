/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
void InputArray(int[] array) 
{   
    for (int i = 0; i < array.Length; i++)     
array[i] = new Random().Next(-100, 100); 
}

int OutputArray(int[] array) {     
    int count = 0;     
    foreach(int element in array)     
    {       
        if (element > 0)         
        count++;      
    }    
return count; } 

Console.Write("Введите кол-во элементов: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[m]; 
InputArray(array); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Результат: {OutputArray(array)}");