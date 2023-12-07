using ConsoleApp1.Models1;
using HashPasswords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Entities1 dn = Helper1.GetContext();

                Console.WriteLine("Создание новой учетной записи пользователя \n");
               
                string imya = "";
                while(string.IsNullOrEmpty(imya) || !Regex.IsMatch(imya, "^[а-яА-Я]+$"))
                {
                    Console.Write("Введите имя пользователя:");
                    imya = Console.ReadLine();
                    if (string.IsNullOrEmpty(imya) || !Regex.IsMatch(imya, "^[а-яА-Я]+$"))
                    {
                        Console.WriteLine("Некорректно введено имя, попробуйте еще раз");
                    }
                }
                string famil = "";
                while (string.IsNullOrEmpty(famil) || !Regex.IsMatch(famil, "^[а-яА-Я]+$"))
                {
                    Console.Write("Введите фамилию пользователя:");
                    famil = Console.ReadLine();
                    if (string.IsNullOrEmpty(famil) || !Regex.IsMatch(famil, "^[а-яА-Я]+$"))
                    {
                        Console.WriteLine("Некорректно введено фамилия, попробуйте еще раз");
                    }
                }
                string login = "";
                while (string.IsNullOrEmpty(login) || !Regex.IsMatch(login, "^[а-яА-Я0-9]+$"))
                {
                    Console.Write("Введите логин пользователя:");
                    login = Console.ReadLine();
                    if (string.IsNullOrEmpty(login) || !Regex.IsMatch(login, "^[а-яА-Я0-9]+$"))
                    {
                        Console.WriteLine("Некорректно введен логин, попробуйте еще раз");
                    }
                }
                string passw = "";
                while (string.IsNullOrEmpty(passw) || !Regex.IsMatch(passw, "^[а-яА-Я0-9a-zA-z]+$"))
                {
                    Console.Write("Введите пароль пользователя:");
                    passw = Console.ReadLine();
                    if (string.IsNullOrEmpty(passw) || !Regex.IsMatch(passw, "^[а-яА-Я0-9a-zA-z]+$"))
                    {
                        Console.WriteLine("Некорректно введен пароль, попробуйте еще раз");
                    }
                }
                string hashPassword = HashPassvords.HashPassword(passw);
                Console.WriteLine("Хэшированный пароль пользователя: {0}",hashPassword);
                Console.ReadLine();


            }
            catch
            {

            }
        }
    }
}
