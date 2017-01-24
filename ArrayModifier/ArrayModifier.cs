using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] operand = input.Split();
                if (operand[0]=="swap")
                {
                    SwapArray(arr, operand[1], operand[2]);
                }
                else if (operand[0] == "multiply")
                {
                    MultiplyArray(arr, operand[1], operand[2]);
                }
                else if (operand[0] == "decrease")
                {
                    DecreaseArray(arr);
                }                
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DecreaseArray(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - 1;
            }
        }

        private static void MultiplyArray(long[] arr, string v1, string v2)
        {
            long index1 = long.Parse(v1);
            long index2 = long.Parse(v2);
            arr[index1] = arr[index1] * arr[index2];

        }

        private static void SwapArray(long[] arr, string v1, string v2)
        {
            int index1 = int.Parse(v1);
            int index2 = int.Parse(v2);
            long temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
