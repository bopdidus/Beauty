using System.Windows.Forms;


namespace Beauty
{
    public enum BeautyMessageType
    {
        Error,
        Warning,
        Primary,
        Secondary,
        Success,
    }

    public enum BeautyMessageIcon
    {
        Question,
        TickMark,
        CrossMark,
        Information,
        ExclamationMark
    }
    public enum BeautyMessageButtons
    {
        YesNo,
        OK,
        CancelTryContinue,
        OKCancel
    }


    public partial class BeautyMessageBox : Form
    {
        DialogResult result;
        public BeautyMessageBox(string title, string message, BeautyMessageType type, BeautyMessageButtons btn, BeautyMessageIcon icon)
        {
            InitializeComponent();
            lbTitle.Text = title;
            lbMessage.Text = message;
            ChangeTheme(type);
            ChooseButton(btn);
            ChooseIcon(icon);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }

        private void ChangeTheme(BeautyMessageType type)
        {
            switch (type)
            {
                case BeautyMessageType.Error:
                    paneltheme.BackColor = Color.Crimson;
                    lbIcon.ForeColor = Color.Crimson;
                    break;
                case BeautyMessageType.Primary:
                    paneltheme.BackColor = Color.DeepSkyBlue;
                    lbIcon.ForeColor = Color.DeepSkyBlue;
                    break;
                case BeautyMessageType.Success:
                    paneltheme.BackColor = Color.LimeGreen;
                    lbIcon.ForeColor = Color.LimeGreen;
                    break;
                case BeautyMessageType.Secondary:
                    paneltheme.BackColor = Color.SlateGray;
                    lbIcon.ForeColor = Color.SlateGray;
                    break;
                case BeautyMessageType.Warning:
                    paneltheme.BackColor = Color.Orange;
                    lbIcon.ForeColor = Color.Orange;
                    break;
                default:
                    paneltheme.BackColor = Color.DeepSkyBlue;
                    lbIcon.ForeColor = Color.DeepSkyBlue;
                    break;
            }
        }

        private void ChooseIcon(BeautyMessageIcon icon)
        {
            switch (icon)
            {
                case BeautyMessageIcon.TickMark:
                    lbIcon.Text = Uri.UnescapeDataString("\u2713");
                    break;
                case BeautyMessageIcon.CrossMark:
                    lbIcon.Text = Uri.UnescapeDataString("\u2715");
                    break;
                case BeautyMessageIcon.ExclamationMark:
                    lbIcon.Text = Uri.UnescapeDataString("\u27c1");
                    break;
                case BeautyMessageIcon.Information:
                    lbIcon.Text = Uri.UnescapeDataString("\u2757");
                    break;
                case BeautyMessageIcon.Question:
                    lbIcon.Text = Uri.UnescapeDataString("\u2753");
                    break;
                default:
                    lbIcon.Text = Uri.UnescapeDataString("\u2757");
                    break;
            }
        }

        private void ChooseButton(BeautyMessageButtons buttons)
        {
            switch (buttons)
            {
                case BeautyMessageButtons.OK:
                    LoadForm(new OkForm(this));
                    break;
                case BeautyMessageButtons.OKCancel:
                    LoadForm(new OkCancelForm(this));
                    break;
                case BeautyMessageButtons.YesNo:
                    LoadForm(new YesNoForm(this));
                    break;
                case BeautyMessageButtons.CancelTryContinue:
                    LoadForm(new CancelTryContinueForm(this));
                    break;
                default:
                    LoadForm(new OkForm(this));
                    break;
            }
        }

        private void LoadForm(object form)
        {
            if (panelfooter.Controls.Count > 0)
            {
                this.panelfooter.Controls.Clear();
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelfooter.Controls.Add(f);
            this.panelfooter.Tag = f;
            f.Show();
        }

        public void UpdateForm(DialogResult dialog)
        {
            result = dialog;
            this.Close();
        }

        public new DialogResult ShowDialog()
        {
            base.ShowDialog();
            return result;
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}