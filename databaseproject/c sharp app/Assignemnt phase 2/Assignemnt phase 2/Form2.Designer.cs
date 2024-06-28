namespace Assignemnt_phase_2
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(69, 311);
            button1.Name = "button1";
            button1.Size = new Size(142, 59);
            button1.TabIndex = 0;
            button1.Text = "train";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(274, 310);
            button2.Name = "button2";
            button2.Size = new Size(130, 57);
            button2.TabIndex = 1;
            button2.Text = "trips";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(481, 308);
            button3.Name = "button3";
            button3.Size = new Size(142, 59);
            button3.TabIndex = 2;
            button3.Text = "Payment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(693, 311);
            button4.Name = "button4";
            button4.Size = new Size(196, 59);
            button4.TabIndex = 3;
            button4.Text = "Reservations";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 188);
            label1.Name = "label1";
            label1.Size = new Size(95, 45);
            label1.TabIndex = 4;
            label1.Text = "Train";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 188);
            label2.Name = "label2";
            label2.Size = new Size(93, 45);
            label2.TabIndex = 5;
            label2.Text = "Trips";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(483, 188);
            label3.Name = "label3";
            label3.Size = new Size(150, 45);
            label3.TabIndex = 6;
            label3.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(693, 188);
            label4.Name = "label4";
            label4.Size = new Size(196, 45);
            label4.TabIndex = 7;
            label4.Text = "Reservation";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(252, 46);
            label5.Name = "label5";
            label5.Size = new Size(452, 47);
            label5.TabIndex = 8;
            label5.Text = "Train booking system";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.imageee;
            ClientSize = new Size(913, 469);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}