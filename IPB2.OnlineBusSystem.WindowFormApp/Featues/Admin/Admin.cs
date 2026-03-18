using Azure;
using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;
using IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule;
using IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin
{
    public partial class Admin : Form
    {
        BusService _busService = new BusService();
        RouteService _routeService = new RouteService();
        ScheduleService _scheduleService = new ScheduleService();
        public Admin()
        {
            InitializeComponent();
        }
        private async Task BindGrid(int pageNo, int pageSize)
        {
            listView1.View = View.Details;

            listView1.Items.Clear();

            var res = await _busService.GetBusAsync(1, 10);

            if (res != null && res.Buss.Count > 0)
            {
                foreach (var bus in res.Buss)
                {
                    ListViewItem item = new ListViewItem(bus.BusNo);
                    item.Tag = bus.Id; // Store ID in Tag instead of displaying it

                    item.SubItems.Add(bus.BusName);
                    item.SubItems.Add(bus.BusType);
                    item.SubItems.Add(bus.TotalSeat.ToString());

                    listView1.Items.Add(item);
                }
            }
        }
        private async void tabPage1_Enter(object sender, EventArgs e)
        {
            await BindGrid(1, 10);
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var editForm = new BusNewForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await BindGrid(1, 10);
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a bus to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            var bus = new BusResponse
            {
                Id = selectedItem.Tag.ToString(),
                BusNo = selectedItem.Text, // First column is now BusNo
                BusName = selectedItem.SubItems[1].Text,
                BusType = selectedItem.SubItems[2].Text,
                TotalSeat = int.Parse(selectedItem.SubItems[3].Text)
            };

            var editForm = new BusEditForm(bus);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await BindGrid(1, 10);
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a bus to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            var response = await _busService.DeleteAsync(selectedItem.Tag.ToString());
            if (response.Status == ResponseType.Success)
            {
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await BindGrid(1, 10);
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnBusSearch_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                await BindGrid(1, 10);
                return;
            }

            var bus = await _busService.GetBusByIdAsync(id);
            if (bus != null)
            {
                listView1.Items.Clear();
                ListViewItem item = new ListViewItem(bus.BusNo);
                item.Tag = bus.Id;
                item.SubItems.Add(bus.BusName);
                item.SubItems.Add(bus.BusType);
                item.SubItems.Add(bus.TotalSeat.ToString());
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Bus not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnBusCancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await BindGrid(1, 10);
        }

        #region Route Tab

        private async Task BindRouteGrid(int pageNo, int pageSize)
        {
            listView2.View = View.Details;
            listView2.Items.Clear();

            var res = await _routeService.GetRoutesAsync(pageNo, pageSize);

            if (res != null && res.Routes.Count > 0)
            {
                foreach (var route in res.Routes)
                {
                    ListViewItem item = new ListViewItem(route.RouteName);
                    item.Tag = route.Id;
                    item.SubItems.Add(route.Origin);
                    item.SubItems.Add(route.Destination);

                    listView2.Items.Add(item);
                }
            }
        }

        private async void tabPage2_Enter(object sender, EventArgs e)
        {
            await BindRouteGrid(1, 10);
        }

        private async void btnRouteSearch_Click(object sender, EventArgs e)
        {
            var id = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                await BindRouteGrid(1, 10);
                return;
            }

            var route = await _routeService.GetRouteByIdAsync(id);
            if (route != null)
            {
                listView2.Items.Clear();
                ListViewItem item = new ListViewItem(route.RouteName);
                item.Tag = route.Id;
                item.SubItems.Add(route.Origin);
                item.SubItems.Add(route.Destination);
                listView2.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Route not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnRouteCancel_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            await BindRouteGrid(1, 10);
        }

        private async void btnRouteCreate_Click(object sender, EventArgs e)
        {
            var createForm = new RouteNewForm();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await BindRouteGrid(1, 10);
            }
        }

        private async void btnRouteUpdate_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a route to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listView2.SelectedItems[0];
            var route = new RouteResponse
            {
                Id = selectedItem.Tag.ToString(),
                RouteName = selectedItem.Text,
                Origin = selectedItem.SubItems[1].Text,
                Destination = selectedItem.SubItems[2].Text
            };

            var editForm = new RouteEditForm(route);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await BindRouteGrid(1, 10);
            }
        }

        private async void btnRouteDelete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a route to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedItem = listView2.SelectedItems[0];
                var response = await _routeService.DeleteAsync(selectedItem.Tag.ToString());
                if (response.Status == ResponseType.Success)
                {
                    MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await BindRouteGrid(1, 10);
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #region Schedule Tab

        private async Task BindScheduleGrid(int pageNo, int pageSize)
        {
            listView3.View = View.Details;
            listView3.Items.Clear();

            var res = await _scheduleService.GetScheduleAsync();

            if (res != null && res.Schedules.Count > 0)
            {
                foreach (var sch in res.Schedules)
                {
                    ListViewItem item = new ListViewItem(sch.AvaliableBusName);
                    item.Tag = sch.Id;
                    item.SubItems.Add(sch.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(sch.Fare.ToString("N0"));
                    item.SubItems.Add(sch.ArrivalTime);
                    item.SubItems.Add(sch.DepartureTime);
                    item.SubItems.Add(sch.Route);
                    item.SubItems.Add(sch.AvaliableSeat.ToString());
                    item.SubItems.Add(sch.BookedSeat.ToString());

                    listView3.Items.Add(item);
                }
            }
        }

        private async void tabPage3_Enter(object sender, EventArgs e)
        {
            await BindScheduleGrid(1, 10);
        }

        private async void btnSchSearch_Click(object sender, EventArgs e)
        {
            var id = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                await BindScheduleGrid(1, 10);
                return;
            }

            var sch = await _scheduleService.GetScheduleByIdAsync(id);
            if (sch != null)
            {
                listView3.Items.Clear();
                ListViewItem item = new ListViewItem(sch.BusId); // Showing BusId as placeholder if name not available on detail
                item.Tag = sch.Id;
                item.SubItems.Add(sch.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(sch.Fare.ToString("N0"));
                item.SubItems.Add(sch.ArrivalTime);
                item.SubItems.Add(sch.DepartureTime);
                item.SubItems.Add(sch.RouteId); // Showing RouteId as placeholder
                item.SubItems.Add(sch.AvaliableSeat.ToString());
                item.SubItems.Add(sch.BookSeat.ToString());
                listView3.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Schedule not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnSchCancel_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            await BindScheduleGrid(1, 10);
        }

        private async void btnSchCreate_Click(object sender, EventArgs e)
        {
            var createForm = new ScheduleNewForm();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await BindScheduleGrid(1, 10);
            }
        }

        private void btnSchUpdate_Click(object sender, EventArgs e)
        {
             // Placeholder for Update Schedule
            MessageBox.Show("Update Schedule functionality coming soon.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSchDelete_Click(object sender, EventArgs e)
        {
             // Placeholder for Delete Schedule
            MessageBox.Show("Delete Schedule functionality coming soon.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}

