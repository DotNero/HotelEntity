using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel.Forms
{
    public partial class FormAddictive : Form
    {
        Addictive addictive;
        bool newAddictive;
        public FormAddictive()
        {
            InitializeComponent();
            newAddictive = true;
            addictive = new Addictive();
        }
        public FormAddictive(Addictive addictive)
        {
            InitializeComponent();
            this.addictive = addictive;
            richTextBoxAddName.Text = addictive.AddName;
            richTextBoxAddPrice.Text = addictive.AddPrice.ToString();
            newAddictive = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            addictive.AddName = richTextBoxAddName.Text;
            addictive.AddPrice = Convert.ToInt32(richTextBoxAddPrice.Text);

            if (newAddictive)
                Program.db.Addictives.Add(addictive);
            Program.db.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
