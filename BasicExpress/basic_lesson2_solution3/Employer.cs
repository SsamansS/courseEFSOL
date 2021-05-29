using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson2_solution3
{
    enum Position
    {
        Junior = 1,
        Middle = 2,
        Senior = 3
    }

    class Employer
    {
        string Surname;
        string Name;
        int Experience;
        Position Position;

        public Employer(string Surname, string Name)
        {
            this.Surname = Surname;
            this.Name = Name;

            Random random = new Random();
            int position = random.Next(1, 3);
            this.Position = (Position)position;

            int experience = random.Next(0, 50);
            this.Experience = experience;
        }

        public double Salary()
        {
            return (Experience + 20) * Position.GetHashCode();
        }
        public double TexLevy()
        {
            return Salary() / 10;  //10% от зарплаты
        }
        public double NetSalary()
        {
            return Salary() - TexLevy(); // зарплата с учетом налога
        }
        public void Show()
        {
            Console.WriteLine(@$"
Фамилия: {Surname}
Имя: {Name}
Зарплата: {Salary()}тыс. сом
Налоговый сбор: {TexLevy()}тыс. сом
Зарплата с учетом налогов: {NetSalary()}тыс. сом");
        }
    }
}
