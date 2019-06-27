using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Students
{
    public class Student
    {
        // notice the private set on the id
        public int Id { get; private set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Student(String firstName, String lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
