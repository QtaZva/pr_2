using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pr_2
{
    internal class Person
    {
        public static string firstName { get; set; }
        public static string secondName { get; set; }
        public static string birthdayDate { get; set; }
        public static int getAge()
        {
            string nowDate = DateTime.Now.ToString().Substring(0,10);
            int personYear = Convert.ToInt32(birthdayDate.Substring(6, 4));
            int nowYear = Convert.ToInt32(nowDate.Substring(6, 4));
            int personAge = nowYear - personYear;
            return personAge;
        }
        public static bool ageCheck()
        {
            string nowDate = DateTime.Now.ToString().Substring(0, 10);
            int personYear = Convert.ToInt32(birthdayDate.Substring(6, 4));
            int nowYear = Convert.ToInt32(nowDate.Substring(6, 4));
            int personAge = nowYear - personYear;
            if (personAge < 18 || personAge > 100) 
            {
                MessageBox.Show("Wrong birthday date!");
                return false;
            }
            return true;
        }
        public static void getInformation()
        {
            if (ageCheck())
            {
                MessageBox.Show($"Имя: {firstName} Фамилия: {secondName} Возраст: {getAge()}");
            }
        }
    }
}
