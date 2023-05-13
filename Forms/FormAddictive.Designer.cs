namespace Hotel.Forms
{
    partial class FormAddictive
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
            labelAddName = new Label();
            labelAddPrice = new Label();
            richTextBoxAddPrice = new RichTextBox();
            richTextBoxAddName = new RichTextBox();
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
            tableLayoutPanel1.Controls.Add(labelAddName, 0, 2);
            tableLayoutPanel1.Controls.Add(labelAddPrice, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxAddPrice, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxAddName, 1, 2);
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
            // labelAddName
            // 
            labelAddName.AutoSize = true;
            labelAddName.Dock = DockStyle.Fill;
            labelAddName.Location = new Point(3, 120);
            labelAddName.Name = "labelAddName";
            labelAddName.Size = new Size(394, 230);
            labelAddName.TabIndex = 1;
            labelAddName.Text = "Название услуги:";

 
            // labelAddPrice
            // 
            labelAddPrice.AutoSize = true;
            labelAddPrice.Dock = DockStyle.Fill;
            labelAddPrice.Location = new Point(3, 60);
            labelAddPrice.Name = "labelAddPrice";
            labelAddPrice.Size = new Size(394, 60);
            labelAddPrice.TabIndex = 3;
            labelAddPrice.Text = "Стоимость услуги:";
            // 

            // 
            // richTextBoxAddPrice
            // 
            richTextBoxAddPrice.Dock = DockStyle.Fill;
            richTextBoxAddPrice.Location = new Point(403, 63);
            richTextBoxAddPrice.Name = "richTextBoxAddPrice";
            richTextBoxAddPrice.Size = new Size(394, 54);
            richTextBoxAddPrice.TabIndex = 5;
            richTextBoxAddPrice.Text = "";
            // 
            // richTextBoxAddName
            // 
            richTextBoxAddName.Dock = DockStyle.Fill;
            richTextBoxAddName.Location = new Point(403, 123);
            richTextBoxAddName.Name = "richTextBoxAddName";
            richTextBoxAddName.Size = new Size(394, 224);
            richTextBoxAddName.TabIndex = 6;
            richTextBoxAddName.Text = "";
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
            // FormItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormItem";
            Text = "FormItem";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelAddName;
        private Label labelName;
        private Label labelAddPrice;
        private RichTextBox richTextBoxName;
        private RichTextBox richTextBoxAddPrice;
        private RichTextBox richTextBoxAddName;
        private Button buttonSave;
        private Button buttonCancel;
    }
}