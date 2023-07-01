double[,] RandomTwoArray(int UserRows, int UserColomns, int Min, int Max)
{
	double[,] IntArray = new double[UserRows, UserColomns];
	Random RandTemp = new Random();
	for (int i = 0; i < UserRows; i++)
	{
		for (int j = 0; j < UserColomns; j++)
		{
			IntArray[i, j] = Math.Round(RandTemp.Next(Min, Max) + RandTemp.NextDouble(), 2); 
		}
	}
	return IntArray;
}
Console.Write("Input X and Y of element with a space between ");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);		
int UserX = int.Parse(st[0]);
int UserY = int.Parse(st[1]);
Console.Write("Input quantity of rows ");
int UserRows = int.Parse(Console.ReadLine());
Console.Write("Input quantity of colomns ");
int UserColomns = int.Parse(Console.ReadLine());
double[,] OurArray = RandomTwoArray(UserRows, UserColomns, -1000, 1000);
if (UserX <= OurArray.GetLength(0) && UserY <= OurArray.GetLength(1))
	Console.Write($"Element is {OurArray[UserX, UserY]}");
else Console.Write("There is no such element");	