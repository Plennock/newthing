namespace newthing
{
    partial class meetingRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.Relations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.ListBox();
            this.Minutes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting Request";
            // 
            // Relations
            // 
            this.Relations.FormattingEnabled = true;
            this.Relations.ItemHeight = 25;
            this.Relations.Location = new System.Drawing.Point(50, 110);
            this.Relations.Name = "Relations";
            this.Relations.Size = new System.Drawing.Size(180, 129);
            this.Relations.TabIndex = 1;
            this.Relations.SelectedIndexChanged += new System.EventHandler(this.Relations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "People you can meet with";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hours
            // 
            this.Hours.FormattingEnabled = true;
            this.Hours.ItemHeight = 25;
            this.Hours.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.Hours.Location = new System.Drawing.Point(408, 221);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(180, 104);
            this.Hours.TabIndex = 5;
            // 
            // Minutes
            // 
            this.Minutes.FormattingEnabled = true;
            this.Minutes.ItemHeight = 25;
            this.Minutes.Items.AddRange(new object[] {
            "00",
            "30"});
            this.Minutes.Location = new System.Drawing.Point(653, 230);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(41, 54);
            this.Minutes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // meetingRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Relations);
            this.Controls.Add(this.label1);
            this.Name = "meetingRequest";
            this.Text = "meetingRequest";
            this.Load += new System.EventHandler(this.meetingRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox Relations;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListBox Hours;
        private ListBox Minutes;
        private Label label3;
        private Label label4;
    }
}