int [] massive = new int [20];
for ( int i = 0; i < massive.Length; i++)
{
   massive[i] = new Random().Next(100, 1000);
} 
Console.WriteLine($"[{String.Join(", ", massive)}]");
int count =0;
foreach( int el in massive)
{
   if(el%2 ==0)
   {
      count++;
   }
}
Console.WriteLine($"Количество четных чисел {count}");