using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class FormFilter : Form
    {
        IFilterable baseForm;
        public FormFilter(IFilterable owner)
        {
            InitializeComponent();
            baseForm = owner;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            baseForm.SetCondition(richTextBoxRequest.Text);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
