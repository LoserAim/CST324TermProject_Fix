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
    public partial class form_admin_add_request : Form
    {
        OIT_RideShare _dbContext;
        public form_admin_add_request()
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
        }

        private void tb_Location_TextChanged(object sender, EventArgs e)
        {
            RideRequest temp = new RideRequest();
            temp.CreditCard_ = tb_Admin.Text;
            TimeSpan dtime = TimeSpan.Parse(tb_RiderID.Text);
            temp.Driver_ETA = dtime;
            temp.Destination = tb_Location.Text;
            dtime = TimeSpan.Parse(tb_VehicleType.Text);
            temp.Driver_ETA = dtime;
            _dbContext.RideRequests.Add(temp);
            _dbContext.SaveChanges()
            

        }


    }
}
