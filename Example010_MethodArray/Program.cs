/*
*/

int[] array = { 1, 56, 3, 76, 3, 7, 2, 6, 3 };

int n = array.Length;
int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}