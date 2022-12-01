int [] massive = new int [10];
for ( int i = 0; i < massive.Length; i++)
{
   massive[i] = new Random().Next(-10, 11);
} 
Console.WriteLine($"[{String.Join(", ", massive)}]");

int min = 0;
int max = 0;
for (int i =0; i<massive.Length; i++)
{
    if (min > massive[i])
    {
        min = massive[i];
    }
    else
    {
        if (max< massive[i])
        {
            max = massive[i];
        }
    }
}
int d = max - min;
Console.WriteLine($"Разница между максмальным и минимальным элементом равна: {d}");