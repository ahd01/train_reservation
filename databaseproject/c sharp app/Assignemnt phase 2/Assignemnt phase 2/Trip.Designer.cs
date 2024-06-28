namespace Assignemnt_phase_2
{
    partial class Trip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trip));
            btnADD = new Button();
            delete = new Button();
            btnupdate = new Button();
            txtduration = new TextBox();
            txtDetination = new TextBox();
            txtdistance = new TextBox();
            labelDeparturetime = new Label();
            labelDuration = new Label();
            label5 = new Label();
            labelArrivaltime = new Label();
            labelDestination = new Label();
            labeldistance = new Label();
            dataGridView = new DataGridView();
            arrivaltime = new DateTimePicker();
            deptime = new DateTimePicker();
            label1 = new Label();
            DEPSTATION = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnADD
            // 
            btnADD.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnADD.Location = new Point(56, 389);
            btnADD.Margin = new Padding(4, 5, 4, 5);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(224, 48);
            btnADD.TabIndex = 0;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += button1_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(851, 389);
            delete.Margin = new Padding(4, 5, 4, 5);
            delete.Name = "delete";
            delete.Size = new Size(210, 48);
            delete.TabIndex = 1;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdate.Location = new Point(457, 389);
            btnupdate.Margin = new Padding(4, 5, 4, 5);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(218, 48);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += button4_Click;
            // 
            // txtduration
            // 
            txtduration.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtduration.Location = new Point(807, 167);
            txtduration.Margin = new Padding(4, 5, 4, 5);
            txtduration.Name = "txtduration";
            txtduration.Size = new Size(233, 39);
            txtduration.TabIndex = 4;
            // 
            // txtDetination
            // 
            txtDetination.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetination.Location = new Point(272, 152);
            txtDetination.Margin = new Padding(4, 5, 4, 5);
            txtDetination.Name = "txtDetination";
            txtDetination.Size = new Size(233, 39);
            txtDetination.TabIndex = 8;
            txtDetination.TextChanged += textBox5_TextChanged;
            // 
            // txtdistance
            // 
            txtdistance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtdistance.Location = new Point(272, 297);
            txtdistance.Margin = new Padding(4, 5, 4, 5);
            txtdistance.Name = "txtdistance";
            txtdistance.Size = new Size(233, 39);
            txtdistance.TabIndex = 10;
            txtdistance.TextChanged += txtdistance_TextChanged;
            // 
            // labelDeparturetime
            // 
            labelDeparturetime.AutoSize = true;
            labelDeparturetime.BackColor = SystemColors.Control;
            labelDeparturetime.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeparturetime.Location = new Point(49, 43);
            labelDeparturetime.Margin = new Padding(4, 0, 4, 0);
            labelDeparturetime.Name = "labelDeparturetime";
            labelDeparturetime.Size = new Size(216, 28);
            labelDeparturetime.TabIndex = 13;
            labelDeparturetime.Text = "Departure Time";
            labelDeparturetime.Click += labelDeparturetime_Click;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.BackColor = SystemColors.Control;
            labelDuration.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDuration.Location = new Point(619, 163);
            labelDuration.Margin = new Padding(4, 0, 4, 0);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(130, 28);
            labelDuration.TabIndex = 15;
            labelDuration.Text = "Duration";
            labelDuration.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 16;
            // 
            // labelArrivaltime
            // 
            labelArrivaltime.AutoSize = true;
            labelArrivaltime.BackColor = SystemColors.Control;
            labelArrivaltime.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelArrivaltime.Location = new Point(619, 39);
            labelArrivaltime.Margin = new Padding(4, 0, 4, 0);
            labelArrivaltime.Name = "labelArrivaltime";
            labelArrivaltime.Size = new Size(181, 28);
            labelArrivaltime.TabIndex = 17;
            labelArrivaltime.Text = "Arrival Time";
            labelArrivaltime.Click += labelArrivaltime_Click;
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.BackColor = SystemColors.Control;
            labelDestination.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDestination.Location = new Point(49, 167);
            labelDestination.Margin = new Padding(4, 0, 4, 0);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(162, 28);
            labelDestination.TabIndex = 18;
            labelDestination.Text = "Destination";
            labelDestination.Click += labelDestination_Click;
            // 
            // labeldistance
            // 
            labeldistance.AutoSize = true;
            labeldistance.BackColor = SystemColors.Control;
            labeldistance.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeldistance.Location = new Point(49, 305);
            labeldistance.Margin = new Padding(4, 0, 4, 0);
            labeldistance.Name = "labeldistance";
            labeldistance.Size = new Size(124, 28);
            labeldistance.TabIndex = 19;
            labeldistance.Text = "Distance";
            labeldistance.Click += label8_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 470);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.Size = new Size(1082, 308);
            dataGridView.TabIndex = 20;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // arrivaltime
            // 
            arrivaltime.Location = new Point(272, 39);
            arrivaltime.Name = "arrivaltime";
            arrivaltime.Size = new Size(320, 31);
            arrivaltime.TabIndex = 21;
            // 
            // deptime
            // 
            deptime.Location = new Point(807, 39);
            deptime.Name = "deptime";
            deptime.Size = new Size(320, 31);
            deptime.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(619, 305);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 23;
            label1.Text = "Trip ID";
            label1.Click += label1_Click;
            // 
            // DEPSTATION
            // 
            DEPSTATION.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DEPSTATION.Location = new Point(807, 305);
            DEPSTATION.Margin = new Padding(4, 5, 4, 5);
            DEPSTATION.Name = "DEPSTATION";
            DEPSTATION.Size = new Size(233, 39);
            DEPSTATION.TabIndex = 24;
            // 
            // Trip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1175, 792);
            Controls.Add(DEPSTATION);
            Controls.Add(label1);
            Controls.Add(deptime);
            Controls.Add(arrivaltime);
            Controls.Add(dataGridView);
            Controls.Add(labeldistance);
            Controls.Add(labelDestination);
            Controls.Add(labelArrivaltime);
            Controls.Add(label5);
            Controls.Add(labelDuration);
            Controls.Add(labelDeparturetime);
            Controls.Add(txtdistance);
            Controls.Add(txtDetination);
            Controls.Add(txtduration);
            Controls.Add(btnupdate);
            Controls.Add(delete);
            Controls.Add(btnADD);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Trip";
            Text = "Form1";
            Load += Trip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtDetination;
        private System.Windows.Forms.TextBox txtdistance;
        private System.Windows.Forms.Label labelDeparturetime;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelArrivaltime;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labeldistance;
        private System.Windows.Forms.DataGridView dataGridView;
        private DateTimePicker arrivaltime;
        private DateTimePicker deptime;
        private Label label1;
        private TextBox DEPSTATION;
    }
}