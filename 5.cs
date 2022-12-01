int [] massive = {1, 5, 7, 4, 2};
if (massive.Length%2==0)
{
    NewMass1(massive);
}
else
{
    NewMass(massive);
}


void NewMass(int [] array)
{
    int [] arr = new int [array.Length/2+1];
    int a =0;
    int i =0;
    int l = array.Length-1;
    while(i<l)
    {
        arr[a] = array[i]*array[l];
        a++;
        i++;
        l--;
    }
    if (array.Length%2>0)
    {
        arr[a]=array[array.Length/2];
    }

    Console.WriteLine($"Новый массив: [{String.Join(", ", arr)}]");
}

void NewMass1(int [] array)
{
    int [] arr = new int [array.Length/2];
    int a =0;
    int i =0;
    int l = array.Length-1;
    while(i<l)
    {
        arr[a] = array[i]*array[l];
        a++;
        i++;
        l--;
    }
   
       

    Console.WriteLine($"Новый массив: [{String.Join(", ", arr)}]");
}