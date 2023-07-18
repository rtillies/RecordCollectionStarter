namespace RecordCollection.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
