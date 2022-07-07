
namespace WeatherApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunrise_2 = new System.Windows.Forms.Label();
            this.labelSunset_2 = new System.Windows.Forms.Label();
            this.labelPressure_2 = new System.Windows.Forms.Label();
            this.labelWindSpeed_2 = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.labelCondition_2 = new System.Windows.Forms.Label();
            this.labelDetails_2 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelTemp_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(345, 69);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(135, 36);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCondition.Location = new System.Drawing.Point(39, 213);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(116, 29);
            this.labelCondition.TabIndex = 5;
            this.labelCondition.Text = "Condition:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDetails.Location = new System.Drawing.Point(39, 265);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(87, 29);
            this.labelDetails.TabIndex = 6;
            this.labelDetails.Text = "Details:";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSunset.Location = new System.Drawing.Point(39, 378);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(85, 29);
            this.labelSunset.TabIndex = 7;
            this.labelSunset.Text = "Sunset:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSunrise.Location = new System.Drawing.Point(39, 324);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(91, 29);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.Text = "Sunrise:";
            // 
            // labelSunrise_2
            // 
            this.labelSunrise_2.AutoSize = true;
            this.labelSunrise_2.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise_2.ForeColor = System.Drawing.Color.White;
            this.labelSunrise_2.Location = new System.Drawing.Point(160, 324);
            this.labelSunrise_2.Name = "labelSunrise_2";
            this.labelSunrise_2.Size = new System.Drawing.Size(51, 29);
            this.labelSunrise_2.TabIndex = 9;
            this.labelSunrise_2.Text = "N/A";
            // 
            // labelSunset_2
            // 
            this.labelSunset_2.AutoSize = true;
            this.labelSunset_2.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset_2.ForeColor = System.Drawing.Color.White;
            this.labelSunset_2.Location = new System.Drawing.Point(160, 379);
            this.labelSunset_2.Name = "labelSunset_2";
            this.labelSunset_2.Size = new System.Drawing.Size(51, 29);
            this.labelSunset_2.TabIndex = 10;
            this.labelSunset_2.Text = "N/A";
            // 
            // labelPressure_2
            // 
            this.labelPressure_2.AutoSize = true;
            this.labelPressure_2.BackColor = System.Drawing.Color.Transparent;
            this.labelPressure_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure_2.ForeColor = System.Drawing.Color.White;
            this.labelPressure_2.Location = new System.Drawing.Point(542, 267);
            this.labelPressure_2.Name = "labelPressure_2";
            this.labelPressure_2.Size = new System.Drawing.Size(51, 29);
            this.labelPressure_2.TabIndex = 14;
            this.labelPressure_2.Text = "N/A";
            // 
            // labelWindSpeed_2
            // 
            this.labelWindSpeed_2.AutoSize = true;
            this.labelWindSpeed_2.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed_2.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeed_2.Location = new System.Drawing.Point(542, 212);
            this.labelWindSpeed_2.Name = "labelWindSpeed_2";
            this.labelWindSpeed_2.Size = new System.Drawing.Size(51, 29);
            this.labelWindSpeed_2.TabIndex = 13;
            this.labelWindSpeed_2.Text = "N/A";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWindSpeed.Location = new System.Drawing.Point(378, 213);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(138, 29);
            this.labelWindSpeed.TabIndex = 12;
            this.labelWindSpeed.Text = "Wind Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(378, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pressure:";
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.Location = new System.Drawing.Point(44, 148);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(100, 50);
            this.weatherIcon.TabIndex = 15;
            this.weatherIcon.TabStop = false;
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_city.Location = new System.Drawing.Point(119, 66);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(203, 36);
            this.textBox_city.TabIndex = 16;
            // 
            // labelCondition_2
            // 
            this.labelCondition_2.AutoSize = true;
            this.labelCondition_2.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition_2.Enabled = false;
            this.labelCondition_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition_2.Location = new System.Drawing.Point(183, 212);
            this.labelCondition_2.Name = "labelCondition_2";
            this.labelCondition_2.Size = new System.Drawing.Size(0, 29);
            this.labelCondition_2.TabIndex = 17;
            // 
            // labelDetails_2
            // 
            this.labelDetails_2.AutoSize = true;
            this.labelDetails_2.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails_2.Enabled = false;
            this.labelDetails_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails_2.Location = new System.Drawing.Point(183, 265);
            this.labelDetails_2.Name = "labelDetails_2";
            this.labelDetails_2.Size = new System.Drawing.Size(0, 29);
            this.labelDetails_2.TabIndex = 18;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(378, 324);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(73, 29);
            this.labelTemp.TabIndex = 19;
            this.labelTemp.Text = "Temp:";
            // 
            // labelTemp_2
            // 
            this.labelTemp_2.AutoSize = true;
            this.labelTemp_2.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp_2.ForeColor = System.Drawing.Color.White;
            this.labelTemp_2.Location = new System.Drawing.Point(542, 324);
            this.labelTemp_2.Name = "labelTemp_2";
            this.labelTemp_2.Size = new System.Drawing.Size(0, 29);
            this.labelTemp_2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.paul_pastourmatzis_KT3WlrL_bsg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTemp_2);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelDetails_2);
            this.Controls.Add(this.labelCondition_2);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.labelPressure_2);
            this.Controls.Add(this.labelWindSpeed_2);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSunset_2);
            this.Controls.Add(this.labelSunrise_2);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunrise_2;
        private System.Windows.Forms.Label labelSunset_2;
        private System.Windows.Forms.Label labelPressure_2;
        private System.Windows.Forms.Label labelWindSpeed_2;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label labelCondition_2;
        private System.Windows.Forms.Label labelDetails_2;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelTemp_2;
    }
}

