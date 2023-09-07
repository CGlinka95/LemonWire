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
    }
}