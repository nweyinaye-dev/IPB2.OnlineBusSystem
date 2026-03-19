namespace IPB2.OnlineBusSystem.WindowFormApp
{
    partial class MainMaster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdmin = new Button();
            btnUser = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(113, 335);
            btnAdmin.Margin = new Padding(4, 5, 4, 5);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(107, 38);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(357, 335);
            btnUser.Margin = new Padding(4, 5, 4, 5);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(107, 38);
            btnUser.TabIndex = 1;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(199, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 2;
            label1.Text = "Online Bus System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 25);
            label2.TabIndex = 3;
            label2.Text = "Please choose your role !!!";
            // 
            // MainMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 508);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUser);
            Controls.Add(btnAdmin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Bus System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Button btnUser;
        private Label label1;
        private Label label2;
    }
}
