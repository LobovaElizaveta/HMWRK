int [] massive = new int [5]; 
for (int i =0; i < massive.Length; i++)
{
   massive[i] = new Random().Next(10000);
}
Console.WriteLine($"[{String.Join(", ", massive)}]");

int sum = 0;
for (int ind = 0; ind < massive.Length; ind++)
{
   if (ind % 2 !=0)
   {
      sum += massive[ind];
   }
}
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {sum}");