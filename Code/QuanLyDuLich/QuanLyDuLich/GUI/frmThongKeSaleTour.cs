using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    public partial class frmThongKeSaleTour : Form
    {
        public frmThongKeSaleTour()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            int row = e.RowIndex;
            this.dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col];
            this.dataGridView1.BeginEdit(false);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            this.dataGridView1.BeginEdit(false);
        }

        

    }
}
