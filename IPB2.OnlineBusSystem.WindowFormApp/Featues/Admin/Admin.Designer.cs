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
            textBox1 = new TextBox();
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
            btnRouteCancel = new Button();
            btnRouteSearch = new Button();
            textBox2 = new TextBox();
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
            btnSchDelete = new Button();
            btnSchCreate = new Button();
            btnSchCancel = new Button();
            btnSchUpdate = new Button();
            btnSchSearch = new Button();
            textBox3 = new TextBox();
            ID = new ColumnHeader();
            delete = new ContextMenuStrip(components);
            Bus.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // Bus
            // 
            Bus.Controls.Add(tabPage1);
            Bus.Controls.Add(tabPage2);
            Bus.Controls.Add(tabPage3);
            Bus.Location = new Point(12, 12);
            Bus.Name = "Bus";
            Bus.SelectedIndex = 0;
            Bus.Size = new Size(767, 426);
            Bus.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(btnBusCancel);
            tabPage1.Controls.Add(btnBusSearch);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bus";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(434, 31);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(596, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(515, 31);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { BusNo, BusName, BusType, TotalSeat });
            listView1.ContextMenuStrip = edit;
            listView1.Location = new Point(32, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(639, 296);
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
            edit.Name = "contextMenuStrip1";
            edit.Size = new Size(61, 4);
            edit.Text = "Edit";
            // 
            // btnBusCancel
            // 
            btnBusCancel.Location = new Point(335, 31);
            btnBusCancel.Name = "btnBusCancel";
            btnBusCancel.Size = new Size(75, 23);
            btnBusCancel.TabIndex = 2;
            btnBusCancel.Text = "Cancel";
            btnBusCancel.UseVisualStyleBackColor = true;
            btnBusCancel.Click += btnBusCancel_Click;
            // 
            // btnBusSearch
            // 
            btnBusSearch.Location = new Point(254, 31);
            btnBusSearch.Name = "btnBusSearch";
            btnBusSearch.Size = new Size(75, 23);
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
            tabPage2.Controls.Add(btnRouteCancel);
            tabPage2.Controls.Add(btnRouteSearch);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Route";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { RouteName, Origin, Destination });
            listView2.Location = new Point(28, 65);
            listView2.Name = "listView2";
            listView2.Size = new Size(551, 248);
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
            btnRouteDelete.Location = new Point(598, 22);
            btnRouteDelete.Name = "btnRouteDelete";
            btnRouteDelete.Size = new Size(75, 23);
            btnRouteDelete.TabIndex = 5;
            btnRouteDelete.Text = "Delete";
            btnRouteDelete.UseVisualStyleBackColor = true;
            btnRouteDelete.Click += btnRouteDelete_Click;
            // 
            // btnRouteUpdate
            // 
            btnRouteUpdate.Location = new Point(504, 22);
            btnRouteUpdate.Name = "btnRouteUpdate";
            btnRouteUpdate.Size = new Size(75, 23);
            btnRouteUpdate.TabIndex = 4;
            btnRouteUpdate.Text = "Update";
            btnRouteUpdate.UseVisualStyleBackColor = true;
            btnRouteUpdate.Click += btnRouteUpdate_Click;
            // 
            // btnRouteCreate
            // 
            btnRouteCreate.Location = new Point(409, 22);
            btnRouteCreate.Name = "btnRouteCreate";
            btnRouteCreate.Size = new Size(75, 23);
            btnRouteCreate.TabIndex = 3;
            btnRouteCreate.Text = "New";
            btnRouteCreate.UseVisualStyleBackColor = true;
            btnRouteCreate.Click += btnRouteCreate_Click;
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
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listView3);
            tabPage3.Controls.Add(btnSchDelete);
            tabPage3.Controls.Add(btnSchCreate);
            tabPage3.Controls.Add(btnSchCancel);
            tabPage3.Controls.Add(btnSchUpdate);
            tabPage3.Controls.Add(btnSchSearch);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(759, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Schedule";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { AvaliableBusName, Date, Fare, ArrivalTime, DepatureTime, Route, AvaliableSeat, BookedSeat });
            listView3.Location = new Point(37, 69);
            listView3.Name = "listView3";
            listView3.Size = new Size(673, 309);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // AvaliableBusName
            // 
            AvaliableBusName.Text = "BusName";
            AvaliableBusName.Width = 100;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 100;
            // 
            // Fare
            // 
            Fare.Text = "Fare";
            Fare.Width = 100;
            // 
            // ArrivalTime
            // 
            ArrivalTime.Text = "ArrivalTime";
            ArrivalTime.Width = 100;
            // 
            // DepatureTime
            // 
            DepatureTime.Text = "DepatureTime";
            DepatureTime.Width = 100;
            // 
            // Route
            // 
            Route.Text = "Route";
            Route.Width = 100;
            // 
            // AvaliableSeat
            // 
            AvaliableSeat.Text = "AvaliableSeat";
            // 
            // BookedSeat
            // 
            BookedSeat.Text = "BookedSeat";
            // 
            // btnSchDelete
            // 
            btnSchDelete.Location = new Point(618, 19);
            btnSchDelete.Name = "btnSchDelete";
            btnSchDelete.Size = new Size(75, 23);
            btnSchDelete.TabIndex = 5;
            btnSchDelete.Text = "Delete";
            btnSchDelete.UseVisualStyleBackColor = true;
            btnSchDelete.Click += btnSchDelete_Click;
            // 
            // btnSchCreate
            // 
            btnSchCreate.Location = new Point(437, 20);
            btnSchCreate.Name = "btnSchCreate";
            btnSchCreate.Size = new Size(75, 23);
            btnSchCreate.TabIndex = 4;
            btnSchCreate.Text = "New";
            btnSchCreate.UseVisualStyleBackColor = true;
            btnSchCreate.Click += btnSchCreate_Click;
            // 
            // btnSchCancel
            // 
            btnSchCancel.Location = new Point(345, 20);
            btnSchCancel.Name = "btnSchCancel";
            btnSchCancel.Size = new Size(75, 23);
            btnSchCancel.TabIndex = 3;
            btnSchCancel.Text = "Cancel";
            btnSchCancel.UseVisualStyleBackColor = true;
            btnSchCancel.Click += btnSchCancel_Click;
            // 
            // btnSchUpdate
            // 
            btnSchUpdate.Location = new Point(528, 19);
            btnSchUpdate.Name = "btnSchUpdate";
            btnSchUpdate.Size = new Size(75, 23);
            btnSchUpdate.TabIndex = 2;
            btnSchUpdate.Text = "Update";
            btnSchUpdate.UseVisualStyleBackColor = true;
            btnSchUpdate.Click += btnSchUpdate_Click;
            // 
            // btnSchSearch
            // 
            btnSchSearch.Location = new Point(252, 20);
            btnSchSearch.Name = "btnSchSearch";
            btnSchSearch.Size = new Size(75, 23);
            btnSchSearch.TabIndex = 1;
            btnSchSearch.Text = "Search";
            btnSchSearch.UseVisualStyleBackColor = true;
            btnSchSearch.Click += btnSchSearch_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 0;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 120;
            // 
            // delete
            // 
            delete.Name = "delete";
            delete.Size = new Size(61, 4);
            delete.Text = "delete";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 537);
            Controls.Add(Bus);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Bus.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private TextBox textBox1;
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
        private TextBox textBox3;
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
    }
}