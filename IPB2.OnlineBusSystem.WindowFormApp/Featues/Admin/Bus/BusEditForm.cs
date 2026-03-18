using Azure;
using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
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
    public partial class BusEditForm : Form
    {
        private readonly BusService _busService = new BusService();
        private readonly string _busId;

        public BusEditForm(BusResponse bus)
        {
            InitializeComponent();
            _busId = bus.Id;
            txtBusNo.Text = bus.BusNo;
            txtBusName.Text = bus.BusName;
            txtBusType.Text = bus.BusType;
            txtTotalSeat.Text = bus.TotalSeat.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
           

            if (!int.TryParse(txtTotalSeat.Text, out int totalSeat))
            {
                MessageBox.Show("Total Seat must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new UpdateBusRequest
            {
                BusNo = txtBusNo.Text,
                BusName = txtBusName.Text,
                BusType = txtBusType.Text,
                TotalSeat = totalSeat
            };

            ResponseBaseModel validationRes = Validation(request);

            if (!validationRes.IsSuccess)
                MessageBox.Show(validationRes.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (validationRes.IsSuccess)
            {
                var response = await _busService.UpdateAsync(request, _busId);

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


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private ResponseBaseModel Validation(UpdateBusRequest request)
        {
            // Require Validation
            if (string.IsNullOrWhiteSpace(request.BusName))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusName is required." };
            if (string.IsNullOrWhiteSpace(request.BusNo))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusNo is required." };
            if (string.IsNullOrWhiteSpace(request.BusType))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusType is required." };
            if (request.TotalSeat < 20)
                return new ResponseBaseModel { IsSuccess = false, Message = "Total Seat must be at leave 20 seats." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validatin successfully." };

        }
    }
}
