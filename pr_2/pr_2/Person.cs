﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pr_2
{
    internal class Person
    {
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Birthday { get; set; }
        public static int getAge()
        {
                                   
            string nowDate = DateTime.Now.ToString().Substring(0,10);
            int personYear = Convert.ToInt32(Birthday.Substring(6, 4));
            int nowYear = Convert.ToInt32(nowDate.Substring(6, 4));
            int personAge = nowYear - personYear;
            if (personAge >= 18)
            {
                return personAge;
            }
            else
            {
                return 0;
            }
        }
        public static void getInformation()
        {
            if (Birthday == "")
            {
                MessageBox.Show("Введите корректную дату");
            }
            else
            {

                MessageBox.Show($"Имя: {Name} Фамилия: {Surname} Возраст: {getAge()}");
            }
        }
    }
}
