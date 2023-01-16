int[] array = {17,2,3,4,52,546,17,81};

int n = array.Length;

int find = 17;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {

        Console.WriteLine(index);
        break;
    }
    index ++;
}