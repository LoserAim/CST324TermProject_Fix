namespace CST324_TermProject_RideShare.Forms
{
    partial class form_admin_add_request
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
            this.lb_VehicleType = new System.Windows.Forms.Label();
            this.tb_VehicleType = new System.Windows.Forms.TextBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_RiderID = new System.Windows.Forms.Label();
            this.lb_Admin = new System.Windows.Forms.Label();
            this.lb_Location = new System.Windows.Forms.Label();
            this.tb_RiderID = new System.Windows.Forms.TextBox();
            this.tb_Admin = new System.Windows.Forms.TextBox();
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_VehicleType
            // 
            this.lb_VehicleType.AutoSize = true;
            this.lb_VehicleType.Location = new System.Drawing.Point(8, 67);
            this.lb_VehicleType.Name = "lb_VehicleType";
            this.lb_VehicleType.Size = new System.Drawing.Size(69, 13);
            this.lb_VehicleType.TabIndex = 39;
            this.lb_VehicleType.Text = "Desired Time";
            // 
            // tb_VehicleType
            // 
            this.tb_VehicleType.Location = new System.Drawing.Point(85, 64);
            this.tb_VehicleType.Name = "tb_VehicleType";
            this.tb_VehicleType.Size = new System.Drawing.Size(165, 20);
            this.tb_VehicleType.TabIndex = 36;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(62, 150);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 23);
            this.btn_Finish.TabIndex = 33;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(143, 150);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 23);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Add Request";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lb_RiderID
            // 
            this.lb_RiderID.AutoSize = true;
            this.lb_RiderID.Location = new System.Drawing.Point(8, 93);
            this.lb_RiderID.Name = "lb_RiderID";
            this.lb_RiderID.Size = new System.Drawing.Size(59, 13);
            this.lb_RiderID.TabIndex = 31;
            this.lb_RiderID.Text = "Driver ETA";
            // 
            // lb_Admin
            // 
            this.lb_Admin.AutoSize = true;
            this.lb_Admin.Location = new System.Drawing.Point(8, 41);
            this.lb_Admin.Name = "lb_Admin";
            this.lb_Admin.Size = new System.Drawing.Size(59, 13);
            this.lb_Admin.TabIndex = 29;
            this.lb_Admin.Text = "Credit Card";
            // 
            // lb_Location
            // 
            this.lb_Location.AutoSize = true;
            this.lb_Location.Location = new System.Drawing.Point(8, 15);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(48, 13);
            this.lb_Location.TabIndex = 28;
            this.lb_Location.Text = "Location";
            // 
            // tb_RiderID
            // 
            this.tb_RiderID.Location = new System.Drawing.Point(85, 90);
            this.tb_RiderID.Name = "tb_RiderID";
            this.tb_RiderID.Size = new System.Drawing.Size(165, 20);
            this.tb_RiderID.TabIndex = 27;
            // 
            // tb_Admin
            // 
            this.tb_Admin.Location = new System.Drawing.Point(85, 38);
            this.tb_Admin.Name = "tb_Admin";
            this.tb_Admin.Size = new System.Drawing.Size(165, 20);
            this.tb_Admin.TabIndex = 25;
            // 
            // tb_Location
            // 
            this.tb_Location.Location = new System.Drawing.Point(85, 12);
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.Size = new System.Drawing.Size(165, 20);
            this.tb_Location.TabIndex = 24;
            this.tb_Location.TextChanged += new System.EventHandler(this.tb_Location_TextChanged);
            // 
            // form_admin_add_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 197);
            this.Controls.Add(this.lb_VehicleType);
            this.Controls.Add(this.tb_VehicleType);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_RiderID);
            this.Controls.Add(this.lb_Admin);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.tb_RiderID);
            this.Controls.Add(this.tb_Admin);
            this.Controls.Add(this.tb_Location);
            this.Name = "form_admin_add_request";
            this.Text = "form_admin_add_request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_VehicleType;
        private System.Windows.Forms.TextBox tb_VehicleType;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_RiderID;
        private System.Windows.Forms.Label lb_Admin;
        private System.Windows.Forms.Label lb_Location;
        private System.Windows.Forms.TextBox tb_RiderID;
        private System.Windows.Forms.TextBox tb_Admin;
        private System.Windows.Forms.TextBox tb_Location;
    }
}