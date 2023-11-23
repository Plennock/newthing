namespace newthing
{
    partial class SupervisorMenu
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
            this.EngagBox = new System.Windows.Forms.ListBox();
            this.NotifSelectedButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NotifBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentViewButton = new System.Windows.Forms.Button();
            this.ReportMaker = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EngagBox
            // 
            this.EngagBox.FormattingEnabled = true;
            this.EngagBox.ItemHeight = 25;
            this.EngagBox.Location = new System.Drawing.Point(443, 122);
            this.EngagBox.Name = "EngagBox";
            this.EngagBox.Size = new System.Drawing.Size(379, 104);
            this.EngagBox.TabIndex = 11;
            this.EngagBox.SelectedIndexChanged += new System.EventHandler(this.EngagBox_SelectedIndexChanged);
            // 
            // NotifSelectedButton
            // 
            this.NotifSelectedButton.Location = new System.Drawing.Point(19, 257);
            this.NotifSelectedButton.Name = "NotifSelectedButton";
            this.NotifSelectedButton.Size = new System.Drawing.Size(137, 34);
            this.NotifSelectedButton.TabIndex = 10;
            this.NotifSelectedButton.Text = "View Selected";
            this.NotifSelectedButton.UseVisualStyleBackColor = true;
            this.NotifSelectedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(423, 344);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(181, 67);
            this.BookButton.TabIndex = 9;
            this.BookButton.Text = "BookMeeting";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notifications";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NotifBox
            // 
            this.NotifBox.FormattingEnabled = true;
            this.NotifBox.ItemHeight = 25;
            this.NotifBox.Location = new System.Drawing.Point(19, 122);
            this.NotifBox.Name = "NotifBox";
            this.NotifBox.Size = new System.Drawing.Size(398, 129);
            this.NotifBox.TabIndex = 7;
            this.NotifBox.SelectedIndexChanged += new System.EventHandler(this.NotifBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentViewButton
            // 
            this.StudentViewButton.Location = new System.Drawing.Point(262, 344);
            this.StudentViewButton.Name = "StudentViewButton";
            this.StudentViewButton.Size = new System.Drawing.Size(155, 61);
            this.StudentViewButton.TabIndex = 12;
            this.StudentViewButton.Text = "Student view";
            this.StudentViewButton.UseVisualStyleBackColor = true;
            this.StudentViewButton.Click += new System.EventHandler(this.StudentViewButton_Click);
            // 
            // ReportMaker
            // 
            this.ReportMaker.Location = new System.Drawing.Point(92, 346);
            this.ReportMaker.Name = "ReportMaker";
            this.ReportMaker.Size = new System.Drawing.Size(142, 57);
            this.ReportMaker.TabIndex = 13;
            this.ReportMaker.Text = "Create Report";
            this.ReportMaker.UseVisualStyleBackColor = true;
            this.ReportMaker.Click += new System.EventHandler(this.ReportMaker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Engagements";
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.Location = new System.Drawing.Point(685, 388);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(112, 34);
            this.MenuExitButton.TabIndex = 15;
            this.MenuExitButton.Text = "Exit";
            this.MenuExitButton.UseVisualStyleBackColor = true;
            this.MenuExitButton.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // SupervisorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.MenuExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportMaker);
            this.Controls.Add(this.StudentViewButton);
            this.Controls.Add(this.EngagBox);
            this.Controls.Add(this.NotifSelectedButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotifBox);
            this.Controls.Add(this.label1);
            this.Name = "SupervisorMenu";
            this.Text = "SupervisorMenu";
            this.Load += new System.EventHandler(this.SupervisorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox EngagBox;
        private Button NotifSelectedButton;
        private Button BookButton;
        private Label label2;
        private ListBox NotifBox;
        private Label label1;
        private Button StudentViewButton;
        private Button ReportMaker;
        private Label label3;
        private Button MenuExitButton;
    }
}