
namespace LocalWeather
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
            this.btnGetDeviceLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextbox = new System.Windows.Forms.TextBox();
            this.txtBoxCityName = new System.Windows.Forms.TextBox();
            this.panelDisplayWeather = new System.Windows.Forms.Panel();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.btnCheckForecast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.panelDisplayWeather.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDeviceLocation
            // 
            this.btnGetDeviceLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDeviceLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGetDeviceLocation.Location = new System.Drawing.Point(6, 19);
            this.btnGetDeviceLocation.Name = "btnGetDeviceLocation";
            this.btnGetDeviceLocation.Size = new System.Drawing.Size(185, 42);
            this.btnGetDeviceLocation.TabIndex = 0;
            this.btnGetDeviceLocation.Text = "Get Device Location";
            this.btnGetDeviceLocation.UseVisualStyleBackColor = true;
            this.btnGetDeviceLocation.Click += new System.EventHandler(this.getLocation_Click);
            this.btnGetDeviceLocation.MouseHover += new System.EventHandler(this.btnGetDeviceLocation_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(67, 107);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeTextBox.TabIndex = 3;
            // 
            // latitudeTextbox
            // 
            this.latitudeTextbox.Location = new System.Drawing.Point(67, 73);
            this.latitudeTextbox.Name = "latitudeTextbox";
            this.latitudeTextbox.Size = new System.Drawing.Size(100, 20);
            this.latitudeTextbox.TabIndex = 4;
            // 
            // txtBoxCityName
            // 
            this.txtBoxCityName.Location = new System.Drawing.Point(9, 43);
            this.txtBoxCityName.Name = "txtBoxCityName";
            this.txtBoxCityName.Size = new System.Drawing.Size(158, 20);
            this.txtBoxCityName.TabIndex = 9;
            // 
            // panelDisplayWeather
            // 
            this.panelDisplayWeather.Controls.Add(this.lblUrl);
            this.panelDisplayWeather.Controls.Add(this.lblHigh);
            this.panelDisplayWeather.Controls.Add(this.lblLow);
            this.panelDisplayWeather.Location = new System.Drawing.Point(296, 12);
            this.panelDisplayWeather.Name = "panelDisplayWeather";
            this.panelDisplayWeather.Size = new System.Drawing.Size(476, 400);
            this.panelDisplayWeather.TabIndex = 10;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(16, 73);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(78, 31);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Text = "High:";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(16, 19);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(72, 31);
            this.lblLow.TabIndex = 0;
            this.lblLow.Text = "Low:";
            // 
            // btnCheckForecast
            // 
            this.btnCheckForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForecast.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckForecast.Location = new System.Drawing.Point(18, 370);
            this.btnCheckForecast.Name = "btnCheckForecast";
            this.btnCheckForecast.Size = new System.Drawing.Size(185, 42);
            this.btnCheckForecast.TabIndex = 11;
            this.btnCheckForecast.Text = "Check Daily Forecast";
            this.btnCheckForecast.UseVisualStyleBackColor = true;
            this.btnCheckForecast.Click += new System.EventHandler(this.btnCheckForecast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnGetDeviceLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.longitudeTextBox);
            this.groupBox1.Controls.Add(this.latitudeTextbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(204, 134);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.txtBoxCityName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(204, 134);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(22, 321);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(0, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Click += new System.EventHandler(this.lblMoreInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheckForecast);
            this.Controls.Add(this.panelDisplayWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDisplayWeather.ResumeLayout(false);
            this.panelDisplayWeather.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDeviceLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox latitudeTextbox;
        private System.Windows.Forms.TextBox txtBoxCityName;
        private System.Windows.Forms.Panel panelDisplayWeather;
        private System.Windows.Forms.Button btnCheckForecast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblUrl;
    }
}

