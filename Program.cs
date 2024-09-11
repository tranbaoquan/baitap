//Tran Bao Quan - 21810310025
using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();

        // Gọi phương thức đoán số ngẫu nhiên
        program.GuessRandomNumber();

        // Gọi phương thức tìm phần tử lớn nhất trong mảng
        program.FindMaxElementInArray();
    }

    // Phương thức đoán số ngẫu nhiên từ 1 đến 6
    public void GuessRandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 7); // Số ngẫu nhiên từ 1 đến 6

        Console.Write("Nhap vao so ban doan (tu 1 den 6): ");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == randomNumber)
        {
            Console.WriteLine("Chuc mung! Ban da doan dung!");
        }
        else
        {
            Console.WriteLine($"Ban da thua! So cua toi la {randomNumber}");
        }
    }

    // Phương thức tìm phần tử lớn nhất trong mảng
    public void FindMaxElementInArray()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }

        Console.WriteLine($"Phan tu lon nhat trong mang la: {maxElement}");
    }
}
