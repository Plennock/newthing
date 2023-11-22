namespace newthing
{
    partial class viewSupervisor
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
            this.Details = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.Relations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(28, 339);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(65, 25);
            this.Details.TabIndex = 7;
            this.Details.Text = "Details";
            // 
            // HistoryBox
            // 
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.ItemHeight = 25;
            this.HistoryBox.Location = new System.Drawing.Point(532, 147);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(180, 129);
            this.HistoryBox.TabIndex = 6;
            this.HistoryBox.SelectedIndexChanged += new System.EventHandler(this.HistoryBox_SelectedIndexChanged);
            // 
            // Relations
            // 
            this.Relations.FormattingEnabled = true;
            this.Relations.ItemHeight = 25;
            this.Relations.Location = new System.Drawing.Point(12, 147);
            this.Relations.Name = "Relations";
            this.Relations.Size = new System.Drawing.Size(180, 129);
            this.Relations.TabIndex = 5;
            this.Relations.SelectedIndexChanged += new System.EventHandler(this.Relations_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUPERVISOR VIEW";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(252, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 129);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // viewSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.Relations);
            this.Controls.Add(this.label1);
            this.Name = "viewSupervisor";
            this.Text = "viewSupervisor";
            this.Load += new System.EventHandler(this.viewSupervisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Details;
        private ListBox HistoryBox;
        private ListBox Relations;
        private Label label1;
        private ListBox listBox1;
    }
}