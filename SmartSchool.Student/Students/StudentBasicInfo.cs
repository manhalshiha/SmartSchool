﻿using SmartSchool.Students.Domain.Models;

namespace SmartSchool.Students.Students
{
    public record StudentBasicInfo(int StudentId, string RollNumber , string FirstName , string LastName,DateTime DateOfBirth,int age)
    {
        public static StudentBasicInfo FromStudent(Student student) => new StudentBasicInfo(student.Id, student.RollNumber, student.FirstName, student.LastName, student.DateOfBirth, student.Age);
        
    }
}
