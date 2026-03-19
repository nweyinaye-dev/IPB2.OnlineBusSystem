namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.User
{
    partial class BookingForm
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
            lblSeatNo = new Label();
            txtSeatNo = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPhoneno = new Label();
            txtPhoneno = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSubmit = new Button();
            btnEditPassenger = new Button();
            btnDeletePassenger = new Button();
            listViewPassengers = new ListView();
            SeatNo = new ColumnHeader();
            Username = new ColumnHeader();
            Phoneno = new ColumnHeader();
            SuspendLayout();
            // 
            // lblSeatNo
            // 
            lblSeatNo.AutoSize = true;
            lblSeatNo.Location = new Point(30, 30);
            lblSeatNo.Name = "lblSeatNo";
            lblSeatNo.Size = new Size(77, 25);
            lblSeatNo.TabIndex = 0;
            lblSeatNo.Text = "Seat No:";
            // 
            // txtSeatNo
            // 
            txtSeatNo.Location = new Point(130, 27);
            txtSeatNo.Name = "txtSeatNo";
            txtSeatNo.Size = new Size(200, 31);
            txtSeatNo.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPhoneno
            // 
            lblPhoneno.AutoSize = true;
            lblPhoneno.Location = new Point(30, 130);
            lblPhoneno.Name = "lblPhoneno";
            lblPhoneno.Size = new Size(95, 25);
            lblPhoneno.TabIndex = 4;
            lblPhoneno.Text = "Phone No:";
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(130, 127);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(200, 31);
            txtPhoneno.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(130, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditPassenger
            // 
            btnEditPassenger.Location = new Point(248, 175);
            btnEditPassenger.Name = "btnEditPassenger";
            btnEditPassenger.Size = new Size(112, 34);
            btnEditPassenger.TabIndex = 10;
            btnEditPassenger.Text = "Edit";
            btnEditPassenger.UseVisualStyleBackColor = true;
            btnEditPassenger.Click += btnEditPassenger_Click;
            // 
            // btnDeletePassenger
            // 
            btnDeletePassenger.Location = new Point(366, 175);
            btnDeletePassenger.Name = "btnDeletePassenger";
            btnDeletePassenger.Size = new Size(112, 34);
            btnDeletePassenger.TabIndex = 11;
            btnDeletePassenger.Text = "Delete";
            btnDeletePassenger.UseVisualStyleBackColor = true;
            btnDeletePassenger.Click += btnDeletePassenger_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(570, 480);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(450, 480);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // listViewPassengers
            // 
            listViewPassengers.Columns.AddRange(new ColumnHeader[] { SeatNo, Username, Phoneno });
            listViewPassengers.FullRowSelect = true;
            listViewPassengers.Location = new Point(30, 225);
            listViewPassengers.Name = "listViewPassengers";
            listViewPassengers.Size = new Size(652, 230);
            listViewPassengers.TabIndex = 9;
            listViewPassengers.UseCompatibleStateImageBehavior = false;
            listViewPassengers.View = View.Details;
            // 
            // SeatNo
            // 
            SeatNo.Text = "SeatNo";
            SeatNo.Width = 100;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 250;
            // 
            // Phoneno
            // 
            Phoneno.Text = "Phoneno";
            Phoneno.Width = 250;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 540);
            Controls.Add(btnDeletePassenger);
            Controls.Add(btnEditPassenger);
            Controls.Add(listViewPassengers);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtPhoneno);
            Controls.Add(lblPhoneno);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtSeatNo);
            Controls.Add(lblSeatNo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Passenger Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeatNo;
        private TextBox txtSeatNo;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPhoneno;
        private TextBox txtPhoneno;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSubmit;
        private ListView listViewPassengers;
        private ColumnHeader SeatNo;
        private ColumnHeader Username;
        private ColumnHeader Phoneno;
        private Button btnEditPassenger;
        private Button btnDeletePassenger;
    }
}
