namespace Array
{
    internal class Program
    {

        static void Average()
        {
            int [] num = { 87, 65, 74, 90, 83, 100 };
            float avg = 0;
            for (int i = 0; i < num.Length; i++)
            {
                avg = avg + num[i];
            }
            System.Console.WriteLine("The Average is " + avg/num.Length);

        }

        static void MaxMin()
        {
            int[] num = { 43, 62, 53, 79, 22, 93, 37 };
            int max = num[0]; 
            int min = num[0];
            for(int i  = 1; i < num.Length;i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }

            }
            System.Console.WriteLine("The maximum = " + max);
            System.Console.WriteLine("The minimum = " + min);

        }

        static void evenOdd()
        {
            int[] num = { 43, 62, 53, 79, 22, 93, 37 };
            int even = 0; 
            int odd = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            System.Console.WriteLine("The number of even: " + even);
            System.Console.WriteLine("The number of odd: " + odd);

        }

        static void secondLargest()
        {
            int[] num = { 43, 62, 53, 79, 22, 93, 37 };
            int largest = 0;
            int second = 0;
            foreach (int number in num)
            {
                if (number > largest)
                {
                    second = largest;
                    largest = number;
                }
                else if (number > second && number < largest)
                {
                    second = number;
                }
            }

            System.Console.WriteLine("The second largest number = " + second);
        }
        static void Main(string[] args)
        {
            Average();
            MaxMin();
            evenOdd();
            secondLargest();
            //int[] a = new int[5];
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;
            //a[3] = 4;
            //a[4] = 5;
            ///////////////////////////
            //int[] a = { 1, 2, 3 };
            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            ////////////////////////////
            //int[] a = { 1, 3, 5, 7, 9, 11 };
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum = sum + a[i];
            //}
            //Console.WriteLine(sum);


        }
    }
}