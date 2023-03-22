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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
                MessageBox.Show("Giới tính bạn là:" + rbNam.Text);
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
                MessageBox.Show("Giới tính bạn là:" + rbNu.Text);
        }
    }
}
