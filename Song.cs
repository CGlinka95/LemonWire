using Org.BouncyCastle.Asn1.Cms;

namespace LemonWire
{
    internal class Song
    {
        public int ID { get; set; }
        public String? SongTitle { get; set; }
        public int Number { get; set; }
        public String? VideoURL { get; set; }
        public String? Lyrics { get; set; }
        public Time? Length { get; set; }
    }
}