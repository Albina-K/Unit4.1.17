using System;

class Program
{

    static string ShowColor(string username, int userage)
    {
        Console.WriteLine("{0}, {1}, \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }

    public static void Main(string[] args)
    {

        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        var favcolor = new string[3];
        for (int i = 0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor(name, age);

        }
        Console.WriteLine("Ваши любимые цвета");
        foreach (var color in favcolor)
        {
            Console.WriteLine(color);
        }


    }


    static string GetDataFromConsol()
    {
        return Console.ReadLine();
    }


    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
        
    }
    static int[] SortArray(int[] result)

    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
            
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        return result;
    }
    static void ShowColors(string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    static void ShowColors2(params string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }
    static void Sort(string[] args) 
    {
        var array = GetArrayFromConsole();
        var sortedarray = SortArray(array);
    }
    static void ShowArray(int[] array, bool IsSort = false )
    { 
        var temp = array;
           if (IsSort) 
        {
            temp = SortArray(array);
                }
           foreach (var item in temp) 
        { 
            Console.WriteLine(item);
        }

    }
    static void Mass()
    {
        var array = GetArrayFromConsole(10);
        ShowArray(array, true);
    }

    static void GetName(string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }
}

