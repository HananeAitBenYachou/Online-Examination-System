using OnlineExamination_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshTracksList()
        {

            dgvTracksList.DataSource = Track.GetAllTracks().DefaultView;

            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Assuming dgvCourses is your DataGridView and _coursesDataView is your DataView
            // Create a DataGridViewButtonColumn
            var deleteImageColumn = new DataGridViewImageColumn
            {
                Name = "Delete",
                HeaderText = "Action",
                Image = Properties.Resources.delete, // Set your delete icon here
                Width = 20,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            // Add the button column to the DataGridView
            dgvTracksList.Columns.Add(deleteImageColumn);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTracksList();
        }
    }
}
