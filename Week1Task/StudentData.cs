using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Task
{
    class StudentData
    {
        // Property field for the student Academic performance data
        // This informations are the basis of the result(GPA) Computation
        public string  CourseNameCode { get; set; }
        public double CourseUnit { get; set; }
        public double StudentScore { get; set; }


        // Constructor
        public StudentData(string courseNameCode, double courseUnit, double studentScore)
        {
            this.CourseNameCode = courseNameCode;
            this.CourseUnit = courseUnit;
            this.StudentScore = studentScore;

        }


    }
}

