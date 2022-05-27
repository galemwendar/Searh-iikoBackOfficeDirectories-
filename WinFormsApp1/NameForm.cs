namespace WinFormsApp1
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            NameSender();
            Close();
            tb_Name.Clear();
        }

        public void NameSender()
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.mName = tb_Name.Text;
            }
        }
    }
}
