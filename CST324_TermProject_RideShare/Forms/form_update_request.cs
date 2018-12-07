using CST324_TermProject_RideShare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324_TermProject_RideShare.Forms
{
    public partial class form_update_request : Form
    {
        RideRequest current;
        private OIT_RideShare _dbContext;
        string willChange;

        public form_update_request(RideRequest ride)
        {
            InitializeComponent();
            current = ride;
            _dbContext = new OIT_RideShare();
            UpdateRideRequestData();
        }

        public void UpdateRideRequestData()
        {
            
            requestUpdatetb1.Text = "RequestID: " + current.RideRequestID.ToString()
                                + Environment.NewLine + "Location: " + "Not working..."
                                + Environment.NewLine + "Destination: " + current.Destination.ToString()

                                + Environment.NewLine + "Desired Time: " + current.Rider_Desired_Time.ToString(); ;
        }

        private void btn_Finish2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void requestUpdate_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
