namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.User
{
    partial class User
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
            cboRouteOrigin = new ComboBox();
            cboRouteDestination = new ComboBox();
            dtpTravelDate = new DateTimePicker();
            btnBkSearch = new Button();
            btnBkCancel = new Button();
            btnBook = new Button();
            listView1 = new ListView();
            BusNo = new ColumnHeader();
            BusName = new ColumnHeader();
            DepartureTime = new ColumnHeader();
            ArrivalTime = new ColumnHeader();
            AvaliableSeat = new ColumnHeader();
            Fare = new ColumnHeader();
            BusType = new ColumnHeader();
            Date = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBookList = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cboRouteOrigin
            // 
            cboRouteOrigin.FormattingEnabled = true;
            cboRouteOrigin.Location = new Point(199, 121);
            cboRouteOrigin.Name = "cboRouteOrigin";
            cboRouteOrigin.Size = new Size(182, 33);
            cboRouteOrigin.TabIndex = 0;
            // 
            // cboRouteDestination
            // 
            cboRouteDestination.FormattingEnabled = true;
            cboRouteDestination.Location = new Point(411, 121);
            cboRouteDestination.Name = "cboRouteDestination";
            cboRouteDestination.Size = new Size(182, 33);
            cboRouteDestination.TabIndex = 1;
            // 
            // dtpTravelDate
            // 
            dtpTravelDate.Format = DateTimePickerFormat.Short;
            dtpTravelDate.Location = new Point(34, 121);
            dtpTravelDate.Name = "dtpTravelDate";
            dtpTravelDate.Size = new Size(149, 31);
            dtpTravelDate.TabIndex = 9;
            // 
            // btnBkSearch
            // 
            btnBkSearch.Location = new Point(610, 120);
            btnBkSearch.Name = "btnBkSearch";
            btnBkSearch.Size = new Size(112, 34);
            btnBkSearch.TabIndex = 2;
            btnBkSearch.Text = "Search";
            btnBkSearch.UseVisualStyleBackColor = true;
            btnBkSearch.Click += btnBkSearch_Click;
            // 
            // btnBkCancel
            // 
            btnBkCancel.Location = new Point(728, 119);
            btnBkCancel.Name = "btnBkCancel";
            btnBkCancel.Size = new Size(112, 34);
            btnBkCancel.TabIndex = 3;
            btnBkCancel.Text = "Cancel";
            btnBkCancel.UseVisualStyleBackColor = true;
            btnBkCancel.Click += btnBkCancel_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(846, 121);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(112, 34);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { BusNo, BusName, DepartureTime, ArrivalTime, AvaliableSeat, Fare, BusType });
            listView1.Location = new Point(27, 187);
            listView1.Name = "listView1";
            listView1.Size = new Size(931, 334);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // BusNo
            // 
            BusNo.Text = "BusNo";
            BusNo.Width = 120;
            // 
            // BusName
            // 
            BusName.Text = "BusName";
            BusName.Width = 120;
            // 
            // DepartureTime
            // 
            DepartureTime.DisplayIndex = 4;
            DepartureTime.Text = "DepartureTime";
            DepartureTime.Width = 130;
            // 
            // ArrivalTime
            // 
            ArrivalTime.Text = "ArrivalTime";
            ArrivalTime.Width = 130;
            // 
            // AvaliableSeat
            // 
            AvaliableSeat.DisplayIndex = 6;
            AvaliableSeat.Text = "AvaliableSeat";
            AvaliableSeat.Width = 120;
            // 
            // Fare
            // 
            Fare.Text = "Fare";
            Fare.Width = 120;
            // 
            // BusType
            // 
            BusType.DisplayIndex = 2;
            BusType.Text = "BusType";
            BusType.Width = 120;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(35, 75);
            Date.Name = "Date";
            Date.Size = new Size(49, 25);
            Date.TabIndex = 6;
            Date.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 75);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Origin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 75);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 8;
            label3.Text = "Destination";
            // 
            // btnBookList
            // 
            btnBookList.Location = new Point(767, 22);
            btnBookList.Name = "btnBookList";
            btnBookList.Size = new Size(191, 34);
            btnBookList.TabIndex = 10;
            btnBookList.Text = "Booked List";
            btnBookList.UseVisualStyleBackColor = true;
            btnBookList.Click += btnBookList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 11;
            label1.Text = "Booking Form";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 616);
            Controls.Add(label1);
            Controls.Add(btnBookList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Date);
            Controls.Add(listView1);
            Controls.Add(btnBook);
            Controls.Add(btnBkCancel);
            Controls.Add(btnBkSearch);
            Controls.Add(cboRouteDestination);
            Controls.Add(cboRouteOrigin);
            Controls.Add(dtpTravelDate);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboRouteOrigin;
        private ComboBox cboRouteDestination;
        private Button btnBkSearch;
        private Button btnBkCancel;
        private Button btnBook;
        private ListView listView1;
        private Label Date;
        private Label label2;
        private Label label3;
        private ColumnHeader BusNo;
        private ColumnHeader BusName;
        private ColumnHeader DepartureTime;
        private ColumnHeader ArrivalTime;
        private ColumnHeader AvaliableSeat;
        private ColumnHeader Fare;
        private DateTimePicker dtpTravelDate;
        private ColumnHeader BusType;
        private Button btnBookList;
        private Label label1;
    }
}