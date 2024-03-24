using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số lượng phần tử của mảng:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Nhập các phần tử của mảng:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập giá trị cho phần tử thứ {i + 1}:");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Nhập giá trị cần chèn:");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập vị trí cần chèn:");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position <= n)
        {
            // Tạo một mảng mới lớn hơn một phần tử so với mảng ban đầu
            int[] newArray = new int[n + 1];

            // Sao chép các giá trị từ mảng ban đầu vào mảng mới
            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }

            // Chèn giá trị vào vị trí được chỉ định trong mảng mới
            newArray[position] = value;

            // Sao chép các giá trị từ vị trí sau vị trí chèn từ mảng ban đầu vào mảng mới
            for (int i = position + 1; i < n + 1; i++)
            {
                newArray[i] = array[i - 1];
            }

            Console.WriteLine("Mảng mới sau khi chèn giá trị là:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Vị trí chèn không hợp lệ");
        }
    }
}