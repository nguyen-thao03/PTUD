using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyetBuoi2
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiButton_Click(object sender, EventArgs e)
        {
            var form = new frmButton();
            form.ShowDialog();
        }

        private void tsmiComboBox_Click(object sender, EventArgs e)
        {
            var form = new frmComboBox();
            form.ShowDialog();
        }

        private void tsmiGroupBox_Click(object sender, EventArgs e)
        {
            var form = new frmGroupBox();
            form.ShowDialog();
        }

        private void tsmiImageList_Click(object sender, EventArgs e)
        {
            var form = new frmImageList();
            form.ShowDialog();
        }

        private void tsmiMenuStrip_Click(object sender, EventArgs e)
        {
            var form = new frmMenuStrip();
            form.ShowDialog();
        }

        private void tsmiPanel_Click(object sender, EventArgs e)
        {
            var form = new frmPanel();
            form.ShowDialog();
        }

        private void tsmiListBox_Click(object sender, EventArgs e)
        {
            var form = new frmListBox();
            form.ShowDialog();
        }

        private void tsmiRadioButton_Click(object sender, EventArgs e)
        {
            var form = new frmRadioButton();
            form.ShowDialog();
        }

        private void tsmiButtons_Click(object sender, EventArgs e)
        {
            var form = new frmButtons();
            form.ShowDialog();
        }

        private void tsmiCheckListBox_Click(object sender, EventArgs e)
        {
            var form = new frmCheckListBox();
            form.ShowDialog();
        }
    }
}
