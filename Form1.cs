namespace LemonWire
{
    public partial class Form1 : Form
    {
        //BindingSource is the ability to connect a List of items, such as albums, to the grid control on the frontend.
        BindingSource albumBindingSource = new BindingSource();

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
        private void button3_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

            //Load image from the internet using a pictureBox and URL
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/3/3b/Tool-Opiate.jpg");
        }

        //Search Button functionality...
        private void button1_Click(object sender, EventArgs e)
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
        }

        //Click event to add album information to the database...
        private void button2_Click(object sender, EventArgs e)
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
    }
}