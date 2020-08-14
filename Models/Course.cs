﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetcoreHW.Models
{
    public partial class Course: IDelete
    {
        public Course()
        {
            CourseInstructor = new HashSet<CourseInstructor>();
            Enrollment = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? DateModified { set; get; }
        public bool IsDeleted { set; get; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructor { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}