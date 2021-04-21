using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i, se = 0, sod = 0;
		int[] arr = new int[5];

		Console.Write("Enter five numbers:");

		for (i = 0; i < arr.Length; i++)
		{
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}

		for (i = 0; i < 5; i++)
		{
			if (arr[i] % 2 == 0)
			{
				se = se + arr[i];
			}
			else
			{
				sod = sod + arr[i];
			}
		}
		Console.WriteLine("Sum of even list is:" + se);
		Console.WriteLine("Sum of odd list is:" + sod);

        }
    }
}
