using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TungMovie
{
    public partial class Film_management : Form
    {
        public Film_management()
        {
            InitializeComponent();
        }
        DataTable dtMovie = null;
        MovieInfo Mi = new MovieInfo();

        public void LoadDataGrid()
        {
            gridFilmManagement.RowTemplate.Height = 150;
            gridFilmManagement.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridFilmManagement.DataSource = Mi.getmovielist();
            gridFilmManagement.Columns[0].Width = 20;
            gridFilmManagement.Columns[1].Width = 70;
            gridFilmManagement.Columns[2].Width = 70;
            gridFilmManagement.Columns[3].Width = 40;
            gridFilmManagement.Columns[4].Width = 40;
            gridFilmManagement.Columns[5].Width = 150;
            ((DataGridViewImageColumn)gridFilmManagement.Columns["Thumbnail"]).DefaultCellStyle.NullValue = null;
            ((DataGridViewImageColumn)gridFilmManagement.Columns["Thumbnail"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            gridFilmManagement.Columns[6].Width = 40;

        }

        private void Film_management_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void gridFilmManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gridFilmManagement.CurrentCell.RowIndex;
            boxFilmId.Text = gridFilmManagement.Rows[i].Cells["ID"].Value.ToString();
            textFilmName.Text = gridFilmManagement.Rows[i].Cells["Movie"].Value.ToString();
            textRating.Text = gridFilmManagement.Rows[i].Cells["Rating"].Value.ToString();
            txtGenre.Text = gridFilmManagement.Rows[i].Cells["Genre"].Value.ToString();
            txtDescription.Text = gridFilmManagement.Rows[i].Cells["Desciption"].Value.ToString();
            txtDuration.Text = gridFilmManagement.Rows[i].Cells["Duration"].Value.ToString();
            if (gridFilmManagement.Rows[i].Cells["Thumbnail"].Value.ToString() == "")
            {
                moviepic.Image = Properties.Resources.white;
            }
            else
            {
                byte[] pic = (byte[])gridFilmManagement.Rows[i].Cells["Thumbnail"].Value;
                MemoryStream image = new MemoryStream(pic);
                moviepic.Image = Image.FromStream(image);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            MemoryStream picture = new MemoryStream();
            moviepic.Image.Save(picture, moviepic.Image.RawFormat);
            Movie.addMovie(textFilmName.Text, textRating.Text, txtGenre.Text, txtDescription.Text, txtDuration.Text, picture);
            Movie.insertMovieStatistics(textFilmName.Text);
            LoadDataGrid();
            MessageBox.Show("add success");
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            MemoryStream picture = new MemoryStream();
            moviepic.Image.Save(picture, moviepic.Image.RawFormat);
            Movie.updateMovie(textFilmName.Text, textRating.Text, txtGenre.Text, txtDescription.Text, txtDuration.Text, boxFilmId.Text, picture);
            LoadDataGrid();
            MessageBox.Show("add success");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            Movie.DeleteMovie(boxFilmId.Text);
            LoadDataGrid();
            MessageBox.Show("delete success ");

        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            new ScheduleManagement().Show();
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                moviepic.Image = new Bitmap(open.FileName);
            }
        }

        private void boxFilmId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
