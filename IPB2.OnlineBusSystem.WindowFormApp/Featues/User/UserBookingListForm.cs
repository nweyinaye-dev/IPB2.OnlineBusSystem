using IPB2.OnlineBusSystem.WebApi.Features.Report;
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
    public partial class UserBookingListForm : Form
    {
        private readonly BookingReportService _reportService = new BookingReportService();

        public UserBookingListForm()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var phoneno = txtPhoneno.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneno))
            {
                MessageBox.Show("Please enter both Username and Phone Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listViewBookings.Items.Clear();

            try
            {
                var response = await _reportService.GetBookingDetailByUserAsync(username, phoneno);

                if (response != null && response.bookings.Count > 0)
                {
                    foreach (var booking in response.bookings)
                    {
                        ListViewItem item = new ListViewItem(booking.TravelDate.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(booking.Username);
                        item.SubItems.Add(booking.Phoneno);
                        item.SubItems.Add(booking.SeatNo);
                        item.SubItems.Add(booking.BookedBusNo);
                        item.SubItems.Add(booking.BookedBusName);
                        item.SubItems.Add(booking.BookedBusType);
                        item.SubItems.Add(booking.BookedArrivalTime);
                        item.SubItems.Add(booking.BookedDepartureTime);
                        item.SubItems.Add(booking.BookedFare.ToString("N0"));
                        item.SubItems.Add(booking.BookedOrigin);
                        item.SubItems.Add(booking.BookedDestination);

                        listViewBookings.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No bookings found for the provided details.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
