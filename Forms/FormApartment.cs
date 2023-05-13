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
    public partial class FormApartment : Form
    {
        Apartment apartment;
        bool newApartment;
        public FormApartment()
        {
            InitializeComponent();
            newApartment = true;
            apartment = new Apartment();
        }
        public FormApartment(Apartment apartment)
        {
            InitializeComponent();
            this.apartment = apartment;
            richTextBoxAppNumber.Text = apartment.ApNumber.ToString();
            richTextBoxAppCategoryId.Text = apartment.ApCategotyId.ToString();
            richTextBoxAppCapacity.Text = apartment.ApCapacity.ToString();   
            newApartment = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            apartment.ApNumber = Convert.ToInt32(richTextBoxAppNumber.Text);
            apartment.ApCategotyId = Convert.ToInt32(richTextBoxAppCategoryId.Text);
            apartment.ApCapacity = Convert.ToInt32(richTextBoxAppCapacity.Text);

            

            if (newApartment)
                Program.db.Apartments.Add(apartment);
            Program.db.SaveChanges();

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
