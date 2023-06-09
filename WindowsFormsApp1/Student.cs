﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Student
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private List<int> grades;

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public float Average { get; set;}
        public Student(string ID, string firstName, string lastName, string email, string phoneNumber, int grade1, int grade2, int grade3, int grade4, int grade5)
        {
            this.ID = ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            int gradesSum = 0;
            int legalGrades = 0;
            int [] grades = { grade1, grade2, grade3, grade4, grade5 };
            for(int i = 0; i<5; i++)
            {
                if (gradeIsLegal(grades[i]))
                {
                    gradesSum += grades[i];
                    legalGrades++;
                }
            }
            this.Average = (float)gradesSum/legalGrades;
        }

        public Student(string v1, string v2, string v3, string v4, string v5, List<int> grades)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.grades = grades;
        }

        public Boolean gradeIsLegal(int grade)
        {
            return grade != 777;
        }
    }
}
