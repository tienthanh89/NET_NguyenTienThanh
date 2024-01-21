namespace BaiTap3_NguyenTienThanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bai2();
        }

        static void bai1()
        {
            Console.Write("Moi nhap so nguyen can kiem tra: ");
            int soNguyen = int.Parse(Console.ReadLine());
            Console.WriteLine(soNguyen % 3 == 0 ? "so nguyen chia het cho 3." : "so nguyen khong chia het cho 3");
        }

        static void bai2()
        {
            Console.Write("Moi nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();

            }
        }

        static void bai3()
        {
            int sum = 0;            
            Console.Write("Moi nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i<= n; i++)
            {
                int giaiThua = 1;

                for (int j = 1;j<= i; j++)
                {                  
                    giaiThua *= j;
                }

                sum += giaiThua;
            }

            Console.WriteLine($"Tong giai thua tu 1 den n la: {sum}");
        }

        
    }    
}
