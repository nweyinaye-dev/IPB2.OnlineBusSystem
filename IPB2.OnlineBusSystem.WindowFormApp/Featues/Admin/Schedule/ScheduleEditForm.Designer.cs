namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin.Schedule
{
    partial class ScheduleEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBusName = new Label();
            cboBusName = new ComboBox();
            lblRouteName = new Label();
            cboRouteName = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblFare = new Label();
            txtFare = new TextBox();
            lblArrivalTime = new Label();
            txtArrivalTime = new TextBox();
            lblDepartureTime = new Label();
            txtDepartureTime = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBusName
            // 
            lblBusName.AutoSize = true;
            lblBusName.Location = new Point(30, 30);
            lblBusName.Name = "lblBusName";
            lblBusName.Size = new Size(64, 15);
            lblBusName.TabIndex = 0;
            lblBusName.Text = "Bus Name:";
            // 
            // cboBusName
            // 
            cboBusName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBusName.FormattingEnabled = true;
            cboBusName.Location = new Point(130, 27);
            cboBusName.Name = "cboBusName";
            cboBusName.Size = new Size(200, 23);
            cboBusName.TabIndex = 1;
            // 
            // lblRouteName
            // 
            lblRouteName.AutoSize = true;
            lblRouteName.Location = new Point(30, 70);
            lblRouteName.Name = "lblRouteName";
            lblRouteName.Size = new Size(76, 15);
            lblRouteName.TabIndex = 2;
            lblRouteName.Text = "Route Name:";
            // 
            // cboRouteName
            // 
            cboRouteName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRouteName.FormattingEnabled = true;
            cboRouteName.Location = new Point(130, 67);
            cboRouteName.Name = "cboRouteName";
            cboRouteName.Size = new Size(200, 23);
            cboRouteName.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 110);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(130, 107);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblFare
            // 
            lblFare.AutoSize = true;
            lblFare.Location = new Point(30, 150);
            lblFare.Name = "lblFare";
            lblFare.Size = new Size(32, 15);
            lblFare.TabIndex = 6;
            lblFare.Text = "Fare:";
            // 
            // txtFare
            // 
            txtFare.Location = new Point(130, 147);
            txtFare.Name = "txtFare";
            txtFare.Size = new Size(200, 23);
            txtFare.TabIndex = 7;
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Location = new Point(30, 190);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(74, 15);
            lblArrivalTime.TabIndex = 8;
            lblArrivalTime.Text = "Arrival Time:";
            // 
            // txtArrivalTime
            // 
            txtArrivalTime.Location = new Point(130, 187);
            txtArrivalTime.Name = "txtArrivalTime";
            txtArrivalTime.Size = new Size(200, 23);
            txtArrivalTime.TabIndex = 9;
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Location = new Point(30, 230);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new Size(92, 15);
            lblDepartureTime.TabIndex = 10;
            lblDepartureTime.Text = "Departure Time:";
            // 
            // txtDepartureTime
            // 
            txtDepartureTime.Location = new Point(130, 227);
            txtDepartureTime.Name = "txtDepartureTime";
            txtDepartureTime.Size = new Size(200, 23);
            txtDepartureTime.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(255, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ScheduleEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 330);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDepartureTime);
            Controls.Add(lblDepartureTime);
            Controls.Add(txtArrivalTime);
            Controls.Add(lblArrivalTime);
            Controls.Add(txtFare);
            Controls.Add(lblFare);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cboRouteName);
            Controls.Add(lblRouteName);
            Controls.Add(cboBusName);
            Controls.Add(lblBusName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScheduleEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBusName;
        private ComboBox cboBusName;
        private Label lblRouteName;
        private ComboBox cboRouteName;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblFare;
        private TextBox txtFare;
        private Label lblArrivalTime;
        private TextBox txtArrivalTime;
        private Label lblDepartureTime;
        private TextBox txtDepartureTime;
        private Button btnSave;
        private Button btnCancel;
    }
}
