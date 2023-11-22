namespace newthing
{
    partial class ReportApproval
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
            this.content = new System.Windows.Forms.Label();
            this.Approve = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(71, 64);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(72, 25);
            this.content.TabIndex = 0;
            this.content.Text = "content";
            // 
            // Approve
            // 
            this.Approve.Location = new System.Drawing.Point(212, 282);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(112, 34);
            this.Approve.TabIndex = 1;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Reject
            // 
            this.Reject.Location = new System.Drawing.Point(397, 282);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(112, 34);
            this.Reject.TabIndex = 2;
            this.Reject.Text = "reject";
            this.Reject.UseVisualStyleBackColor = true;
            this.Reject.Click += new System.EventHandler(this.Reject_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "feedback";
            // 
            // ReportApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.content);
            this.Name = "ReportApproval";
            this.Text = "ReportApproval";
            this.Load += new System.EventHandler(this.ReportApproval_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label content;
        private Button Approve;
        private Button Reject;
        private TextBox textBox1;
        private Label label1;
    }
}