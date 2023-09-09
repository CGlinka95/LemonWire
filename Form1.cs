using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace LemonWire
{
    public partial class Form1 : Form
    {
        //BindingSource is the ability to connect a List of items, such as albums, to the grid control on the frontend.
        BindingSource albumBindingSource = new BindingSource();
        BindingSource songBindingSource = new BindingSource();

        string connectionString = "datasource=localhost; port=3306; username=root; password=root; database=lemonwire";

        public Form1()
        {
            InitializeComponent();
        }

        //On Form load...
        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

            //Load image from the internet using a pictureBox and URL
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/3/3b/Tool-Opiate.jpg");
        }

        //Click event to fetch ALL allbums in the database...
        private void loadAlbumsButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

            //Load image from the internet using a pictureBox and URL
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/3/3b/Tool-Opiate.jpg");
        }

        //Search Button functionality...
        private void searchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.SearchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        //Click event for cells clicked inside the dataGridView1...
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //Get the row number that was clicked 
            int rowClicked = dataGridView.CurrentRow.Index;

            //**TESTING**
            //MessageBox.Show("You clicked row " + rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            //**TESTING**
            //MessageBox.Show("URL=" + imageURL);

            pictureBox1.Load(imageURL);

            //Redefine albumsDAO inside this object
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //Connect the list to the grid view control
            //Look for the rowClicked variable from line 59 and explicitly cast it to an int so that we can use the result
            songBindingSource.DataSource = albumsDAO.GetSongsUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView2.DataSource = songBindingSource;
        }

        //Click event to add album information to the database...
        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            //Add a new item to the database
            Album album = new Album
            {
                AlbumName = txt_albumTitle.Text,
                ArtistName = txt_artist.Text,
                ReleaseYear = Int32.Parse(txt_releaseYear.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text,
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.AddOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted.");
        }

        //Click event to delete a song from an album w/ validation...
        private void deleteButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            // Check if a row is selected in the DataGridView
            if (dataGridView2.SelectedRows.Count > 0)
            {
                //Get the selected row
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                //Get the songId from the selected row's "ID" column
                if (int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int songID))
                {
                    JObject songIDObject = new JObject(new JProperty("ID", songID));

                    //Call the DeleteSong method to delete the song
                    albumsDAO.DeleteSong(songIDObject, connectionString);

                    //Display a success message
                    MessageBox.Show("Song deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

                    dataGridView1.DataSource = albumBindingSource;
                }
                else
                {
                    MessageBox.Show("Invalid Song ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}