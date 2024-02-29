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
    public partial class OkForm : Form
    {
        BeautyMessageBox beautyMessageBox;
        public OkForm(BeautyMessageBox beautyMessage)
        {
            InitializeComponent();
            beautyMessageBox = beautyMessage;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            beautyMessageBox.UpdateForm(DialogResult.OK);
        }
    }
}
