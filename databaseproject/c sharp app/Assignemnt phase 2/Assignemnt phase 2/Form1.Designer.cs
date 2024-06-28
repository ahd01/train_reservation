using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignemnt_phase_2
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(399, 33);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Train Admin";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 1;
            label2.Text = "TRAIN_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 2;
            label3.Text = "TRIP_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 3;
            label4.Text = "CAPACITY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 273);
            label5.Name = "label5";
            label5.Size = new Size(322, 28);
            label5.TabIndex = 4;
            label5.Text = "DEPARTURE_STATION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(351, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(351, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(400, 31);
            textBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RosyBrown;
            button2.Location = new Point(351, 325);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 10;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.RosyBrown;
            dataGridView1.Location = new Point(61, 391);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(837, 158);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RosyBrown;
            button1.Location = new Point(513, 324);
            button1.Name = "button1";
            button1.Size = new Size(127, 46);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.RosyBrown;
            button3.Location = new Point(664, 325);
            button3.Name = "button3";
            button3.Size = new Size(127, 46);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.RosyBrown;
            button4.Location = new Point(84, 22);
            button4.Name = "button4";
            button4.Size = new Size(137, 45);
            button4.TabIndex = 14;
            button4.Text = "home page";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.imageee;
            ClientSize = new Size(973, 561);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}

