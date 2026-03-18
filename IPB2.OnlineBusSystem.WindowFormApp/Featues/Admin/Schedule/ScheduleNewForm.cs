
using IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin.Schedule
{
    public partial class ScheduleNewForm : Form
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();

        public ScheduleNewForm()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            var buses = new List<dynamic>
            {
                new { Id = "1", Name = "Elite Express - VIP" },
                new { Id = "2", Name = "Famous Traveller" },
                new { Id = "3", Name = "Mandalar Min" }
            };

            cboBusName.DataSource = buses;
            cboBusName.DisplayMember = "Name";
            cboBusName.ValueMember = "Id";

            var routes = new List<dynamic>
            {
                new { Id = "1", Name = "Yangon - Mandalay" },
                new { Id = "2", Name = "Yangon - Naypyidaw" },
                new { Id = "3", Name = "Yangon - Taunggyi" }
            };

            cboRouteName.DataSource = routes;
            cboRouteName.DisplayMember = "Name";
            cboRouteName.ValueMember = "Id";

            cboBusName.SelectedIndex = -1;
            cboRouteName.SelectedIndex = -1;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cboBusName.SelectedValue == null || cboRouteName.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtFare.Text) || string.IsNullOrWhiteSpace(txtArrivalTime.Text) ||
                string.IsNullOrWhiteSpace(txtDepartureTime.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtFare.Text, out int fare))
            {
                MessageBox.Show("Fare must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new UpsertScheduleRequest
            {
                BusId = cboBusName.SelectedValue.ToString()!,
                RouteId = cboRouteName.SelectedValue.ToString()!,
                Date = DateOnly.FromDateTime(dtpDate.Value),
                Fare = fare,
                ArrivalTime = txtArrivalTime.Text,
                DepartureTime = txtDepartureTime.Text
            };

            var response = await _scheduleService.CreateAsync(request);

            if (response.Status == WebApi.Common.ResponseType.Success)
            {
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
