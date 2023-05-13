namespace Hotel.Forms
{
    partial class FormApartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelAppNumber = new Label();
            labelAppCategoryId = new Label();
            labelAppCapacity = new Label();
            richTextBoxAppNumber = new RichTextBox();
            richTextBoxAppCategoryId = new RichTextBox();
            richTextBoxAppCapacity = new RichTextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelAppNumber, 0, 2);
            tableLayoutPanel1.Controls.Add(labelAppCategoryId, 0, 0);
            tableLayoutPanel1.Controls.Add(labelAppCapacity, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxAppCapacity, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBoxAppCategoryId, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxAppNumber, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonSave, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelAppNumber
            // 
            labelAppNumber.AutoSize = true;
            labelAppNumber.Dock = DockStyle.Fill;
            labelAppNumber.Location = new Point(3, 120);
            labelAppNumber.Name = "labelAppNumber";
            labelAppNumber.Size = new Size(394, 230);
            labelAppNumber.TabIndex = 1;
            labelAppNumber.Text = "Номер комнаты:";
            // 
            // labelAppCategoryId
            // 
            labelAppCategoryId.AutoSize = true;
            labelAppCategoryId.Dock = DockStyle.Fill;
            labelAppCategoryId.Location = new Point(3, 0);
            labelAppCategoryId.Name = "labelAppCategoryId";
            labelAppCategoryId.Size = new Size(394, 60);
            labelAppCategoryId.TabIndex = 2;
            labelAppCategoryId.Text = "Id категории";
            // 
            // labelAppCapacity
            // 
            labelAppCapacity.AutoSize = true;
            labelAppCapacity.Dock = DockStyle.Fill;
            labelAppCapacity.Location = new Point(3, 60);
            labelAppCapacity.Name = "labelAppCapacity";
            labelAppCapacity.Size = new Size(394, 60);
            labelAppCapacity.TabIndex = 3;
            labelAppCapacity.Text = "Вместимость:";
            // 
            // richTextBoxAppCategoryId
            // 
            richTextBoxAppCategoryId.Dock = DockStyle.Fill;
            richTextBoxAppCategoryId.Location = new Point(403, 3);
            richTextBoxAppCategoryId.Name = "richTextBoxAppCategoryId";
            richTextBoxAppCategoryId.Size = new Size(394, 54);
            richTextBoxAppCategoryId.TabIndex = 4;
            richTextBoxAppCategoryId.Text = "";
            // 
            // richTextBoxAppCapacity
            // 
            richTextBoxAppCapacity.Dock = DockStyle.Fill;
            richTextBoxAppCapacity.Location = new Point(403, 63);
            richTextBoxAppCapacity.Name = "richTextBoxAppCapacity";
            richTextBoxAppCapacity.Size = new Size(394, 54);
            richTextBoxAppCapacity.TabIndex = 5;
            richTextBoxAppCapacity.Text = "";
            // 
            // richTextBoxAppNumber
            // 
            richTextBoxAppNumber.Dock = DockStyle.Fill;
            richTextBoxAppNumber.Location = new Point(403, 123);
            richTextBoxAppNumber.Name = "richTextBoxAppNumber";
            richTextBoxAppNumber.Size = new Size(394, 224);
            richTextBoxAppNumber.TabIndex = 6;
            richTextBoxAppNumber.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(3, 353);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(394, 94);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(403, 353);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(394, 94);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormApartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormApartment";
            Text = "FormApartment";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelAppNumber;
        private Label labelAppCategoryId;
        private Label labelAppCapacity;
        private RichTextBox richTextBoxAppNumber;
        private RichTextBox richTextBoxAppCategoryId;
        private RichTextBox richTextBoxAppCapacity;
        private Button buttonSave;
        private Button buttonCancel;
    }
}