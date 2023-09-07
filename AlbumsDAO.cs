using MySql.Data.MySqlClient;

namespace LemonWire
{
    internal class AlbumsDAO
    {
        //DAO = Data Access Object
        //This will handle all of the queries, providing a layer between the frontend and the backend

        string connectionString = "datasource=localhost; port=3306; username=root; password=root; database=lemonwire";

        //Get ALL Albums from Albums table in database...
        public List<Album> GetAllAlbums()
        {
            //Start with an empty list
            List<Album> returnList = new List<Album>();

            //Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS",
                connection);

            using (MySqlDataReader reader = command.ExecuteReader()) //MySqlDataReader is the RESULT of executing the command that is defined in line 22.
            {
                //Loop until all Albums have been retrieved from the list
                while(reader.Read())
                {
                    Album albumInList = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        ReleaseYear = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnList.Add(albumInList);
                }
            }
            connection.Close();

            return returnList;
        }

        //Get all ALBUM_NAMES that match the search bar input...
        public List<Album> SearchTitles(String searchInput)
        {
            //Start with an empty list
            List<Album> returnList = new List<Album>();

            //Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchPhrase = "%" + searchInput + "%";
            //Using @search to match the searchInput rather than concatenating inside the SQL statement helps to prevent against SQL Injection Attacks!
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader()) //MySqlDataReader is the RESULT of executing the command that is defined in line 22.
            {
                //Loop until all Albums have been retrieved from the list
                while (reader.Read())
                {
                    Album albumInList = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        ReleaseYear = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnList.Add(albumInList);
                }
            }
            //Best practise to always Close the connection like so...
            connection.Close();

            return returnList;
        }
    }
}
