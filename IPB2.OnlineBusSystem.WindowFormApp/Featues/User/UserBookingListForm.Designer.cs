namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.User
{
    partial class UserBookingListForm
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
            txtUsername = new TextBox();
            txtPhoneno = new TextBox();
            btnSearch = new Button();
            listViewBookings = new ListView();
            TravelDate = new ColumnHeader();
            Username = new ColumnHeader();
            Phoneno = new ColumnHeader();
            SeatNo = new ColumnHeader();
            BusNo = new ColumnHeader();
            BusName = new ColumnHeader();
            BusType = new ColumnHeader();
            ArrivalTime = new ColumnHeader();
            DepartureTime = new ColumnHeader();
            Fare = new ColumnHeader();
            Origin = new ColumnHeader();
            Destination = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(141, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(486, 30);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(200, 31);
            txtPhoneno.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(718, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listViewBookings
            // 
            listViewBookings.Columns.AddRange(new ColumnHeader[] { TravelDate, Username, Phoneno, SeatNo, BusNo, BusName, BusType, ArrivalTime, DepartureTime, Fare, Origin, Destination });
            listViewBookings.FullRowSelect = true;
            listViewBookings.GridLines = true;
            listViewBookings.Location = new Point(24, 88);
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(1150, 450);
            listViewBookings.TabIndex = 3;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            listViewBookings.View = View.Details;
            // 
            // TravelDate
            // 
            TravelDate.Text = "TravelDate";
            TravelDate.Width = 110;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 110;
            // 
            // Phoneno
            // 
            Phoneno.Text = "Phone";
            Phoneno.Width = 110;
            // 
            // SeatNo
            // 
            SeatNo.Text = "Seat";
            SeatNo.Width = 80;
            // 
            // BusNo
            // 
            BusNo.Text = "BusNo";
            BusNo.Width = 100;
            // 
            // BusName
            // 
            BusName.Text = "BusName";
            BusName.Width = 120;
            // 
            // BusType
            // 
            BusType.Text = "BusType";
            BusType.Width = 100;
            // 
            // ArrivalTime
            // 
            ArrivalTime.Text = "Arrival";
            ArrivalTime.Width = 100;
            // 
            // DepartureTime
            // 
            DepartureTime.Text = "Departure";
            DepartureTime.Width = 100;
            // 
            // Fare
            // 
            Fare.Text = "Fare";
            Fare.Width = 100;
            // 
            // Origin
            // 
            Origin.Text = "Origin";
            Origin.Width = 110;
            // 
            // Destination
            // 
            Destination.Text = "Destination";
            Destination.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Phone No";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1062, 555);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UserBookingListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 610);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewBookings);
            Controls.Add(btnSearch);
            Controls.Add(txtPhoneno);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserBookingListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Booked Seats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPhoneno;
        private Button btnSearch;
        private ListView listViewBookings;
        private ColumnHeader TravelDate;
        private ColumnHeader Username;
        private ColumnHeader Phoneno;
        private ColumnHeader SeatNo;
        private ColumnHeader BusNo;
        private ColumnHeader BusName;
        private ColumnHeader BusType;
        private ColumnHeader ArrivalTime;
        private ColumnHeader DepartureTime;
        private ColumnHeader Fare;
        private ColumnHeader Origin;
        private ColumnHeader Destination;
        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}
