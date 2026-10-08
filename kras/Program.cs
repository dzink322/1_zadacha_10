using System;

internal class Program
{
    static void Main(string[] args)
    {
        Employee data = new Employee();
        data.fio = "Иванов";//имя
        data.zar = 63500; //зарплата
        data.Show(); //
        int vgod = data.zarvgod();
        Console.WriteLine($"Годовая зарплата: {vgod}");
        Console.ReadKey(); 
    }
}

class Employee
{
    public string fio;
    public int zar;
    public void Show()
    {
        Console.WriteLine($"Сотрудник: {fio}");
        Console.WriteLine($"Ежемесячная зарплата: {zar}");
    }
    public int zarvgod()
    {
        return zar * 12;
    }
}
