using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTargetedCell
{
    class MultiplyTargetedCell
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];

            var matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = inputRow[j];
                }
            }
            int[] target = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        
            CalcTarget(matrix, target);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void CalcTarget(int[,] matrix, int[] target)
        {
            Point start = new Point();
            Point end = new Point();
            if (target[0] > 0 && target[0] < matrix.GetUpperBound(0) && target[1] > 0 && target[1] < matrix.GetUpperBound(1))
            {
                start.X = target[0] - 1;
                start.Y = target[1] - 1;
                end.X = target[0] + 1;
                end.Y = target[1] + 1;
            }
            else
            {
                Console.WriteLine("Ïncorrect data");
            }
            int sum = 0; int targetData = matrix[target[0], target[1]];
            for (int i = start.X; i <= end.X; i++)
            {
                for (int j = start.Y; j <= end.Y; j++)
                {
                    if (i == target[0] && j==target[1])
                    {
                        continue;
                    }
                    sum += matrix[i, j];
                    matrix[i, j] = matrix[i, j] * targetData;
                }
            }
            int result = sum * matrix[target[0], target[1]];
            matrix[target[0], target[1]] = result;

        }

        class Point
        {
            public int X {get;set;}
            public int Y { get; set; }
            public Point()
            {

            }
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

        }
    }
}
