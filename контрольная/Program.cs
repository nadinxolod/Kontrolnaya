Console.WriteLine("введите колличесто элементов");
 int Length = Convert.ToInt32(Console.ReadLine());
 string [] array = new string [Length];
    int index = 0;     
    int count = 0;                    
Console.WriteLine("введите элементы массива");            
for (int i = 0; i < array.Length; i++)
{
    array [i] = Console.ReadLine();
    
     if (array[i].Length<=3)
   {
      count++;               
   }
}
Console.WriteLine($"массив [" + string.Join(", ", array) + "]");

 string [] array1 = new string [count];

for (int i = 0; i < array.Length; i++)
{
   if (array[i].Length<=3)
   {
    array1[index]=array[i];                           
    index++;
   }
}

Console.WriteLine($"итоговый массив [" + string.Join(", ", array1) + "]");