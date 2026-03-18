namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin
{
    partial class RouteNewForm
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
            lblRouteName = new Label();
            txtRouteName = new TextBox();
            lblOrigin = new Label();
            txtOrigin = new TextBox();
            lblDestination = new Label();
            txtDestination = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblRouteName
            // 
            lblRouteName.AutoSize = true;
            lblRouteName.Location = new Point(30, 30);
            lblRouteName.Name = "lblRouteName";
            lblRouteName.Size = new Size(76, 15);
            lblRouteName.TabIndex = 0;
            lblRouteName.Text = "Route Name:";
            // 
            // txtRouteName
            // 
            txtRouteName.Location = new Point(120, 27);
            txtRouteName.Name = "txtRouteName";
            txtRouteName.Size = new Size(200, 23);
            txtRouteName.TabIndex = 1;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(30, 70);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(43, 15);
            lblOrigin.TabIndex = 2;
            lblOrigin.Text = "Origin:";
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(120, 67);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(200, 23);
            txtOrigin.TabIndex = 3;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(30, 110);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(70, 15);
            lblDestination.TabIndex = 4;
            lblDestination.Text = "Destination:";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(120, 107);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(200, 23);
            txtDestination.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RouteNewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 210);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDestination);
            Controls.Add(lblDestination);
            Controls.Add(txtOrigin);
            Controls.Add(lblOrigin);
            Controls.Add(txtRouteName);
            Controls.Add(lblRouteName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RouteNewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Route";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRouteName;
        private TextBox txtRouteName;
        private Label lblOrigin;
        private TextBox txtOrigin;
        private Label lblDestination;
        private TextBox txtDestination;
        private Button btnSave;
        private Button btnCancel;
    }
}
