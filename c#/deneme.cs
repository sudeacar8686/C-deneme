using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seçiminizi yapın:");
        Console.WriteLine("1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
        Console.WriteLine("2: Gün İsmi Belirleme");
        Console.WriteLine("3: Basit Hesap Makinesi");
        Console.WriteLine("4: Üç Sayının En Büyüğünü Bulma");
        Console.WriteLine("5: Şifre Güçlülüğünü Kontrol Etme");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CheckNumber();
                break;
            case 2:
                GetDayName();
                break;
            case 3:
                SimpleCalculator();
                break;
            case 4:
                FindMaxNumber();
                break;
            case 5:
                CheckPasswordStrength();
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                break;
        }
    }

    // 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
    static void CheckNumber()
    {
        Console.Write("Bir sayı girin: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Sayı pozitiftir.");
        else if (num < 0)
            Console.WriteLine("Sayı negatiftir.");
        else
            Console.WriteLine("Sayı sıfırdır.");
    }

    // 2: Gün İsmi Belirleme (switch-case)
    static void GetDayName()
    {
        Console.Write("1 ile 7 arasında bir sayı girin: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz giriş!");
                break;
        }
    }

    // 3: Basit Hesap Makinesi (switch-case)
    static void SimpleCalculator()
    {
        Console.Write("İlk sayıyı girin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlem seçin (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"Sonuç: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Sonuç: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Sonuç: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Sonuç: {num1 / num2}");
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
                break;
            default:
                Console.WriteLine("Geçersiz işlem!");
                break;
        }
    }

    // 4: Üç Sayının En Büyüğünü Bulma (if-else)
    static void FindMaxNumber()
    {
        Console.Write("Birinci sayıyı girin: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = num1;

        if (num2 > max)
            max = num2;
        if (num3 > max)
            max = num3;

        Console.WriteLine($"En büyük sayı: {max}");
    }

    // 5: Şifre Güçlülüğünü Kontrol Etme (if-else)
    static void CheckPasswordStrength()
    {
        Console.Write("Şifrenizi girin: ");
        string password = Console.ReadLine();

        if (password.Length < 8)
        {
            Console.WriteLine("Şifre en az 8 karakter olmalıdır!");
            return;
        }

        if (!Regex.IsMatch(password, "[A-Z]"))
        {
            Console.WriteLine("Şifre en az bir büyük harf içermelidir!");
            return;
        }

        if (!Regex.IsMatch(password, "[@#$%]"))
        {
            Console.WriteLine("Şifre en az bir özel karakter (@, #, $, %) içermelidir!");
            return;
        }

        Console.WriteLine("Şifre güçlü!");
    }
}