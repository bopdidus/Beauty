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
    public partial class CancelTryContinueForm : Form
    {
        BeautyMessageBox beautyMessageBox;
        public CancelTryContinueForm(BeautyMessageBox beautyMessage)
        {
            InitializeComponent();
            beautyMessageBox = beautyMessage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.Cancel);
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.TryAgain);
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.Continue);
        }
    }
}
