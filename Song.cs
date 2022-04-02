namespace hwapp
{
    public class Song
    {
        public string title = "";
        public string artist = "";
        public int duration = 0;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }
    }
}