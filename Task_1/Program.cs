using System;
using static System.Console;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите 1 — \"вывести данные на экран\" или 2 — \"заполнить данные и добавить новую запись в конец файла\": ");
            int i = int.Parse(ReadLine());
            string path = @"D:\data.txt";
            if (i == 2)
            {
                Write("Введите ID: ");
                int ID = int.Parse(ReadLine());
                DateTime date = DateTime.Now;
                Write("Введите ФИО: ");
                string fullName = ReadLine();
                Write("Введите возраст: ");
                int age = int.Parse(ReadLine());
                Write("Введите рост: ");
                int height = int.Parse(ReadLine());
                Write("Введите дату рождения ");
                string dateBith = ReadLine();
                Write("Введите место рождения: ");
                string place = ReadLine();

                string text = ID.ToString() + "#" + date.ToString() + "#" + fullName + "#" + age.ToString() + "#" + height.ToString() + "#" + dateBith + "#" + place;

                File.AppendAllText(path, text);
            }
            else if (i == 1)
            {
                string textFile = File.ReadAllText(path);
                string[] splitText = textFile.Split('#');
                FileInfo fileInfo = new FileInfo(path);
                WriteLine("Данные из файла " + fileInfo.Name + ":");
                foreach (var e in splitText)
                {
                    Write($"{e}, ");
                }     
            }
            else
            {
                Write("Введено неверное значение, попробуйте снова. ");
            }
        }
    }
}
