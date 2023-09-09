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

        //Additionally, I could make a compound query by adding a List of Songs to this class.
        //public List<Song>? Songs { get; set; }
    }
}
