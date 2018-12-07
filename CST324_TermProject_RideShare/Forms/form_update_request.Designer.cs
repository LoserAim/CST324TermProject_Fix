namespace CST324_TermProject_RideShare.Forms
{
    partial class Form1
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
            this.pizzatime = new System.Windows.Forms.Label();
            this.requestUpdatetb1 = new System.Windows.Forms.TextBox();
            this.btn_Finish2 = new System.Windows.Forms.Button();
            this.btn_Apply2 = new System.Windows.Forms.Button();
            this.requestUpdatetb2 = new System.Windows.Forms.TextBox();
            this.lb_tb_UpdateTo = new System.Windows.Forms.Label();
            this.lb_listb_update = new System.Windows.Forms.Label();
            this.requestUpdate_lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pizzatime
            // 
            this.pizzatime.AutoSize = true;
            this.pizzatime.Location = new System.Drawing.Point(86, 39);
            this.pizzatime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pizzatime.Name = "pizzatime";
            this.pizzatime.Size = new System.Drawing.Size(95, 17);
            this.pizzatime.TabIndex = 15;
            this.pizzatime.Text = "Request Data";
            // 
            // requestUpdatetb1
            // 
            this.requestUpdatetb1.Location = new System.Drawing.Point(86, 59);
            this.requestUpdatetb1.Margin = new System.Windows.Forms.Padding(4);
            this.requestUpdatetb1.Multiline = true;
            this.requestUpdatetb1.Name = "requestUpdatetb1";
            this.requestUpdatetb1.ReadOnly = true;
            this.requestUpdatetb1.Size = new System.Drawing.Size(452, 154);
            this.requestUpdatetb1.TabIndex = 14;
            // 
            // btn_Finish2
            // 
            this.btn_Finish2.Location = new System.Drawing.Point(291, 331);
            this.btn_Finish2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Finish2.Name = "btn_Finish2";
            this.btn_Finish2.Size = new System.Drawing.Size(100, 28);
            this.btn_Finish2.TabIndex = 13;
            this.btn_Finish2.Text = "Finish";
            this.btn_Finish2.UseVisualStyleBackColor = true;
            this.btn_Finish2.Click += new System.EventHandler(this.btn_Finish2_Click);
            // 
            // btn_Apply2
            // 
            this.btn_Apply2.Location = new System.Drawing.Point(399, 331);
            this.btn_Apply2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Apply2.Name = "btn_Apply2";
            this.btn_Apply2.Size = new System.Drawing.Size(152, 28);
            this.btn_Apply2.TabIndex = 12;
            this.btn_Apply2.Text = "Apply Update";
            this.btn_Apply2.UseVisualStyleBackColor = true;
            // 
            // requestUpdatetb2
            // 
            this.requestUpdatetb2.Location = new System.Drawing.Point(248, 261);
            this.requestUpdatetb2.Margin = new System.Windows.Forms.Padding(4);
            this.requestUpdatetb2.Name = "requestUpdatetb2";
            this.requestUpdatetb2.Size = new System.Drawing.Size(301, 22);
            this.requestUpdatetb2.TabIndex = 11;
            // 
            // lb_tb_UpdateTo
            // 
            this.lb_tb_UpdateTo.AutoSize = true;
            this.lb_tb_UpdateTo.Location = new System.Drawing.Point(244, 240);
            this.lb_tb_UpdateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tb_UpdateTo.Name = "lb_tb_UpdateTo";
            this.lb_tb_UpdateTo.Size = new System.Drawing.Size(79, 17);
            this.lb_tb_UpdateTo.TabIndex = 10;
            this.lb_tb_UpdateTo.Text = "Update To:";
            // 
            // lb_listb_update
            // 
            this.lb_listb_update.AutoSize = true;
            this.lb_listb_update.Location = new System.Drawing.Point(82, 217);
            this.lb_listb_update.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_listb_update.Name = "lb_listb_update";
            this.lb_listb_update.Size = new System.Drawing.Size(112, 17);
            this.lb_listb_update.TabIndex = 9;
            this.lb_listb_update.Text = "What To Update";
            // 
            // requestUpdate_lb
            // 
            this.requestUpdate_lb.FormattingEnabled = true;
            this.requestUpdate_lb.ItemHeight = 16;
            this.requestUpdate_lb.Items.AddRange(new object[] {
            "UserID",
            "Location",
            "RiderID",
            "DriverID"});
            this.requestUpdate_lb.Location = new System.Drawing.Point(86, 240);
            this.requestUpdate_lb.Margin = new System.Windows.Forms.Padding(4);
            this.requestUpdate_lb.Name = "requestUpdate_lb";
            this.requestUpdate_lb.Size = new System.Drawing.Size(148, 116);
            this.requestUpdate_lb.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.pizzatime);
            this.Controls.Add(this.requestUpdatetb1);
            this.Controls.Add(this.btn_Finish2);
            this.Controls.Add(this.btn_Apply2);
            this.Controls.Add(this.requestUpdatetb2);
            this.Controls.Add(this.lb_tb_UpdateTo);
            this.Controls.Add(this.lb_listb_update);
            this.Controls.Add(this.requestUpdate_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzatime;
        private System.Windows.Forms.TextBox requestUpdatetb1;
        private System.Windows.Forms.Button btn_Finish2;
        private System.Windows.Forms.Button btn_Apply2;
        private System.Windows.Forms.TextBox requestUpdatetb2;
        private System.Windows.Forms.Label lb_tb_UpdateTo;
        private System.Windows.Forms.Label lb_listb_update;
        private System.Windows.Forms.ListBox requestUpdate_lb;
    }
}