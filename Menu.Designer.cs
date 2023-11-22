namespace newthing
{
    partial class Menu
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
            this.NotifBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookButton = new System.Windows.Forms.Button();
            this.NotifSelectedButton = new System.Windows.Forms.Button();
            this.EngagBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // NotifBox
            // 
            this.NotifBox.FormattingEnabled = true;
            this.NotifBox.ItemHeight = 25;
            this.NotifBox.Location = new System.Drawing.Point(42, 278);
            this.NotifBox.Name = "NotifBox";
            this.NotifBox.Size = new System.Drawing.Size(373, 129);
            this.NotifBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notifications";
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(548, 155);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(156, 67);
            this.BookButton.TabIndex = 3;
            this.BookButton.Text = "BookMeeting";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // NotifSelectedButton
            // 
            this.NotifSelectedButton.Location = new System.Drawing.Point(303, 238);
            this.NotifSelectedButton.Name = "NotifSelectedButton";
            this.NotifSelectedButton.Size = new System.Drawing.Size(112, 34);
            this.NotifSelectedButton.TabIndex = 4;
            this.NotifSelectedButton.Text = "View ";
            this.NotifSelectedButton.UseVisualStyleBackColor = true;
            this.NotifSelectedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EngagBox
            // 
            this.EngagBox.FormattingEnabled = true;
            this.EngagBox.ItemHeight = 25;
            this.EngagBox.Location = new System.Drawing.Point(434, 278);
            this.EngagBox.Name = "EngagBox";
            this.EngagBox.Size = new System.Drawing.Size(354, 104);
            this.EngagBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Engagements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notifications";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EngagBox);
            this.Controls.Add(this.NotifSelectedButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotifBox);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox NotifBox;
        private Label label2;
        private Button BookButton;
        private Button NotifSelectedButton;
        private ListBox EngagBox;
        private Label label3;
        private Label label4;
    }
}