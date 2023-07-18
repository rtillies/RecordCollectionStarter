namespace RecordCollection.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }
        public Album Album { get; set; }

        public string LengthInMinutesAndSeconds()
        {
            int minutes = LengthInSeconds / 60;
            int seconds = LengthInSeconds % 60;

            string minuteStr = (minutes < 10 ? "0" + minutes : minutes.ToString());
            string secondStr = (seconds < 10 ? "0" + seconds : seconds.ToString());

            return $"{minuteStr}:{secondStr}";
        }
    }
}
