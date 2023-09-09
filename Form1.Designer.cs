﻿namespace LemonWire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            searchButton = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            loadAlbumsButton = new Button();
            addAlbumButton = new Button();
            txt_description = new TextBox();
            txt_imageURL = new TextBox();
            txt_releaseYear = new TextBox();
            txt_artist = new TextBox();
            txt_albumTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Album);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(341, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(639, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(260, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 381);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loadAlbumsButton);
            groupBox1.Controls.Add(addAlbumButton);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(txt_releaseYear);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_albumTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 334);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // loadAlbumsButton
            // 
            loadAlbumsButton.Location = new Point(132, 294);
            loadAlbumsButton.Name = "loadAlbumsButton";
            loadAlbumsButton.Size = new Size(185, 33);
            loadAlbumsButton.TabIndex = 6;
            loadAlbumsButton.Text = "Load Albums";
            loadAlbumsButton.UseVisualStyleBackColor = true;
            loadAlbumsButton.Click += loadAlbumsButton_Click;
            // 
            // addAlbumButton
            // 
            addAlbumButton.Location = new Point(6, 294);
            addAlbumButton.Name = "addAlbumButton";
            addAlbumButton.Size = new Size(110, 33);
            addAlbumButton.TabIndex = 10;
            addAlbumButton.Text = "Add";
            addAlbumButton.UseVisualStyleBackColor = true;
            addAlbumButton.Click += addAlbumButton_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(6, 256);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(311, 23);
            txt_description.TabIndex = 9;
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(6, 204);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(311, 23);
            txt_imageURL.TabIndex = 8;
            // 
            // txt_releaseYear
            // 
            txt_releaseYear.Location = new Point(6, 152);
            txt_releaseYear.Name = "txt_releaseYear";
            txt_releaseYear.Size = new Size(311, 23);
            txt_releaseYear.TabIndex = 7;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(6, 100);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(311, 23);
            txt_artist.TabIndex = 6;
            // 
            // txt_albumTitle
            // 
            txt_albumTitle.Location = new Point(6, 48);
            txt_albumTitle.Name = "txt_albumTitle";
            txt_albumTitle.Size = new Size(311, 23);
            txt_albumTitle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 234);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 182);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Image URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Release Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 381);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Songs";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(341, 399);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(639, 279);
            dataGridView2.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 16);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 8;
            label7.Text = "Albums";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(871, 684);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(109, 23);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete Song";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 747);
            Controls.Add(deleteButton);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(searchButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "LemonWire";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button searchButton;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_releaseYear;
        private TextBox txt_artist;
        private TextBox txt_albumTitle;
        private TextBox txt_description;
        private TextBox txt_imageURL;
        private Button addAlbumButton;
        private Button loadAlbumsButton;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private Button deleteButton;
    }
}