namespace COE114L_Projectv3
{
    partial class ViewReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReportForm));
            this.listViewReports = new System.Windows.Forms.ListView();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpVote = new System.Windows.Forms.Button();
            this.buttonDownVote = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelReportedBy = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelLng = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelReportNum = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.buttonResolve = new System.Windows.Forms.Button();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewReports
            // 
            this.listViewReports.Location = new System.Drawing.Point(12, 12);
            this.listViewReports.Name = "listViewReports";
            this.listViewReports.Size = new System.Drawing.Size(679, 300);
            this.listViewReports.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewReports.TabIndex = 0;
            this.listViewReports.UseCompatibleStateImageBehavior = false;
            this.listViewReports.SelectedIndexChanged += new System.EventHandler(this.listViewReports_SelectedIndexChanged);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(743, 299);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(29, 13);
            this.linkLabelHelp.TabIndex = 31;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Help";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(697, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpVote
            // 
            this.buttonUpVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpVote.Location = new System.Drawing.Point(697, 218);
            this.buttonUpVote.Name = "buttonUpVote";
            this.buttonUpVote.Size = new System.Drawing.Size(75, 23);
            this.buttonUpVote.TabIndex = 34;
            this.buttonUpVote.Text = "Up Vote";
            this.buttonUpVote.UseVisualStyleBackColor = false;
            this.buttonUpVote.Click += new System.EventHandler(this.buttonUpDownVote_Click);
            // 
            // buttonDownVote
            // 
            this.buttonDownVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDownVote.Location = new System.Drawing.Point(697, 247);
            this.buttonDownVote.Name = "buttonDownVote";
            this.buttonDownVote.Size = new System.Drawing.Size(75, 23);
            this.buttonDownVote.TabIndex = 35;
            this.buttonDownVote.Text = "Down Vote";
            this.buttonDownVote.UseVisualStyleBackColor = false;
            this.buttonDownVote.Click += new System.EventHandler(this.buttonDownVote_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(697, 88);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 36;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.labelReportedBy);
            this.groupBoxDetails.Controls.Add(this.labelDesc);
            this.groupBoxDetails.Controls.Add(this.labelAdress);
            this.groupBoxDetails.Controls.Add(this.labelLng);
            this.groupBoxDetails.Controls.Add(this.labelLat);
            this.groupBoxDetails.Controls.Add(this.labelPoints);
            this.groupBoxDetails.Controls.Add(this.labelReportNum);
            this.groupBoxDetails.Controls.Add(this.labelTitle);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 318);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(524, 231);
            this.groupBoxDetails.TabIndex = 38;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Visible = false;
            // 
            // labelReportedBy
            // 
            this.labelReportedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReportedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportedBy.Location = new System.Drawing.Point(6, 208);
            this.labelReportedBy.Name = "labelReportedBy";
            this.labelReportedBy.Size = new System.Drawing.Size(511, 20);
            this.labelReportedBy.TabIndex = 7;
            this.labelReportedBy.Text = "Report#";
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(6, 85);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(513, 40);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Description";
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(5, 180);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(512, 20);
            this.labelAdress.TabIndex = 6;
            this.labelAdress.Text = "Lat";
            this.labelAdress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLng
            // 
            this.labelLng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLng.Location = new System.Drawing.Point(295, 160);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(224, 20);
            this.labelLng.TabIndex = 5;
            this.labelLng.Text = "Longitude";
            this.labelLng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLat
            // 
            this.labelLat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLat.Location = new System.Drawing.Point(5, 160);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(224, 20);
            this.labelLat.TabIndex = 4;
            this.labelLat.Text = "Latitude";
            this.labelLat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(294, 56);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(224, 57);
            this.labelPoints.TabIndex = 3;
            this.labelPoints.Text = "Points";
            // 
            // labelReportNum
            // 
            this.labelReportNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReportNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportNum.Location = new System.Drawing.Point(6, 56);
            this.labelReportNum.Name = "labelReportNum";
            this.labelReportNum.Size = new System.Drawing.Size(224, 57);
            this.labelReportNum.TabIndex = 1;
            this.labelReportNum.Text = "Report#";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(4, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(514, 67);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = false;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(542, 319);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 5;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(230, 230);
            this.gmap.TabIndex = 39;
            this.gmap.Zoom = 17D;
            // 
            // buttonResolve
            // 
            this.buttonResolve.Location = new System.Drawing.Point(697, 153);
            this.buttonResolve.Name = "buttonResolve";
            this.buttonResolve.Size = new System.Drawing.Size(75, 23);
            this.buttonResolve.TabIndex = 40;
            this.buttonResolve.Text = "Resolve";
            this.buttonResolve.UseVisualStyleBackColor = true;
            this.buttonResolve.Visible = false;
            this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            // 
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonResolve);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonDownVote);
            this.Controls.Add(this.buttonUpVote);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.listViewReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Reports";
            this.groupBoxDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReports;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpVote;
        private System.Windows.Forms.Button buttonDownVote;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelReportNum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.Label labelLat;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label labelReportedBy;
        private System.Windows.Forms.Button buttonResolve;

    }
}