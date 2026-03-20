namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            Bus = new TabControl();
            tabPage1 = new TabPage();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtBusSearchText = new TextBox();
            listView1 = new ListView();
            BusNo = new ColumnHeader();
            BusName = new ColumnHeader();
            BusType = new ColumnHeader();
            TotalSeat = new ColumnHeader();
            edit = new ContextMenuStrip(components);
            btnBusCancel = new Button();
            btnBusSearch = new Button();
            tabPage2 = new TabPage();
            listView2 = new ListView();
            RouteName = new ColumnHeader();
            Origin = new ColumnHeader();
            Destination = new ColumnHeader();
            btnRouteDelete = new Button();
            btnRouteUpdate = new Button();
            btnRouteCreate = new Button();
            tabPage3 = new TabPage();
            listView3 = new ListView();
            AvaliableBusName = new ColumnHeader();
            Date = new ColumnHeader();
            Fare = new ColumnHeader();
            ArrivalTime = new ColumnHeader();
            DepatureTime = new ColumnHeader();
            Route = new ColumnHeader();
            AvaliableSeat = new ColumnHeader();
            BookedSeat = new ColumnHeader();
            AvaliableBusNo = new ColumnHeader();
            btnSchDelete = new Button();
            btnSchCreate = new Button();
            btnSchCancel = new Button();
            btnSchUpdate = new Button();
            btnSchSearch = new Button();
            dtpScheduleDate = new DateTimePicker();
            tabPage4 = new TabPage();
            btnBkCancel = new Button();
            btnBkSearch = new Button();
            txtBkSearch = new TextBox();
            listView4 = new ListView();
            TravelDate = new ColumnHeader();
            Username = new ColumnHeader();
            Phoneno = new ColumnHeader();
            SeatNo = new ColumnHeader();
            BookedBusNo = new ColumnHeader();
            BookedBusName = new ColumnHeader();
            BookedBusType = new ColumnHeader();
            BookedArrivalTime = new ColumnHeader();
            BookedDepartureTime = new ColumnHeader();
            BookedFare = new ColumnHeader();
            BookedOrigin = new ColumnHeader();
            BookedDestination = new ColumnHeader();
            btnRouteCancel = new Button();
            btnRouteSearch = new Button();
            textBox2 = new TextBox();
            ID = new ColumnHeader();
            delete = new ContextMenuStrip(components);
            Bus.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // Bus
            // 
            Bus.Controls.Add(tabPage1);
            Bus.Controls.Add(tabPage2);
            Bus.Controls.Add(tabPage3);
            Bus.Controls.Add(tabPage4);
            Bus.Location = new Point(17, 20);
            Bus.Margin = new Padding(4, 5, 4, 5);
            Bus.Name = "Bus";
            Bus.SelectedIndex = 0;
            Bus.Size = new Size(1096, 710);
            Bus.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(txtBusSearchText);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(btnBusCancel);
            tabPage1.Controls.Add(btnBusSearch);
            tabPage1.Font = new Font("Segoe UI", 9F);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1088, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bus";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(620, 52);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 38);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(851, 50);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(736, 52);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBusSearchText
            // 
            txtBusSearchText.Location = new Point(46, 52);
            txtBusSearchText.Margin = new Padding(4, 5, 4, 5);
            txtBusSearchText.Name = "txtBusSearchText";
            txtBusSearchText.Size = new Size(307, 31);
            txtBusSearchText.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { BusNo, BusName, BusType, TotalSeat });
            listView1.ContextMenuStrip = edit;
            listView1.Font = new Font("Segoe UI", 9F);
            listView1.Location = new Point(46, 122);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(911, 491);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
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
            // BusType
            // 
            BusType.Text = "BusType";
            BusType.Width = 120;
            // 
            // TotalSeat
            // 
            TotalSeat.Text = "TotalSeat";
            TotalSeat.Width = 120;
            // 
            // edit
            // 
            edit.ImageScalingSize = new Size(24, 24);
            edit.Name = "contextMenuStrip1";
            edit.Size = new Size(61, 4);
            edit.Text = "Edit";
            // 
            // btnBusCancel
            // 
            btnBusCancel.Location = new Point(479, 52);
            btnBusCancel.Margin = new Padding(4, 5, 4, 5);
            btnBusCancel.Name = "btnBusCancel";
            btnBusCancel.Size = new Size(107, 38);
            btnBusCancel.TabIndex = 2;
            btnBusCancel.Text = "Cancel";
            btnBusCancel.UseVisualStyleBackColor = true;
            btnBusCancel.Click += btnBusCancel_Click;
            // 
            // btnBusSearch
            // 
            btnBusSearch.Location = new Point(363, 52);
            btnBusSearch.Margin = new Padding(4, 5, 4, 5);
            btnBusSearch.Name = "btnBusSearch";
            btnBusSearch.Size = new Size(107, 38);
            btnBusSearch.TabIndex = 1;
            btnBusSearch.Text = "Search";
            btnBusSearch.UseVisualStyleBackColor = true;
            btnBusSearch.Click += btnBusSearch_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(btnRouteDelete);
            tabPage2.Controls.Add(btnRouteUpdate);
            tabPage2.Controls.Add(btnRouteCreate);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1088, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Route";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { RouteName, Origin, Destination });
            listView2.Location = new Point(40, 108);
            listView2.Margin = new Padding(4, 5, 4, 5);
            listView2.Name = "listView2";
            listView2.Size = new Size(785, 411);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // RouteName
            // 
            RouteName.Text = "RouteName";
            RouteName.Width = 150;
            // 
            // Origin
            // 
            Origin.Text = "Origin";
            Origin.Width = 150;
            // 
            // Destination
            // 
            Destination.Text = "Destination";
            Destination.Width = 150;
            // 
            // btnRouteDelete
            // 
            btnRouteDelete.Location = new Point(719, 37);
            btnRouteDelete.Margin = new Padding(4, 5, 4, 5);
            btnRouteDelete.Name = "btnRouteDelete";
            btnRouteDelete.Size = new Size(107, 38);
            btnRouteDelete.TabIndex = 5;
            btnRouteDelete.Text = "Delete";
            btnRouteDelete.UseVisualStyleBackColor = true;
            btnRouteDelete.Click += btnRouteDelete_Click;
            // 
            // btnRouteUpdate
            // 
            btnRouteUpdate.Location = new Point(581, 37);
            btnRouteUpdate.Margin = new Padding(4, 5, 4, 5);
            btnRouteUpdate.Name = "btnRouteUpdate";
            btnRouteUpdate.Size = new Size(107, 38);
            btnRouteUpdate.TabIndex = 4;
            btnRouteUpdate.Text = "Update";
            btnRouteUpdate.UseVisualStyleBackColor = true;
            btnRouteUpdate.Click += btnRouteUpdate_Click;
            // 
            // btnRouteCreate
            // 
            btnRouteCreate.Location = new Point(446, 37);
            btnRouteCreate.Margin = new Padding(4, 5, 4, 5);
            btnRouteCreate.Name = "btnRouteCreate";
            btnRouteCreate.Size = new Size(107, 38);
            btnRouteCreate.TabIndex = 3;
            btnRouteCreate.Text = "New";
            btnRouteCreate.UseVisualStyleBackColor = true;
            btnRouteCreate.Click += btnRouteCreate_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listView3);
            tabPage3.Controls.Add(btnSchDelete);
            tabPage3.Controls.Add(btnSchCreate);
            tabPage3.Controls.Add(btnSchCancel);
            tabPage3.Controls.Add(btnSchUpdate);
            tabPage3.Controls.Add(btnSchSearch);
            tabPage3.Controls.Add(dtpScheduleDate);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(1088, 672);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Schedule";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { AvaliableBusName, Date, Fare, ArrivalTime, DepatureTime, Route, AvaliableSeat, BookedSeat, AvaliableBusNo });
            listView3.Location = new Point(27, 115);
            listView3.Margin = new Padding(4, 5, 4, 5);
            listView3.Name = "listView3";
            listView3.Size = new Size(1034, 512);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // AvaliableBusName
            // 
            AvaliableBusName.DisplayIndex = 1;
            AvaliableBusName.Text = "BusName";
            AvaliableBusName.Width = 120;
            // 
            // Date
            // 
            Date.DisplayIndex = 2;
            Date.Text = "Date";
            Date.Width = 120;
            // 
            // Fare
            // 
            Fare.DisplayIndex = 3;
            Fare.Text = "Fare";
            Fare.Width = 120;
            // 
            // ArrivalTime
            // 
            ArrivalTime.DisplayIndex = 4;
            ArrivalTime.Text = "ArrivalTime";
            ArrivalTime.Width = 120;
            // 
            // DepatureTime
            // 
            DepatureTime.DisplayIndex = 5;
            DepatureTime.Text = "DepatureTime";
            DepatureTime.Width = 130;
            // 
            // Route
            // 
            Route.DisplayIndex = 6;
            Route.Text = "Route";
            Route.Width = 120;
            // 
            // AvaliableSeat
            // 
            AvaliableSeat.DisplayIndex = 7;
            AvaliableSeat.Text = "AvaliableSeat";
            AvaliableSeat.Width = 120;
            // 
            // BookedSeat
            // 
            BookedSeat.DisplayIndex = 8;
            BookedSeat.Text = "BookedSeat";
            BookedSeat.Width = 120;
            // 
            // AvaliableBusNo
            // 
            AvaliableBusNo.DisplayIndex = 0;
            AvaliableBusNo.Text = "BusNo";
            AvaliableBusNo.Width = 120;
            // 
            // btnSchDelete
            // 
            btnSchDelete.Location = new Point(883, 32);
            btnSchDelete.Margin = new Padding(4, 5, 4, 5);
            btnSchDelete.Name = "btnSchDelete";
            btnSchDelete.Size = new Size(107, 38);
            btnSchDelete.TabIndex = 5;
            btnSchDelete.Text = "Delete";
            btnSchDelete.UseVisualStyleBackColor = true;
            btnSchDelete.Click += btnSchDelete_Click;
            // 
            // btnSchCreate
            // 
            btnSchCreate.Location = new Point(624, 33);
            btnSchCreate.Margin = new Padding(4, 5, 4, 5);
            btnSchCreate.Name = "btnSchCreate";
            btnSchCreate.Size = new Size(107, 38);
            btnSchCreate.TabIndex = 4;
            btnSchCreate.Text = "New";
            btnSchCreate.UseVisualStyleBackColor = true;
            btnSchCreate.Click += btnSchCreate_Click;
            // 
            // btnSchCancel
            // 
            btnSchCancel.Location = new Point(493, 33);
            btnSchCancel.Margin = new Padding(4, 5, 4, 5);
            btnSchCancel.Name = "btnSchCancel";
            btnSchCancel.Size = new Size(107, 38);
            btnSchCancel.TabIndex = 3;
            btnSchCancel.Text = "Cancel";
            btnSchCancel.UseVisualStyleBackColor = true;
            btnSchCancel.Click += btnSchCancel_Click;
            // 
            // btnSchUpdate
            // 
            btnSchUpdate.Location = new Point(754, 32);
            btnSchUpdate.Margin = new Padding(4, 5, 4, 5);
            btnSchUpdate.Name = "btnSchUpdate";
            btnSchUpdate.Size = new Size(107, 38);
            btnSchUpdate.TabIndex = 2;
            btnSchUpdate.Text = "Update";
            btnSchUpdate.UseVisualStyleBackColor = true;
            btnSchUpdate.Click += btnSchUpdate_Click;
            // 
            // btnSchSearch
            // 
            btnSchSearch.Location = new Point(360, 33);
            btnSchSearch.Margin = new Padding(4, 5, 4, 5);
            btnSchSearch.Name = "btnSchSearch";
            btnSchSearch.Size = new Size(107, 38);
            btnSchSearch.TabIndex = 1;
            btnSchSearch.Text = "Search";
            btnSchSearch.UseVisualStyleBackColor = true;
            btnSchSearch.Click += btnSchSearch_Click;
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.Format = DateTimePickerFormat.Short;
            dtpScheduleDate.Location = new Point(53, 33);
            dtpScheduleDate.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.Size = new Size(267, 31);
            dtpScheduleDate.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnBkCancel);
            tabPage4.Controls.Add(btnBkSearch);
            tabPage4.Controls.Add(txtBkSearch);
            tabPage4.Controls.Add(listView4);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1088, 672);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Booking";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Enter += tabPage4_Enter;
            // 
            // btnBkCancel
            // 
            btnBkCancel.Location = new Point(611, 38);
            btnBkCancel.Name = "btnBkCancel";
            btnBkCancel.Size = new Size(112, 34);
            btnBkCancel.TabIndex = 3;
            btnBkCancel.Text = "Cancel";
            btnBkCancel.UseVisualStyleBackColor = true;
            btnBkCancel.Click += btnBkCancel_Click;
            // 
            // btnBkSearch
            // 
            btnBkSearch.Location = new Point(436, 37);
            btnBkSearch.Name = "btnBkSearch";
            btnBkSearch.Size = new Size(112, 34);
            btnBkSearch.TabIndex = 2;
            btnBkSearch.Text = "Search";
            btnBkSearch.UseVisualStyleBackColor = true;
            btnBkSearch.Click += btnBkSearch_Click;
            // 
            // txtBkSearch
            // 
            txtBkSearch.Location = new Point(67, 40);
            txtBkSearch.Name = "txtBkSearch";
            txtBkSearch.Size = new Size(307, 31);
            txtBkSearch.TabIndex = 1;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { TravelDate, Username, Phoneno, SeatNo, BookedBusNo, BookedBusName, BookedBusType, BookedArrivalTime, BookedDepartureTime, BookedFare, BookedOrigin, BookedDestination });
            listView4.Location = new Point(23, 110);
            listView4.Name = "listView4";
            listView4.Size = new Size(1037, 511);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // TravelDate
            // 
            TravelDate.Text = "TravelDate";
            TravelDate.Width = 120;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 120;
            // 
            // Phoneno
            // 
            Phoneno.Text = "Phoneno";
            Phoneno.Width = 130;
            // 
            // SeatNo
            // 
            SeatNo.Text = "SeatNo";
            SeatNo.Width = 100;
            // 
            // BookedBusNo
            // 
            BookedBusNo.Text = "BusNo";
            BookedBusNo.Width = 120;
            // 
            // BookedBusName
            // 
            BookedBusName.Text = "BusName";
            BookedBusName.Width = 120;
            // 
            // BookedBusType
            // 
            BookedBusType.Text = "BusType";
            BookedBusType.Width = 120;
            // 
            // BookedArrivalTime
            // 
            BookedArrivalTime.Text = "Arrival";
            BookedArrivalTime.Width = 120;
            // 
            // BookedDepartureTime
            // 
            BookedDepartureTime.Text = "Departure";
            BookedDepartureTime.Width = 120;
            // 
            // BookedFare
            // 
            BookedFare.Text = "Fare";
            BookedFare.Width = 100;
            // 
            // BookedOrigin
            // 
            BookedOrigin.Text = "Origin";
            BookedOrigin.Width = 120;
            // 
            // BookedDestination
            // 
            BookedDestination.Text = "Destination";
            BookedDestination.Width = 120;
            // 
            // btnRouteCancel
            // 
            btnRouteCancel.Location = new Point(316, 22);
            btnRouteCancel.Name = "btnRouteCancel";
            btnRouteCancel.Size = new Size(75, 23);
            btnRouteCancel.TabIndex = 2;
            btnRouteCancel.Text = "Cancel";
            btnRouteCancel.UseVisualStyleBackColor = true;
            btnRouteCancel.Click += btnRouteCancel_Click;
            // 
            // btnRouteSearch
            // 
            btnRouteSearch.Location = new Point(223, 23);
            btnRouteSearch.Name = "btnRouteSearch";
            btnRouteSearch.Size = new Size(75, 23);
            btnRouteSearch.TabIndex = 1;
            btnRouteSearch.Text = "Search";
            btnRouteSearch.UseVisualStyleBackColor = true;
            btnRouteSearch.Click += btnRouteSearch_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 31);
            textBox2.TabIndex = 0;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 120;
            // 
            // delete
            // 
            delete.ImageScalingSize = new Size(24, 24);
            delete.Name = "delete";
            delete.Size = new Size(61, 4);
            delete.Text = "delete";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 895);
            Controls.Add(Bus);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Bus.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Bus;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listView1;
        private Button btnBusCancel;
        private Button btnBusSearch;
        private ColumnHeader BusNo;
        private ColumnHeader ID;
        private ColumnHeader BusName;
        private ColumnHeader BusType;
        private ColumnHeader TotalSeat;
        private TextBox txtBusSearchText;
        private ContextMenuStrip edit;
        private ContextMenuStrip delete;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnRouteDelete;
        private Button btnRouteUpdate;
        private Button btnRouteCreate;
        private Button btnRouteCancel;
        private Button btnRouteSearch;
        private TextBox textBox2;
        private ListView listView2;
        private ColumnHeader RouteName;
        private ColumnHeader Origin;
        private ColumnHeader Destination;
        private System.Windows.Forms.DateTimePicker dtpScheduleDate;
        private Button btnSchDelete;
        private Button btnSchCreate;
        private Button btnSchCancel;
        private Button btnSchUpdate;
        private Button btnSchSearch;
        private ListView listView3;
        private ColumnHeader AvaliableBusName;
        private ColumnHeader Date;
        private ColumnHeader Fare;
        private ColumnHeader ArrivalTime;
        private ColumnHeader DepatureTime;
        private ColumnHeader Route;
        private ColumnHeader AvaliableSeat;
        private ColumnHeader BookedSeat;
        private ListBox listBox1;
        private TabPage tabPage4;
        private ListView listView4;
        private ColumnHeader TravelDate;
        private ColumnHeader Username;
        private ColumnHeader Phoneno;
        private ColumnHeader SeatNo;
        private ColumnHeader BookedBusNo;
        private ColumnHeader BookedBusName;
        private ColumnHeader BookedBusType;
        private ColumnHeader BookedArrivalTime;
        private ColumnHeader BookedDepartureTime;
        private ColumnHeader BookedFare;
        private ColumnHeader BookedOrigin;
        private ColumnHeader BookedDestination;
        private ColumnHeader AvaliableBusNo;
        private Button btnBkCancel;
        private Button btnBkSearch;
        private TextBox txtBkSearch;
    }
}