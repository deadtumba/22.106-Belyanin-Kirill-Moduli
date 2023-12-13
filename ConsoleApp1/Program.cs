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
                string othes = "";
                while (string.IsNullOrEmpty(othes) || !Regex.IsMatch(othes, "^[а-яА-Я]+$"))
                {
                    Console.Write("Введите отчество пользователя:");
                    othes = Console.ReadLine();
                    if (string.IsNullOrEmpty(othes) || !Regex.IsMatch(othes, "^[а-яА-Я]+$"))
                    {
                        Console.WriteLine("Некорректно введено отчество, попробуйте еще раз");
                    }
                }
                string oklad = "";
                while (string.IsNullOrEmpty(oklad) || !Regex.IsMatch(oklad, "^[0-9]+$"))
                {
                    Console.Write("Введите оклад пользователя:");
                    oklad = Console.ReadLine();
                    if (string.IsNullOrEmpty(oklad) || !Regex.IsMatch(oklad, "^[0-9]+$"))
                    {
                        Console.WriteLine("Некорректно введен оклад, попробуйте еще раз");
                    }
                }
                string mail = "";
                while (string.IsNullOrEmpty(mail) || !Regex.IsMatch(mail, "^[a-zA-Z@.com]+$"))
                {
                    Console.Write("Введите почту пользователя:");
                    mail = Console.ReadLine();
                    if (string.IsNullOrEmpty(mail) || !Regex.IsMatch(mail, "^[a-zA-Z@.com]+$"))
                    {
                        Console.WriteLine("Некорректно введена почта, попробуйте еще раз");
                    }
                }
                string data = "";
                while (string.IsNullOrEmpty(data) || !Regex.IsMatch(data, "^[(1-28-92-90-9).(0-1)(0-9).(0-30-9)]+$"))
                {
                    Console.Write("Введите дату начала работы пользователя:");
                    data = Console.ReadLine();
                    if (string.IsNullOrEmpty(data) || !Regex.IsMatch(data, "^[(1-28-92-90-9).(0-1)(0-9).(0-30-9)]+$"))
                    {
                        Console.WriteLine("Некорректно введена дата начала работы, попробуйте еще раз");
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
