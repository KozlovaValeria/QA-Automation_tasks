﻿namespace Task_5
{
    public class Course
    { 
        public string NameCourse { get; set; }
        public string DescriptionCourse { get; set; }

        public Course(string nameCourse, string descriptionCourse)
        {
            NameCourse = nameCourse;
            DescriptionCourse = descriptionCourse;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Course course)
            {
                return course.NameCourse == NameCourse &&
                       course.DescriptionCourse == DescriptionCourse;
            }
            return false;
        }
    }
}
