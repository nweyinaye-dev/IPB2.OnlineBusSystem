using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;
using IPB2.OnlineBusSystem.WebApi.Features.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.User
{
    public partial class User : Form
    {
        private readonly RouteService _routeService = new RouteService();
        private readonly BookingService _bookingService = new BookingService();
        public User()
        {
            InitializeComponent();
            LoadData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task LoadData()
        {

            var routes = await _routeService.GetRouteComboSet();

            cboRouteOrigin.DataSource = routes;
            cboRouteOrigin.DisplayMember = "Origin";
            cboRouteOrigin.ValueMember = "Id";

            cboRouteDestination.DataSource = routes;
            cboRouteDestination.DisplayMember = "Destination";
            cboRouteDestination.ValueMember = "Id";

            cboRouteOrigin.SelectedIndex = 0;
            cboRouteDestination.SelectedIndex = 0;
        }

        private async void btnBkSearch_Click(object sender, EventArgs e)
        {
            if (cboRouteOrigin.SelectedValue == null || cboRouteDestination.SelectedValue == null)
            {
                MessageBox.Show("Please select origin and destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new SearchBusRequest
            {
                Origin = cboRouteOrigin.Text,
                Destination = cboRouteDestination.Text,
                TravelDate = DateOnly.FromDateTime(dtpTravelDate.Value)
            };

            var response = await _bookingService.SearchBus(request);

            DisplayResults(response.Buss);
        }

        private void DisplayResults(List<SearchBusResponseModel> buses)
        {
            listView1.View = View.Details;
            listView1.Items.Clear();

            if (buses != null && buses.Count > 0)
            {
                foreach (var bus in buses)
                {
                    ListViewItem item = new ListViewItem(bus.BusNo);
                    item.Tag = bus.secheduleId;
                    item.SubItems.Add(bus.BusName);
                    item.SubItems.Add(bus.DepartureTime);
                    item.SubItems.Add(bus.ArrivalTime);
                    item.SubItems.Add(bus.AvaliableSeat.ToString());
                    item.SubItems.Add(bus.Fare.ToString("N0"));
                    item.SubItems.Add(bus.BusType);

                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No buses found for the selected route and date.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBkCancel_Click(object sender, EventArgs e)
        {
            cboRouteOrigin.SelectedIndex = 0;
            cboRouteDestination.SelectedIndex = 0;
            dtpTravelDate.Value = DateTime.Now;
            listView1.Items.Clear();
        }

        private async void btnBook_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a bus to book.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            var scheduleId = selectedItem.Tag.ToString();

            var bookingForm = new BookingForm(scheduleId!);
            if (bookingForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the search to show updated seat availability
                btnBkSearch_Click(sender, e);
            }
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            var bookedListForm = new UserBookingListForm();
            bookedListForm.ShowDialog();
        }
    }
}
