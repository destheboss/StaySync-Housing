namespace housing.Classes
{
    internal class Announcement
    {
        public int ID { get; set; }
        public string Message { get; set; }

        public Announcement(int id, string message)
        {
            this.ID = id;
            this.Message = message;
        }

        public string GetAnnouncement()
        {
            return $"  ■ {this.Message}";
        }

        public string GetAnnouncementMessage()
        {
            return $"▶ {this.Message} ◀";
        }
        public string WriteAnnouncementMessage()
        {
            return $"{this.Message}";
        }
    }
}
