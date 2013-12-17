namespace Speech_Recognition
{
    partial class frmMainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.button1btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoomLevels = new System.Windows.Forms.ComboBox();
            this.mapTypeCombo = new System.Windows.Forms.ComboBox();
            this.fullAddress = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.mapViewer = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1btnSearch);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(9, 16);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(763, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // button1btnSearch
            // 
            this.button1btnSearch.Location = new System.Drawing.Point(778, 12);
            this.button1btnSearch.Name = "button1btnSearch";
            this.button1btnSearch.Size = new System.Drawing.Size(75, 23);
            this.button1btnSearch.TabIndex = 1;
            this.button1btnSearch.Text = "Search";
            this.button1btnSearch.UseVisualStyleBackColor = true;
            this.button1btnSearch.Click += new System.EventHandler(this.button1btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mapViewer);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(175, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 519);
            this.panel1.TabIndex = 1;
            // 
            // zoomLevels
            // 
            this.zoomLevels.FormattingEnabled = true;
            this.zoomLevels.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12",
            "15",
            "18",
            "20"});
            this.zoomLevels.Location = new System.Drawing.Point(14, 65);
            this.zoomLevels.Name = "zoomLevels";
            this.zoomLevels.Size = new System.Drawing.Size(155, 21);
            this.zoomLevels.TabIndex = 2;
            this.zoomLevels.Text = "Select Zoom Level";
            this.zoomLevels.SelectedIndexChanged += new System.EventHandler(this.zoomLevels_SelectedIndexChanged);
            // 
            // mapTypeCombo
            // 
            this.mapTypeCombo.FormattingEnabled = true;
            this.mapTypeCombo.Items.AddRange(new object[] {
            "roadmap",
            "satellite",
            "hybrid",
            "terrain"});
            this.mapTypeCombo.Location = new System.Drawing.Point(14, 92);
            this.mapTypeCombo.Name = "mapTypeCombo";
            this.mapTypeCombo.Size = new System.Drawing.Size(155, 21);
            this.mapTypeCombo.TabIndex = 3;
            // 
            // fullAddress
            // 
            this.fullAddress.Location = new System.Drawing.Point(14, 119);
            this.fullAddress.Multiline = true;
            this.fullAddress.Name = "fullAddress";
            this.fullAddress.ReadOnly = true;
            this.fullAddress.Size = new System.Drawing.Size(155, 191);
            this.fullAddress.TabIndex = 4;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(14, 316);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(155, 20);
            this.txtLongitude.TabIndex = 5;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(14, 342);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(155, 20);
            this.txtLatitude.TabIndex = 6;
            // 
            // mapViewer
            // 
            this.mapViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapViewer.Location = new System.Drawing.Point(0, 0);
            this.mapViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapViewer.Name = "mapViewer";
            this.mapViewer.Size = new System.Drawing.Size(689, 519);
            this.mapViewer.TabIndex = 0;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 562);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.fullAddress);
            this.Controls.Add(this.mapTypeCombo);
            this.Controls.Add(this.zoomLevels);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(5, 4);
            this.Name = "frmMainWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1btnSearch;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox zoomLevels;
        private System.Windows.Forms.ComboBox mapTypeCombo;
        private System.Windows.Forms.TextBox fullAddress;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.WebBrowser mapViewer;
    }
}