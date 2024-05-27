using OnlineExamination_DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Course
    {
        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? CourseID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Credits { get; set; }
        public short Duration { get; set; }
        public string Prerequisites { get; set; }

        public Course()
        {
            _mode = EnMode.AddNew;
            CourseID = null;
            Name = default;
            Description = null;
            Credits = default;
            Duration = default;
            Prerequisites = null;
        }
        private Course(int? courseID, string name, string description,
                       float credits, short duration, string prerequisites)
        {
            _mode = EnMode.Update;
            this.CourseID = courseID;
            this.Name = name;
            this.Description = description;
            this.Credits = credits;
            this.Duration = duration;
            this.Prerequisites = prerequisites;
        }

        public static Course Find(int? courseID)
        {
            string name = default;
            string description = default;
            float credits = default;
            short duration = default;
            string prerequisites = default;

            bool isFound = CourseData.GetCourseInfoByID(courseID, ref name, ref description,
                                                        ref credits, ref duration, ref prerequisites);


            return isFound ? new Course(courseID, name, description, credits, duration, prerequisites) : null;
        }

        public static Course Find(string name)
        {
            int? courseID = default;
            string description = default;
            float credits = default;
            short duration = default;
            string prerequisites = default;

            bool isFound = CourseData.GetCourseInfoByName(name, ref courseID, ref description,
                                                        ref credits, ref duration, ref prerequisites);


            return isFound ? new Course(courseID, name, description, credits, duration, prerequisites) : null;
        }

        public static bool DoesCourseExist(int? courseID)
        {
            return CourseData.DoesCourseExist(courseID);
        }

        public static bool DoesCourseExist(string name)
        {
            return CourseData.DoesCourseExist(name);
        }

        private bool AddNewCourse()
        {
            CourseID = CourseData.AddNewCourse(Name, Description, Credits, Duration, Prerequisites);
            return CourseID.HasValue;
        }

        private bool UpdateCourse()
        {
            return CourseData.UpdateCourseInfo(CourseID, Name, Description, Credits, Duration, Prerequisites);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewCourse())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateCourse();

            }
            return false;
        }

        public static bool DeleteCourse(int? courseID)
        {
            return CourseData.DeleteCourse(courseID);
        }

        public static DataTable GetAllCourses()
        {
            return CourseData.GetAllCourses();
        }

        public static List<string> GetAllCoursesNames()
        {
            return CourseData.GetAllCoursesNames();
        }

    }
}