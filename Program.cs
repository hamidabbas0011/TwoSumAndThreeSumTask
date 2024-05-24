namespace TwoSumTask
{
    internal class Program
    {
        static bool pairSumTwo(int[] arr, int sum)
        {
            Array.Sort(arr); // Sort the array in non-decreasing order
            int left = 0;
            int right = arr.Length - 1; //last element of array

            while (left < right)
            {
                int currentSum = arr[left] + arr[right];
                if (currentSum == sum)
                {
                    Console.WriteLine($"Found these elments for two sums: {arr[left]}, {arr[right]}");
                    return true;
                }
                else if (currentSum < sum)
                    left++;
                else
                    right--;
            }

            return false;
        }

        static bool HasZeroSumTriplet(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine($"Found: {arr[i]}, {arr[j]}, {arr[k]}");
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        static void Main(string[] args)
        {

            int[] arr = [-7, -3, 4, 6, 10, 15,7];
            int targetSum = 0;

            if (pairSumTwo(arr, targetSum))
                Console.WriteLine("Yes, there exists a pair with sum 0.");
            else
                Console.WriteLine("No, there is no such pair.");

            if (HasZeroSumTriplet(arr))
            {
                Console.WriteLine("Task Complete");
            }
            else
            {
                Console.WriteLine("No such triplet found.");
            }

        }
    }
}
