using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

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

            using (MySqlDataReader reader = command.ExecuteReader()) //MySqlDataReader is the RESULT of executing the command that is defined in line 24.
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

        //Get ALL ALBUM_NAMES that match the search bar input...
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

            using (MySqlDataReader reader = command.ExecuteReader())
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

        //INSERT album in to the database (albums table)...
        internal int AddOneAlbum(Album album)
        {
            //Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statement to INSERT an album
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums` (`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumTitle, @artist, @year, @imageName, @description)",
                connection);

            command.Parameters.AddWithValue("@albumTitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.ReleaseYear);
            command.Parameters.AddWithValue("@imageName", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            //ExecuteNonQuery = Executes an SQL statement against the connection and returns the number of rows affected
            int newRows = command.ExecuteNonQuery();

            //Close connection
            connection.Close();

            //Return the new rows
            return newRows;
        }

        //Fetch all songs related to albumID...
        public List<Song> GetSongsForAlbum(int albumID)
        {
            //Start with an empty list
            List<Song> returnList = new List<Song>();

            //Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //FETCH ALL Songs where the ID from Albums table is equal to albums_ID from Songs table
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM SONGS WHERE albums_ID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                //Loop until all Songs have been retrieved from the list
                while (reader.Read())
                {
                    Song songInList = new Song
                    {
                        ID = reader.GetInt32(0),
                        SongTitle = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };
                    returnList.Add(songInList);
                }
            }
            //Best practise to always Close the connection like so...
            connection.Close();

            return returnList;
        }

        //This is the better way of fetching songs from the albumID VS the method above ^^^
        //This method will FETCH ALL songs related to the selected album via a join (see SQL statement below for the example of a join).
        //This method also uses JObject which represents all items in a list as a JSON object.
        //I do this because the previous way of pulling data from the database was not going to allow for the increased amount of columns pulled when using a join.
        public List<JObject> GetSongsUsingJoin(int albumID)
        {
            //Start with an empty list
            List<JObject> returnList = new List<JObject>();

            //Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `NUMBER` AS Track, `SONG_TITLE` AS Song, albums.ALBUM_TITLE AS Album, `LYRICS` AS Lyrics, `LENGTH` AS Duration FROM `songs` JOIN albums ON albums_ID = albums.ID WHERE albums_ID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                //Loop until all JSON objects have been retrieved 
                while (reader.Read())
                {
                    JObject newSong = new JObject();

                    //For each column that is read will be put in to this JObject
                    //FieldCount tells exactly how many columns that are being read... FLEXABILITY 
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        //Add new properties to "newSong" JObject ****[Property NAME | Property VALUE]****
                        newSong.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    returnList.Add(newSong);
                }
            }
            //Best practise to always Close the connection like so...
            connection.Close();

            return returnList;
        }
    }
}
