namespace newthing
{
    partial class MakeReport
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.CheckedListBox();
            this.SendToAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "enter report description";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(646, 382);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(112, 34);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select students to send to";
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(495, 47);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(182, 228);
            this.StudentList.TabIndex = 6;
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.StudentList_SelectedIndexChanged);
            // 
            // SendToAll
            // 
            this.SendToAll.AutoSize = true;
            this.SendToAll.Location = new System.Drawing.Point(287, 382);
            this.SendToAll.Name = "SendToAll";
            this.SendToAll.Size = new System.Drawing.Size(133, 29);
            this.SendToAll.TabIndex = 7;
            this.SendToAll.Text = "Send to All?";
            this.SendToAll.UseVisualStyleBackColor = true;
            this.SendToAll.CheckedChanged += new System.EventHandler(this.SendToAll_CheckedChanged);
            // 
            // MakeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendToAll);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "MakeReport";
            this.Text = "MakeReport";
            this.Load += new System.EventHandler(this.MakeReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button Send;
        private Label label2;
        private CheckedListBox StudentList;
        private CheckBox SendToAll;
    }
}