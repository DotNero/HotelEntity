using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
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
    public partial class FormAddictives : Form, IFilterable
    {
        string request = "SELECT * FROM addictives";
        public FormAddictives()
        {
            InitializeComponent();
            Program.db.Addictives.Load();
            dataGridView1.DataSource = Program.db.Addictives.Local.ToBindingList();
        }

        string? condition = null;
        public void SetCondition(string newCondition)
        {
            if (newCondition != null && newCondition != "")
                condition = " WHERE " + newCondition;
            else condition = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Forms.FormAddictives form = new Forms.FormAddictives();
            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            dataGridView1.Refresh();
            MessageBox.Show("Новый объект добавлен");
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Addictive item = Program.db.Addictives.Find(id);

                Forms.FormAddictive form = new Forms.FormAddictive(item);

                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                dataGridView1.Refresh();
                MessageBox.Show("Объект обновлен");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Addictive item = Program.db.Addictives.Find(id);
                Program.db.Addictives.Remove(item);
                Program.db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Forms.FormFilter form = new Forms.FormFilter(this);
            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            if (condition != null)
                dataGridView1.DataSource = Program.db.Addictives.FromSqlRaw(request + condition).ToList();
        }
    }
}
