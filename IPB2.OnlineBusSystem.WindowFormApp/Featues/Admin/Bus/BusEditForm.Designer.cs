namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin
{
    partial class BusEditForm
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
            lblBusNo = new Label();
            txtBusNo = new TextBox();
            lblBusName = new Label();
            txtBusName = new TextBox();
            lblBusType = new Label();
            txtBusType = new TextBox();
            lblTotalSeat = new Label();
            txtTotalSeat = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBusNo
            // 
            lblBusNo.AutoSize = true;
            lblBusNo.Location = new Point(30, 30);
            lblBusNo.Name = "lblBusNo";
            lblBusNo.Size = new Size(48, 15);
            lblBusNo.TabIndex = 0;
            lblBusNo.Text = "Bus No:";
            // 
            // txtBusNo
            // 
            txtBusNo.Location = new Point(120, 27);
            txtBusNo.Name = "txtBusNo";
            txtBusNo.Size = new Size(200, 23);
            txtBusNo.TabIndex = 1;
            // 
            // lblBusName
            // 
            lblBusName.AutoSize = true;
            lblBusName.Location = new Point(30, 70);
            lblBusName.Name = "lblBusName";
            lblBusName.Size = new Size(64, 15);
            lblBusName.TabIndex = 2;
            lblBusName.Text = "Bus Name:";
            // 
            // txtBusName
            // 
            txtBusName.Location = new Point(120, 67);
            txtBusName.Name = "txtBusName";
            txtBusName.Size = new Size(200, 23);
            txtBusName.TabIndex = 3;
            // 
            // lblBusType
            // 
            lblBusType.AutoSize = true;
            lblBusType.Location = new Point(30, 110);
            lblBusType.Name = "lblBusType";
            lblBusType.Size = new Size(56, 15);
            lblBusType.TabIndex = 4;
            lblBusType.Text = "Bus Type:";
            // 
            // txtBusType
            // 
            txtBusType.Location = new Point(120, 107);
            txtBusType.Name = "txtBusType";
            txtBusType.Size = new Size(200, 23);
            txtBusType.TabIndex = 5;
            // 
            // lblTotalSeat
            // 
            lblTotalSeat.AutoSize = true;
            lblTotalSeat.Location = new Point(30, 150);
            lblTotalSeat.Name = "lblTotalSeat";
            lblTotalSeat.Size = new Size(61, 15);
            lblTotalSeat.TabIndex = 6;
            lblTotalSeat.Text = "Total Seat:";
            // 
            // txtTotalSeat
            // 
            txtTotalSeat.Location = new Point(120, 147);
            txtTotalSeat.Name = "txtTotalSeat";
            txtTotalSeat.Size = new Size(200, 23);
            txtTotalSeat.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BusEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 250);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTotalSeat);
            Controls.Add(lblTotalSeat);
            Controls.Add(txtBusType);
            Controls.Add(lblBusType);
            Controls.Add(txtBusName);
            Controls.Add(lblBusName);
            Controls.Add(txtBusNo);
            Controls.Add(lblBusNo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BusEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Bus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBusNo;
        private TextBox txtBusNo;
        private Label lblBusName;
        private TextBox txtBusName;
        private Label lblBusType;
        private TextBox txtBusType;
        private Label lblTotalSeat;
        private TextBox txtTotalSeat;
        private Button btnSave;
        private Button btnCancel;
    }
}
