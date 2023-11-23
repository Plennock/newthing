namespace newthing
{
    partial class ViewStudent
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
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.Details = new System.Windows.Forms.Label();
            this.ExitToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT VIEW";
            // 
            // Relations
            // 
            this.Relations.FormattingEnabled = true;
            this.Relations.ItemHeight = 25;
            this.Relations.Location = new System.Drawing.Point(50, 107);
            this.Relations.Name = "Relations";
            this.Relations.Size = new System.Drawing.Size(180, 129);
            this.Relations.TabIndex = 1;
            this.Relations.SelectedIndexChanged += new System.EventHandler(this.Relations_SelectedIndexChanged);
            // 
            // HistoryBox
            // 
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.ItemHeight = 25;
            this.HistoryBox.Location = new System.Drawing.Point(330, 107);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(180, 129);
            this.HistoryBox.TabIndex = 2;
            this.HistoryBox.SelectedIndexChanged += new System.EventHandler(this.HistoryBox_SelectedIndexChanged);
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(88, 303);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(65, 25);
            this.Details.TabIndex = 3;
            this.Details.Text = "Details";
            // 
            // ExitToMenuButton
            // 
            this.ExitToMenuButton.Location = new System.Drawing.Point(676, 366);
            this.ExitToMenuButton.Name = "ExitToMenuButton";
            this.ExitToMenuButton.Size = new System.Drawing.Size(112, 34);
            this.ExitToMenuButton.TabIndex = 4;
            this.ExitToMenuButton.Text = "Exit";
            this.ExitToMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMenuButton.Click += new System.EventHandler(this.ExitToMenuButton_Click);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitToMenuButton);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.Relations);
            this.Controls.Add(this.label1);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox Relations;
        private ListBox HistoryBox;
        private Label Details;
        private Button ExitToMenuButton;
    }
}