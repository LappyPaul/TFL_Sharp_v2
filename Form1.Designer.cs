
namespace TFL_Sharp_v2
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
            this.cboAPI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLines = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstStations = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaptanID = new System.Windows.Forms.TextBox();
            this.txtStationAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optNightServiceNo = new System.Windows.Forms.RadioButton();
            this.optNightServiceYes = new System.Windows.Forms.RadioButton();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAPI
            // 
            this.cboAPI.FormattingEnabled = true;
            this.cboAPI.Location = new System.Drawing.Point(26, 39);
            this.cboAPI.Name = "cboAPI";
            this.cboAPI.Size = new System.Drawing.Size(248, 21);
            this.cboAPI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API to call";
            // 
            // lstLines
            // 
            this.lstLines.FormattingEnabled = true;
            this.lstLines.Location = new System.Drawing.Point(290, 40);
            this.lstLines.Name = "lstLines";
            this.lstLines.Size = new System.Drawing.Size(173, 56);
            this.lstLines.TabIndex = 2;
            this.lstLines.SelectedIndexChanged += new System.EventHandler(this.lstLines_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Line Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Station Names";
            // 
            // lstStations
            // 
            this.lstStations.FormattingEnabled = true;
            this.lstStations.Location = new System.Drawing.Point(479, 40);
            this.lstStations.Name = "lstStations";
            this.lstStations.Size = new System.Drawing.Size(202, 56);
            this.lstStations.TabIndex = 4;
            this.lstStations.SelectedIndexChanged += new System.EventHandler(this.lstStations_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Station Naptan ID";
            // 
            // txtNaptanID
            // 
            this.txtNaptanID.Location = new System.Drawing.Point(598, 105);
            this.txtNaptanID.Name = "txtNaptanID";
            this.txtNaptanID.ReadOnly = true;
            this.txtNaptanID.Size = new System.Drawing.Size(83, 20);
            this.txtNaptanID.TabIndex = 7;
            // 
            // txtStationAddress
            // 
            this.txtStationAddress.Location = new System.Drawing.Point(529, 133);
            this.txtStationAddress.Multiline = true;
            this.txtStationAddress.Name = "txtStationAddress";
            this.txtStationAddress.ReadOnly = true;
            this.txtStationAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStationAddress.Size = new System.Drawing.Size(152, 99);
            this.txtStationAddress.TabIndex = 9;
            this.txtStationAddress.TextChanged += new System.EventHandler(this.txtStationAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Station";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(66, 15);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(61, 20);
            this.txtLatitude.TabIndex = 13;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(66, 42);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(61, 20);
            this.txtLongitude.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Longitude";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(290, 102);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(173, 130);
            this.txtStatus.TabIndex = 16;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtZone);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(20, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 161);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Further Station Facilities";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Zone:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optNightServiceNo);
            this.groupBox2.Controls.Add(this.optNightServiceYes);
            this.groupBox2.Location = new System.Drawing.Point(9, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Night Service";
            // 
            // optNightServiceNo
            // 
            this.optNightServiceNo.AutoSize = true;
            this.optNightServiceNo.Enabled = false;
            this.optNightServiceNo.Location = new System.Drawing.Point(49, 19);
            this.optNightServiceNo.Name = "optNightServiceNo";
            this.optNightServiceNo.Size = new System.Drawing.Size(39, 17);
            this.optNightServiceNo.TabIndex = 1;
            this.optNightServiceNo.Text = "No";
            this.optNightServiceNo.UseVisualStyleBackColor = true;
            // 
            // optNightServiceYes
            // 
            this.optNightServiceYes.AutoSize = true;
            this.optNightServiceYes.Enabled = false;
            this.optNightServiceYes.Location = new System.Drawing.Point(6, 19);
            this.optNightServiceYes.Name = "optNightServiceYes";
            this.optNightServiceYes.Size = new System.Drawing.Size(43, 17);
            this.optNightServiceYes.TabIndex = 0;
            this.optNightServiceYes.Text = "Yes";
            this.optNightServiceYes.UseVisualStyleBackColor = true;
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(61, 19);
            this.txtZone.Name = "txtZone";
            this.txtZone.ReadOnly = true;
            this.txtZone.Size = new System.Drawing.Size(42, 20);
            this.txtZone.TabIndex = 2;
            this.txtZone.TextChanged += new System.EventHandler(this.txtZone_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtLongitude);
            this.groupBox3.Controls.Add(this.txtLatitude);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(131, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStationAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaptanID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstStations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAPI);
            this.Name = "Form1";
            this.Text = "PAL ~ TFL API Caller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstStations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaptanID;
        private System.Windows.Forms.TextBox txtStationAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optNightServiceNo;
        private System.Windows.Forms.RadioButton optNightServiceYes;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

