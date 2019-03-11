using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GB::CS");
            GradeStatistics stats = new GradeStatistics();

            

            float sum = 0;

            foreach (float grade in grades)
            {

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }


            if (grades.Count > 0)
            {
                stats.AverageGrade = sum / grades.Count;
            }



            return stats;
        }

        public override void WriteGrade(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        
        protected List<float> grades;
    }
}
