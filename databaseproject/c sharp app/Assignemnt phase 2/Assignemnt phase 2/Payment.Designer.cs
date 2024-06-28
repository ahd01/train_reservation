namespace Assignemnt_phase_2
{
    partial class Payment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            methodbox = new ComboBox();
            colorDialog1 = new ColorDialog();
            cardnumbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addbutton = new Button();
            updatebutton = new Button();
            deletebutton = new Button();
            amountbox = new TextBox();
            Transctiondate = new DateTimePicker();
            expirydate = new DateTimePicker();
            label6 = new Label();
            namebox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // methodbox
            // 
            methodbox.DropDownStyle = ComboBoxStyle.DropDownList;
            methodbox.FormattingEnabled = true;
            methodbox.Items.AddRange(new object[] { "Debit Card", "Credit Card" });
            methodbox.Location = new Point(551, 23);
            methodbox.Name = "methodbox";
            methodbox.Size = new Size(320, 33);
            methodbox.TabIndex = 0;
            methodbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.DeepSkyBlue;
            // 
            // cardnumbox
            // 
            cardnumbox.Location = new Point(175, 83);
            cardnumbox.Name = "cardnumbox";
            cardnumbox.Size = new Size(255, 31);
            cardnumbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 6;
            label1.Text = "Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(458, 124);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 7;
            label2.Text = "Transaction Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 8;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(458, 59);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 9;
            label4.Text = "Expiry Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 59);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 10;
            label5.Text = "Card Number";
            // 
            // addbutton
            // 
            addbutton.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addbutton.Location = new Point(15, 209);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(214, 43);
            addbutton.TabIndex = 15;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += Add_Click;
            // 
            // updatebutton
            // 
            updatebutton.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            updatebutton.Location = new Point(362, 209);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(226, 43);
            updatebutton.TabIndex = 16;
            updatebutton.Text = "update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deletebutton.Location = new Point(692, 209);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(195, 43);
            deletebutton.TabIndex = 17;
            deletebutton.Text = "delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += delete_Click;
            // 
            // amountbox
            // 
            amountbox.BackColor = Color.WhiteSmoke;
            amountbox.Location = new Point(175, 150);
            amountbox.Name = "amountbox";
            amountbox.Size = new Size(255, 31);
            amountbox.TabIndex = 18;
            amountbox.TextChanged += textBox2_TextChanged;
            // 
            // Transctiondate
            // 
            Transctiondate.Location = new Point(551, 150);
            Transctiondate.MinDate = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            Transctiondate.Name = "Transctiondate";
            Transctiondate.Size = new Size(320, 31);
            Transctiondate.TabIndex = 23;
            Transctiondate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // expirydate
            // 
            expirydate.Location = new Point(551, 89);
            expirydate.MinDate = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            expirydate.Name = "expirydate";
            expirydate.Size = new Size(320, 31);
            expirydate.TabIndex = 24;
            expirydate.Value = new DateTime(2024, 5, 25, 23, 59, 59, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 9);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 25;
            label6.Text = "Name";
            // 
            // namebox
            // 
            namebox.Location = new Point(175, 25);
            namebox.Name = "namebox";
            namebox.Size = new Size(255, 31);
            namebox.TabIndex = 26;
            namebox.ReadOnlyChanged += False;
            namebox.EnabledChanged += True;
            namebox.TextChanged += namebox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(868, 283);
            dataGridView1.TabIndex = 27;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(902, 570);
            Controls.Add(dataGridView1);
            Controls.Add(namebox);
            Controls.Add(label6);
            Controls.Add(expirydate);
            Controls.Add(Transctiondate);
            Controls.Add(amountbox);
            Controls.Add(deletebutton);
            Controls.Add(updatebutton);
            Controls.Add(addbutton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cardnumbox);
            Controls.Add(methodbox);
            Name = "Payment";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox methodbox;
        private ColorDialog colorDialog1;
        private TextBox cardnumbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addbutton;
        private Button updatebutton;
        private Button deletebutton;
        private TextBox amountbox;
        private DateTimePicker Transctiondate;
        private DateTimePicker expirydate;
        private Label label6;
        private TextBox namebox;
        private DataGridView dataGridView1;
    }
}