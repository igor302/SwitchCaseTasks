using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                try
                {
                    Console.WriteLine("0. Exit ");
                    Console.WriteLine("1. Task7_1 - Вывод названия дня недели");
                    Console.WriteLine("2. Task7_2 Вывод строки-описания оценки");
                    Console.WriteLine("3. Task7_3 Вывод названия времени года");
                    Console.WriteLine("4. Task7_4 - Определить колиство дней в месяце");
                    Console.WriteLine("5. Task7_5 - Выбор арифметического действия и выполение этого действия над числами А и В");
                    Console.WriteLine("6. Task7_18 - Вывод строки-описания введенного числа");
                    Console.WriteLine("7. GetBodyMass - Конвертер массы тела из разных величин в КГ");
                    Console.WriteLine("8. GetCardName - Вывод названия карты");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 0: return;
                        case 1: Task7_1(ValidationForTask7_1()); break;
                        case 2: Task7_2(); break;
                        case 3: Task7_3(); break;
                        case 4: Task7_4(); break;
                        case 5: Task7_5(); break;
                        case 6: Task7_18(); break;
                        case 7: ValidationForGetBodyMassInKG(); break;
                        case 8: ValidationForGetCardName(); break;
                        default: throw new FormatException("Сделайте правильный выбор!");
                    }
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
        #region Task7_1 Вывод названия дня недели
        static string Task7_1(int numberOfDay)
        {
            string nameOfTheDay = "";
            switch (numberOfDay)
            {
                case 1: nameOfTheDay += "Понедельник"; break;
                case 2: nameOfTheDay += "Вторник"; break;
                case 3: nameOfTheDay += "Среда"; break;
                case 4: nameOfTheDay += "Четверг"; break;
                case 5: nameOfTheDay += "Пятница"; break;
                case 6: nameOfTheDay += "Субботу"; break;
                case 7: nameOfTheDay += "Воскресенье"; break;
                default: nameOfTheDay += "Это не день недели!"; break;
            }
            Console.WriteLine(nameOfTheDay);
            return nameOfTheDay;
        }
        static int ValidationForTask7_1()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите номер дня, 1 - Понедельник --- 7 - Воскресенье");
                    int numberOfDay = int.Parse(Console.ReadLine());
                    if (numberOfDay <= 0 || numberOfDay >= 8) throw new ArgumentException("Введите номер дня от 1-7!");
                    return numberOfDay;
                }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_2 Вывод строки-описания оценки
        static string GetNameOfGrade(int K)
        {
            string result = "";
            switch (K)
            {
                case 1: result += "Плохо"; break;
                case 2: result += "Неудовлетворительно"; break;
                case 3: result += "Удовлетворительно"; break;
                case 4: result += "Хорошо"; break;
                case 5: result += "Отлично"; break;
            }
            return result;
        }
        static void Task7_2()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите оценку, от 1 до 5 ");
                    int K = int.Parse(Console.ReadLine());
                    if (K <= 0 || K >= 6) throw new ArgumentException("Введите число в диапазоне от 1 до 5!");
                    Console.WriteLine(GetNameOfGrade(K));
                    break;
                }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_3 Вывод названия времени года
        static string GetNamePeriodOfYear(int numberOfMonth)
        {
            string result = "";
            switch (numberOfMonth)
            {
                case 12:
                case 1:
                case 2: result += "Зима"; break;
                case 3:
                case 4:
                case 5: result += "Весна"; break;
                case 6:
                case 7:
                case 8: result += "Лето"; break;
                case 9:
                case 10:
                case 11: result += "Осень"; break;
            }
            return result;
        }
        static void Task7_3()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Выбирите номер месяца - \n1. Январь\n2. Февраль\n3. Март\n4. Апрель\n5. Май\n6. Июнь\n7. Июль\n8. Август\n9. Сентябрь\n10. Октябрь\n11. Ноябрь\n11. Декабрь");
                    int numberOfMonth = int.Parse(Console.ReadLine());
                    if (numberOfMonth <= 0 || numberOfMonth >= 13) throw new ArgumentException("Введите число в диапазоне от 1 до 12!");
                    Console.WriteLine(GetNamePeriodOfYear(numberOfMonth));
                    break;
                }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_4 Определить колиство дней в месяце
        static string GetNumberOfDaysInMonth(int numberOfMonth)
        {
            string numberOfDaysInMonth = "";
            switch (numberOfMonth)
            {
                case 1: numberOfDaysInMonth += "Январь - 31 день"; break;
                case 2: numberOfDaysInMonth += "Февраль - 28 дней"; break;
                case 3: numberOfDaysInMonth += "Март - 31 день"; break;
                case 4: numberOfDaysInMonth += "Апрель - 30 дней"; break;
                case 5: numberOfDaysInMonth += "Май - 31 день"; break;
                case 6: numberOfDaysInMonth += "Июнь - 30 дней"; break;
                case 7: numberOfDaysInMonth += "Июль - 31 день"; break;
                case 8: numberOfDaysInMonth += "Август - 31 день"; break;
                case 9: numberOfDaysInMonth += "Сентябрь - 30 дней"; break;
                case 10: numberOfDaysInMonth += "Октябрь - 31 день"; break;
                case 11: numberOfDaysInMonth += "Ноябрь - 30 дней"; break;
                case 12: numberOfDaysInMonth += "Декабрь - 31 день"; break;
            }
            return numberOfDaysInMonth;
        }
        static void Task7_4()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите номер месяца, 1 - Январь --- 12 - Декабрь");
                    int numberOfMonth = int.Parse(Console.ReadLine());
                    if (numberOfMonth <= 0 || numberOfMonth >= 13) throw new FormatException("Введите число от 1 до 12!");
                    Console.WriteLine(GetNumberOfDaysInMonth(numberOfMonth));
                    break;
                }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_5 Выбор арифметического действия и выполение этого действия над числами А и В
        static float Calc(float A, float B, int Choise)
        {
            float result = 0;
            switch (Choise)
            {
                case 1: result += A + B; break;
                case 2: result += A - B; break;
                case 3: result += A * B; break;
                case 4:
                    {
                        if (B == 0) Console.WriteLine("На 0 делить нельзя!");
                        else result += A / B; break;
                    }
                default: throw new ArgumentException();
            }
            return result;
        }
        static void Task7_5()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите число A ");
                    float A = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число B ");
                    float B = float.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите действие над числами: \n1. Сложение\n2. Вычетание\n3. Умножение\n4. Деление");
                    int Choise = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат - " + Calc(A, B, Choise));
                    break;
                }
                catch (OverflowException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_7 Конвертер массы тела из разных величин в КГ
        static double GetBodyMassInKG(double weight, int choise)
        {
            double result = 0;
            switch (choise)
            {
                case 1: result += weight; break;
                case 2: result += weight / 1000000; break;
                case 3: result += weight / 1000; break;
                case 4: result += weight * 1000; break;
                case 5: result += weight * 100; break;
            }
            return result;
        }
        static void ValidationForGetBodyMassInKG()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите массу ");
                    double weight = double.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Выбирите единицы массы :\n1. Киллограм\n2. Миллиграм\n3. Грамм\n4. Тонна\n5. Центнер");
                            int choise = int.Parse(Console.ReadLine());
                            if (choise <= 0 || choise >= 6) throw new ArgumentException("Введите число в диапазоне от 1 до 5!");
                            Console.WriteLine(GetBodyMassInKG(weight, choise) + " Кг");
                            break;
                        }
                        catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                        catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                    }
                    break;
                }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_15 Вывод названия карты
        static string GetCardName(int n, int m)
        {
            string result = "";
            switch (n)
            {
                case 6: result += "Шесть "; break;
                case 7: result += "Семь "; break;
                case 8: result += "Восемь "; break;
                case 9: result += "Девять "; break;
                case 10: result += "Десять "; break;
                case 11: result += "Валет "; break;
                case 12: result += "Дама "; break;
                case 13: result += "Король "; break;
                case 14: result += "Туз "; break;
            }
            switch (m)
            {
                case 1: result += "пик"; break;
                case 2: result += "треф"; break;
                case 3: result += "бубей"; break;
                case 4: result += "червей"; break;
            }
            return result;
        }
        static void ValidationForGetCardName()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите достоинство карты от 6 до 14 ");
                    int n = int.Parse(Console.ReadLine());
                    if (n <= 5 || n >= 15) throw new ArgumentException("Введите число в дипазоне от 6 до 14!");
                    while (true)
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Введите масть карты: \n1. Пики\n2. Трефи\n3. Бубна\n4. Черви");
                            int m = int.Parse(Console.ReadLine());
                            if (m <= 0 || m >= 5) throw new ArgumentException("Введите число в дипазоне от 1 до 4!");
                            Console.WriteLine(GetCardName(n, m));
                            break;
                        }
                        catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                        catch (OverflowException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                        catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                    }
                    break;
                }
                catch (ArgumentException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (FormatException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
                catch (OverflowException ex) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        #region Task7_18 Вывод строки-описания введенного числа
        static string GetNameOfTheNumber(int x)
        {
            string result = "";
            switch (x / 100)
            {
                case 1: result += "Сто "; break;
                case 2: result += "Двести "; break;
                case 3: result += "Триста "; break;
                case 4: result += "Чотириста "; break;
                case 5: result += "Пятьсот "; break;
                case 6: result += "Шестьсот "; break;
                case 7: result += "Семьсот "; break;
                case 8: result += "Восемьсот "; break;
                case 9: result += "Девятьсот "; break;
            }
            switch ((x / 10) % 10)
            {
                case 1:
                    {
                        switch (x % 10)
                        {
                            case 0: result += "десять "; break;
                            case 1: result += "одиннадцать "; break;
                            case 2: result += "двенадцать "; break;
                            case 3: result += "тринадцать "; break;
                            case 4: result += "чотирнадцать "; break;
                            case 5: result += "пятнадцать "; break;
                            case 6: result += "шестьнадцать "; break;
                            case 7: result += "семьнадцать "; break;
                            case 8: result += "восемьнаднацать "; break;
                            case 9: result += "девятнадцать "; break;
                        }
                    }
                    break;
                case 2: result += "двадцать "; break;
                case 3: result += "тридцать "; break;
                case 4: result += "сорок "; break;
                case 5: result += "пятьдесят "; break;
                case 6: result += "шестьдесят "; break;
                case 7: result += "семьдесят "; break;
                case 8: result += "восемьдесят "; break;
                case 9: result += "девяносто "; break;
            }
            switch ((x / 10) % 10)
            {
                case 0:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    switch (x % 10)
                    {
                        case 1: result += "один"; break;
                        case 2: result += "два"; break;
                        case 3: result += "три"; break;
                        case 4: result += "четыре"; break;
                        case 5: result += "пять"; break;
                        case 6: result += "шесть"; break;
                        case 7: result += "семь"; break;
                        case 8: result += "восемь"; break;
                        case 9: result += "девять"; break;
                    }
                    break;
            }
            return result;
        }
        static void Task7_18()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите число ");
                    int x = int.Parse(Console.ReadLine());
                    if (x <= 0 || x >= 1000) throw new ArgumentException("Введите число от 1 до 999");
                    Console.WriteLine(GetNameOfTheNumber(x));
                    break;
                }
                catch (OverflowException ex) { Console.WriteLine(ex.Message); }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Menu();
        }
    }
}