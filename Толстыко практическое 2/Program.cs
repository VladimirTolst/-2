int temp=0;
Console.Write("Ширина ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Длина ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n,m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == 0 | j == 0)
        {
            arr[i,j] = 1;
        }
        if (arr[i, j] != 1)
        {
            temp += arr[i-1,j];
            temp += arr[i,j-1];
            arr[i,j] = temp;
            temp= 0;
        }  
    }
}
Console.Write("Кол-во путей: " + arr[n-1, m-1]);
