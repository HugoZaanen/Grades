using System;
using System.Collections.Generic;

namespace Grades
{
    internal class GradeBook
    {
        List<float> Grades;

        public GradeBook()
        {
            Grades = new List<float>();
        }

        internal void AddGrade(float fl)
        {
            Grades.Add(fl);
        }

        //internal GradeStatistics ComputeStatistics()
        //{
            
        //}
    }
}