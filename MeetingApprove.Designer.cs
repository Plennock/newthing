namespace newthing
{
    partial class MeetingApprove
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
            this.confirm = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting Approve";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(232, 332);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(112, 34);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Reject
            // 
            this.Reject.Location = new System.Drawing.Point(401, 332);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(112, 34);
            this.Reject.TabIndex = 3;
            this.Reject.Text = "Reject";
            this.Reject.UseVisualStyleBackColor = true;
            this.Reject.Click += new System.EventHandler(this.Reject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(82, 217);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(59, 25);
            this.time.TabIndex = 5;
            this.time.Text = "label3";
            // 
            // MeetingApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Name = "MeetingApprove";
            this.Text = "MeetingApprove";
            this.Load += new System.EventHandler(this.MeetingApprove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button confirm;
        private Button Reject;
        private Label label2;
        private Label time;
    }
}