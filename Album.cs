namespace LemonWire
{
    internal class Album
    {
        public int ID { get; set; }
        public String? AlbumName { get; set; }
        public String? ArtistName { get; set; }
        public int ReleaseYear { get; set; }
        public String? ImageURL { get; set; }
        public String? Description { get; set; }

        //Make a List<Track> for songs related to the albums
    }
}
