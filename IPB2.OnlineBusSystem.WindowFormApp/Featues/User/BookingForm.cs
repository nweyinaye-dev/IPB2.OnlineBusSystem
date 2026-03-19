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
    public partial class BookingForm : Form
    {
        private readonly BookingService _bookingService = new BookingService();
        private readonly string _scheduleId;
        private ListViewItem? _editingItem;

        public BookingForm(string scheduleId)
        {
            InitializeComponent();
            _scheduleId = scheduleId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeatNo.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPhoneno.Text))
            {
                MessageBox.Show("Please fill all passenger details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSeatNo.Text, out int seatNo))
            {
                MessageBox.Show("Seat number must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if seat is already in the list
            foreach (ListViewItem item in listViewPassengers.Items)
            {
                if (_editingItem != item && item.Text == txtSeatNo.Text)
                {
                    MessageBox.Show("This seat is already added to the list.", "Duplicate Seat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_editingItem != null)
            {
                _editingItem.Text = txtSeatNo.Text;
                _editingItem.SubItems[1].Text = txtUsername.Text;
                _editingItem.SubItems[2].Text = txtPhoneno.Text;
                
                btnAdd.Text = "Add";
                _editingItem = null;
            }
            else
            {
                ListViewItem newItem = new ListViewItem(txtSeatNo.Text);
                newItem.SubItems.Add(txtUsername.Text);
                newItem.SubItems.Add(txtPhoneno.Text);

                listViewPassengers.Items.Add(newItem);
            }

            // Clear inputs for next passenger
            txtSeatNo.Clear();
            txtUsername.Clear();
            txtPhoneno.Clear();
            txtSeatNo.Focus();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listViewPassengers.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one passenger.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new BookRequest
            {
                ScheduleId = _scheduleId,
                Passengers = new List<Passenger>()
            };

            foreach (ListViewItem item in listViewPassengers.Items)
            {
                request.Passengers.Add(new Passenger
                {
                    SeatNo = int.Parse(item.Text),
                    Username = item.SubItems[1].Text,
                    Phoneno = item.SubItems[2].Text
                });
            }

            var response = await _bookingService.CreateAsync(request);

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

        private void btnEditPassenger_Click(object sender, EventArgs e)
        {
            if (listViewPassengers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a passenger to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _editingItem = listViewPassengers.SelectedItems[0];
            txtSeatNo.Text = _editingItem.Text;
            txtUsername.Text = _editingItem.SubItems[1].Text;
            txtPhoneno.Text = _editingItem.SubItems[2].Text;

            btnAdd.Text = "Update";
        }

        private void btnDeletePassenger_Click(object sender, EventArgs e)
        {
            if (listViewPassengers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a passenger to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this passenger?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var itemToDelete = listViewPassengers.SelectedItems[0];
                if (_editingItem == itemToDelete)
                {
                    btnAdd.Text = "Add";
                    _editingItem = null;
                    txtSeatNo.Clear();
                    txtUsername.Clear();
                    txtPhoneno.Clear();
                }
                listViewPassengers.Items.Remove(itemToDelete);
            }
        }
    }
}
