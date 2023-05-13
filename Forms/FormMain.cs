using System.Windows.Forms;

namespace Hotel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Forms.FormApartments form = new Forms.FormApartments();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms.FormAddictives form = new Forms.FormAddictives();
            form.Show();
        }
    }
}