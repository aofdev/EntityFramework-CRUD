﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}