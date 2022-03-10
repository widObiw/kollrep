using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static List<string> markTypeList = new List<string>() { "Б", "П", "У" };
        public class Student
        {
            public Student(DateTime _year, string _group, string _name)
            {
                AdmissionYear = _year;
                ClassGroup = _group;
                FullName = _name;
            }
            public DateTime AdmissionYear { get; set; }
            public string ClassGroup { get; set; }
            public string FullName { get; set; }
        }

        public class Mark
        {
            public DateTime Date { get; set; }
            public string _estimation;
            public Student StudentData { get; set; }
            public string Estimation
            {
                get
                {
                    return _estimation;
                }

                set
                {
                    if (markTypeList.Contains(value))
                    {
                        _estimation = value;
                    }
                    else
                    {
                        try
                        {
                            Convert.ToDouble(value);
                            _estimation = value;
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        #region Methods
        public static int[] CountByCategory(List<Mark> marks, string category)
        {
            List<int> Years = marks.Select(c => c.Date.Year).ToList();
            int[] result = new int[Years.Count * 12];
            int counter = 0;

            foreach (int year in Years)
            {
                for (int i = 1; i <= 12; i++)
                {
                    List<Mark> currentMonth = marks.Where(c => c.Date.Month == i && c.Date.Year == year).ToList();

                    result[counter++] = currentMonth.Where(c => c.Estimation == category).Count();
                }
            }
            return result;
        }

        public static double MinAVG(string[] marks)
        {
            double resultAvg;
            List<double> marksList = new List<double>();

            foreach (string mark in marks)
            {
                try
                {
                    //Округление
                    double value = Convert.ToDouble(mark);                   

                    marksList.Add(value);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            resultAvg = marksList.Average();
            return Math.Floor(resultAvg);
        }

        public static int[] GetCountTruancy(List<Mark> marks)
        {
            return CountByCategory(marks, "П");
        }

        public static int[] GetCountDisease(List<Mark> marks)
        {
            return CountByCategory(marks, "Б");
        }

        public static string GetStudNumber(int year, int group, string fio)
        {
            string[] FIO = fio.Split(' ');
            return $"{year}.{group}.{FIO[0][0]}{FIO[1][0]}{FIO[2][0]}";
        }

        public static List<Mark> GetMarks(DateTime now, List<Student> students)
        {
            List<Mark> result = new List<Mark>();
            Random rand = new Random();

            for (int i = 1; i <= now.Day + 10; i++)
            {
                DateTime current = new DateTime(now.Year, now.Month, i);

                foreach (Student student in students)
                {
                    result.Add(new Mark() { Date = current, StudentData = student, Estimation = markTypeList[rand.Next(0, 4)] });
                }
            }

            return result;
        }
        #endregion
    }
}
