namespace BaiTap5_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Mời nhập số phần tử n trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Mời nhập phần tử thứ {0} của mảng: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            /*bai1(arr);*/
            /*bai2(arr);*/
            bai3(arr);
        }

        static void bai1(int[] inputArr)
        {
            Console.Write("Mảng đã nhập là: ");
            foreach(var item in inputArr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.Write("Mảng đảo ngược của mảng đã nhập là: ");
            foreach(var item in inputArr.Reverse())
            {
                Console.Write($"{item}\t");
            }
        }

        static void bai2(int[] inputArr)
        {
            int sum = 0;
            foreach(var item in inputArr)
            {
                if(item%2 ==1)
                {
                    sum += item;
                }
            }

            Console.WriteLine($"Tổng các số lẻ trong mảng là: {sum}");
        }

        static void bai3(int[] inputArr)
        {
            int count = 0;
            Console.Write("Mời nhập số muốn kiểm tra: ");
            int input = int.Parse(Console.ReadLine());
            foreach(var item in inputArr)
            {
                if (item == input)
                {
                    count++;
                }
            }
            Console.WriteLine($"Số lần xuất hiện của số {input} là: {count} lần");
        }
    }

}
