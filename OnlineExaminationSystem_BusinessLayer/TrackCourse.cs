using OnlineExaminationSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class TrackCourse
    {
        public int? TrackCourseID { get; private set; }
        public int TrackID { get; set; }
        public int CourseID { get; set; }

        public TrackCourse()
        {
            TrackCourseID = null;
            TrackID = default;
            CourseID = default;
        }
        private TrackCourse(int? trackCourseID, int trackID, int courseID)
        {
            this.TrackCourseID = trackCourseID;
            this.TrackID = trackID;
            this.CourseID = courseID;
        }

        public static TrackCourse Find(int? trackCourseID)
        {
            int trackID = default;
            int courseID = default;

            bool isFound = TrackCourseData.GetTrackCourseInfoByID(trackCourseID, ref trackID, ref courseID);

            if (isFound)
                return new TrackCourse(trackCourseID, trackID, courseID);
            else
                return null;
        }

        public static bool DoesTrackCourseExist(int? trackCourseID)
        {
            return TrackCourseData.DoesTrackCourseExist(trackCourseID);
        }

        private bool AddNewTrackCourse()
        {
            TrackCourseID = TrackCourseData.AddNewTrackCourse(TrackID, CourseID);
            return TrackCourseID.HasValue;
        }

        public bool Save()
        {
            return AddNewTrackCourse();
        }

        public static bool DeleteTrackCourse(int? trackCourseID)
        {
            return TrackCourseData.DeleteTrackCourse(trackCourseID);
        }

        public static DataTable GetAllTrackCourses(int? trackID)
        {
            return TrackCourseData.GetAllTrackCourses(trackID);
        }

        public static Dictionary<string,int> GetAvailableCoursesForTrack(int? trackID)
        {
            return TrackCourseData.GetAvailableCoursesForTrack(trackID);
        }

    }
}
