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
void PrintTwoArray(double[,] TwoArray)
{
	for (int i = 0; i < TwoArray.GetLength(0); i++)
	{
		for (int j = 0; j < TwoArray.GetLength(1); j++)
			Console.Write($"{TwoArray[i,j]} ");
		Console.WriteLine();
	}
}
Console.Write("Input quantity of rows ");
int UserRows = int.Parse(Console.ReadLine());
Console.Write("Input quantity of colomns ");
int UserColomns = int.Parse(Console.ReadLine());
double[,] OurArray = RandomTwoArray(UserRows, UserColomns, -1000, 1000);
PrintTwoArray(OurArray);