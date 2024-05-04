using OnlineExamination_DataAccessLayer;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Track
    {
        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? TrackID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Track()
        {
            _mode = EnMode.AddNew;
            TrackID = null;
            Name = default;
            Description = null;
        }
        private Track(int? trackID, string name, string description)
        {
            _mode = EnMode.Update;
            this.TrackID = trackID;
            this.Name = name;
            this.Description = description;
        }

        public static Track Find(int? trackID)
        {
            string name = default;
            string description = default;

            bool isFound = TrackData.GetTrackInfoByID(trackID, ref name, ref description);

            if (isFound)
                return new Track(trackID, name, description);
            else
                return null;
        }

        public static bool DoesTrackExist(int? trackID)
        {
            return TrackData.DoesTrackExist(trackID);
        }

        private bool AddNewTrack()
        {
            TrackID = TrackData.AddNewTrack(Name, Description);
            return TrackID.HasValue;
        }

        private bool UpdateTrack()
        {
            return TrackData.UpdateTrackInfo(TrackID, Name, Description);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewTrack())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateTrack();

            }
            return false;
        }

        public static bool DeleteTrack(int? trackID)
        {
            return TrackData.DeleteTrack(trackID);
        }

        public static DataTable GetAllTracks()
        {
            return TrackData.GetAllTracks();
        }

    }
}