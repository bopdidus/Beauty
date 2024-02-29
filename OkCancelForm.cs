using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty
{
    public partial class OkCancelForm : Form
    {
        BeautyMessageBox beautyMessageBox;
        public OkCancelForm(BeautyMessageBox beautyMessageBox)
        {
            InitializeComponent();
            this.beautyMessageBox = beautyMessageBox;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.beautyMessageBox.UpdateForm(DialogResult.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.beautyMessageBox.UpdateForm(DialogResult.Cancel);
        }
    }
}
