namespace newthing
{
    partial class TutorMenu
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
            this.SupervisorViewButton = new System.Windows.Forms.Button();
            this.EngagBox = new System.Windows.Forms.ListBox();
            this.NotifSelectButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NotifBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupervisorViewButton
            // 
            this.SupervisorViewButton.Location = new System.Drawing.Point(242, 345);
            this.SupervisorViewButton.Name = "SupervisorViewButton";
            this.SupervisorViewButton.Size = new System.Drawing.Size(155, 61);
            this.SupervisorViewButton.TabIndex = 19;
            this.SupervisorViewButton.Text = "Supervisor view";
            this.SupervisorViewButton.UseVisualStyleBackColor = true;
            this.SupervisorViewButton.Click += new System.EventHandler(this.SupervisorViewButton_Click);
            // 
            // EngagBox
            // 
            this.EngagBox.FormattingEnabled = true;
            this.EngagBox.ItemHeight = 25;
            this.EngagBox.Location = new System.Drawing.Point(423, 123);
            this.EngagBox.Name = "EngagBox";
            this.EngagBox.Size = new System.Drawing.Size(379, 104);
            this.EngagBox.TabIndex = 18;
            // 
            // NotifSelectButton
            // 
            this.NotifSelectButton.Location = new System.Drawing.Point(-1, 258);
            this.NotifSelectButton.Name = "NotifSelectButton";
            this.NotifSelectButton.Size = new System.Drawing.Size(137, 34);
            this.NotifSelectButton.TabIndex = 17;
            this.NotifSelectButton.Text = "View Selected";
            this.NotifSelectButton.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(403, 345);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(165, 61);
            this.BookButton.TabIndex = 16;
            this.BookButton.Text = "BookMeeting";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Notifications";
            // 
            // NotifBox
            // 
            this.NotifBox.FormattingEnabled = true;
            this.NotifBox.ItemHeight = 25;
            this.NotifBox.Location = new System.Drawing.Point(-1, 123);
            this.NotifBox.Name = "NotifBox";
            this.NotifBox.Size = new System.Drawing.Size(398, 129);
            this.NotifBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.Location = new System.Drawing.Point(668, 372);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(112, 34);
            this.MenuExitButton.TabIndex = 20;
            this.MenuExitButton.Text = "Exit";
            this.MenuExitButton.UseVisualStyleBackColor = true;
            this.MenuExitButton.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // TutorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.MenuExitButton);
            this.Controls.Add(this.SupervisorViewButton);
            this.Controls.Add(this.EngagBox);
            this.Controls.Add(this.NotifSelectButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotifBox);
            this.Controls.Add(this.label1);
            this.Name = "TutorMenu";
            this.Text = "TutorMenu";
            this.Load += new System.EventHandler(this.TutorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SupervisorViewButton;
        private ListBox EngagBox;
        private Button NotifSelectButton;
        private Button BookButton;
        private Label label2;
        private ListBox NotifBox;
        private Label label1;
        private Button MenuExitButton;
    }
}