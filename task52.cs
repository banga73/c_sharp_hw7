int[,] RandomTwoIntArray(int UserRows, int UserColomns, int UserMin, int UserMax) //input random integer array
{
	int[,] IntArray = new int[UserRows, UserColomns];
	Random RandTemp = new Random();
	for (int i = 0; i < UserRows; i++)
	{
		for (int j = 0; j < UserColomns; j++)
		{
			IntArray[i, j] = new Random().Next(UserMin, UserMax); 
		}
	}
	return IntArray;
}
		
int[] AvgColArray(int[,] array) //find colomn's average
{
	int[] AvgCol= new int[array.GetLength(1)];
	for (int i = 0; i < array.GetLength(1); i++)
	{
		for (int j = 0; j < array.GetLength(0); j++)
			AvgCol[i] = AvgCol[i] + array[j,i];
		AvgCol[i] = AvgCol[i] / array.GetLength(0);
	}
	return AvgCol;
}
		
void PrintTwoArray(int[,] TwoArray) // print 2-dim array
{
	for (int i = 0; i < TwoArray.GetLength(0); i++)
	{
		for (int j = 0; j < TwoArray.GetLength(1); j++)
			Console.Write($"{TwoArray[i,j]} ");
		Console.WriteLine();
	}
}
void PrintArray(int[] Array) // print 1-dim array
{
	for (int i = 0; i < Array.Length; i++)
	{
		Console.Write($"{Array[i]} ");
	}
}
Console.Write("Input quantity of rows ");
int UserRows = int.Parse(Console.ReadLine());
Console.Write("Input quantity of colomns ");
int UserColomns = int.Parse(Console.ReadLine());
int[,] OurArray = RandomTwoIntArray(UserRows, UserColomns, -1000, 1000);
int[] rez = AvgColArray(OurArray);
PrintTwoArray(OurArray);
Console.WriteLine();
PrintArray(rez);