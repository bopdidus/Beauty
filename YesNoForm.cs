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
    public partial class YesNoForm : Form
    {
        BeautyMessageBox beautyMessageBox;
        public YesNoForm(BeautyMessageBox beautyMessage)
        {
            InitializeComponent();
            beautyMessageBox = beautyMessage;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.Yes);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.No);
        }
    }
}
