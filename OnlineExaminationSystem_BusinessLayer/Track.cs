using OnlineExamination_DataAccessLayer;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Track
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int? TrackID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Track()
        {
            _mode = Mode.AddNew;
            TrackID = null;
            Name = default;
            Description = null;
        }
        private Track(int? trackID, string name, string description)
        {
            _mode = Mode.Update;
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

        public static Track Find(string name)
        {
            int? trackID = default;
            string description = default;

            bool isFound = TrackData.GetTrackInfoByName(name, ref trackID, ref description);

            if (isFound)
                return new Track(trackID, name, description);
            else
                return null;
        }

        public static bool DoesTrackExist(int? trackID)
        {
            return TrackData.DoesTrackExist(trackID);
        }

        public static bool DoesTrackExist(string name)
        {
            return TrackData.DoesTrackExist(name);
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
                case Mode.AddNew:
                    if (AddNewTrack())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
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