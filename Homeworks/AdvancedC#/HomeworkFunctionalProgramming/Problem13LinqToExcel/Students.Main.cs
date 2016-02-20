namespace Problem13LinqToExcel
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string path = "../../Students-data.txt";
            var streamReader = new StreamReader(path, Encoding.GetEncoding("UTF-8"));
            List<Student> students = new List<Student>();
            CultureInfo info = CultureInfo.InvariantCulture;
            using (streamReader)
            {
                
                int lineNumber = 2;
                string line = streamReader.ReadLine();
                line = streamReader.ReadLine();
                while (line != null)
                {
                    var splittedStr = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    students.Add(new Student(
                        int.Parse(splittedStr[0]),
                        splittedStr[1],
                        splittedStr[2],
                        splittedStr[3],
                        splittedStr[4],
                        splittedStr[5],
                        int.Parse(splittedStr[6]),
                        int.Parse(splittedStr[7]),
                        int.Parse(splittedStr[8]),
                        double.Parse(splittedStr[9], CultureInfo.InvariantCulture),
                        int.Parse(splittedStr[10]),
                        double.Parse(splittedStr[11], CultureInfo.InvariantCulture)));
                    lineNumber++;
                    line = streamReader.ReadLine();
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // TODO extract in Excel
        }
    }
}
