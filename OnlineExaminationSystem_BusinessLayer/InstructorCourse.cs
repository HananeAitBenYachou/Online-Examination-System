using OnlineExaminationSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnlineExaminationSystem_BusinessLayer
{
    public class InstructorCourse
    { 
        public int? InstructorCourseID { get; private set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        public InstructorCourse()
        {
            InstructorCourseID = null;
            InstructorID = default;
            CourseID = default;
        }
        private InstructorCourse(int? instructorCourseID, int instructorID, int courseID)
        {
            this.InstructorCourseID = instructorCourseID;
            this.InstructorID = instructorID;
            this.CourseID = courseID;
        }

        public static InstructorCourse Find(int? instructorCourseID)
        {
            int instructorID = default;
            int courseID = default;

            bool isFound = InstructorCourseData.GetInstructorCourseInfoByID(instructorCourseID, ref instructorID, ref courseID);

            if (isFound)
                return new InstructorCourse(instructorCourseID, instructorID, courseID);
            else
                return null;
        }

        public static bool DoesInstructorCourseExist(int? instructorCourseID)
        {
            return InstructorCourseData.DoesInstructorCourseExist(instructorCourseID);
        }

        private bool AddNewInstructorCourse()
        {
            InstructorCourseID = InstructorCourseData.AddNewInstructorCourse(InstructorID, CourseID);
            return InstructorCourseID.HasValue;
        }

        public bool Save()
        {
            return AddNewInstructorCourse();
        }

        public static bool DeleteInstructorCourse(int? instructorCourseID)
        {
            return InstructorCourseData.DeleteInstructorCourse(instructorCourseID);
        }

        public static DataTable GetAllInstructorCourses(int? instructorID)
        {
            return InstructorCourseData.GetAllInstructorCourses(instructorID);
        }

        public static Dictionary<string, int> GetAvailableCoursesForInstructor(int? instructorID)
        {
            return InstructorCourseData.GetAvailableCoursesForInstructor(instructorID);
        }

    }
}
