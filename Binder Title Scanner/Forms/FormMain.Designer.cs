using BTS.UserControls;

namespace BTS.Forms
{
    partial class FormMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlTypeDisplay = new System.Windows.Forms.Panel();
            this.setPackage = new PackageEntry();
            this.setLive = new LiveSet();
            this.tlpType = new System.Windows.Forms.TableLayoutPanel();
            this.rdoPkg = new System.Windows.Forms.RadioButton();
            this.setLocation = new SQLLocation();
            this.rdoLive = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTitleMgr = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pnlTypeDisplay.SuspendLayout();
            this.tlpType.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpMain.Controls.Add(this.dgvResults, 0, 2);
            this.tlpMain.Controls.Add(this.pnlTypeDisplay, 0, 1);
            this.tlpMain.Controls.Add(this.tlpType, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(703, 586);
            this.tlpMain.TabIndex = 0;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMain.SetColumnSpan(this.dgvResults, 3);
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 139);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(697, 444);
            this.dgvResults.TabIndex = 9;
            this.dgvResults.TabStop = false;
            // 
            // pnlTypeDisplay
            // 
            this.pnlTypeDisplay.Controls.Add(this.setPackage);
            this.pnlTypeDisplay.Controls.Add(this.setLive);
            this.pnlTypeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTypeDisplay.Location = new System.Drawing.Point(3, 70);
            this.pnlTypeDisplay.Name = "pnlTypeDisplay";
            this.pnlTypeDisplay.Size = new System.Drawing.Size(593, 63);
            this.pnlTypeDisplay.TabIndex = 11;
            // 
            // setPackage
            // 
            this.setPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setPackage.Location = new System.Drawing.Point(0, 0);
            this.setPackage.Margin = new System.Windows.Forms.Padding(0);
            this.setPackage.Name = "setPackage";
            this.setPackage.Size = new System.Drawing.Size(593, 63);
            this.setPackage.TabIndex = 1;
            // 
            // setLive
            // 
            this.setLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setLive.Location = new System.Drawing.Point(0, 0);
            this.setLive.Name = "setLive";
            this.setLive.Size = new System.Drawing.Size(593, 63);
            this.setLive.TabIndex = 0;
            // 
            // tlpType
            // 
            this.tlpType.ColumnCount = 2;
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpType.Controls.Add(this.rdoPkg, 0, 0);
            this.tlpType.Controls.Add(this.setLocation, 1, 0);
            this.tlpType.Controls.Add(this.rdoLive, 0, 1);
            this.tlpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpType.Location = new System.Drawing.Point(3, 3);
            this.tlpType.Name = "tlpType";
            this.tlpType.RowCount = 2;
            this.tlpType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpType.Size = new System.Drawing.Size(593, 61);
            this.tlpType.TabIndex = 13;
            // 
            // rdoPkg
            // 
            this.rdoPkg.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPkg.AutoSize = true;
            this.rdoPkg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoPkg.Location = new System.Drawing.Point(0, 3);
            this.rdoPkg.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.rdoPkg.Name = "rdoPkg";
            this.rdoPkg.Size = new System.Drawing.Size(97, 27);
            this.rdoPkg.TabIndex = 0;
            this.rdoPkg.TabStop = true;
            this.rdoPkg.Text = "Package";
            this.rdoPkg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPkg.UseVisualStyleBackColor = true;
            this.rdoPkg.CheckedChanged += new System.EventHandler(this.rdoPkg_CheckedChanged);
            // 
            // setLocation
            // 
            this.setLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setLocation.Location = new System.Drawing.Point(100, 0);
            this.setLocation.Margin = new System.Windows.Forms.Padding(0);
            this.setLocation.Name = "setLocation";
            this.tlpType.SetRowSpan(this.setLocation, 2);
            this.setLocation.Size = new System.Drawing.Size(493, 61);
            this.setLocation.TabIndex = 4;
            // 
            // rdoLive
            // 
            this.rdoLive.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoLive.AutoSize = true;
            this.rdoLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoLive.Location = new System.Drawing.Point(0, 33);
            this.rdoLive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.rdoLive.Name = "rdoLive";
            this.rdoLive.Size = new System.Drawing.Size(97, 28);
            this.rdoLive.TabIndex = 1;
            this.rdoLive.TabStop = true;
            this.rdoLive.Text = "Database";
            this.rdoLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLive.UseVisualStyleBackColor = true;
            this.rdoLive.CheckedChanged += new System.EventHandler(this.rdoLive_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnTitleMgr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnScan, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(602, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tlpMain.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(98, 130);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnTitleMgr
            // 
            this.btnTitleMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTitleMgr.Location = new System.Drawing.Point(0, 3);
            this.btnTitleMgr.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnTitleMgr.Name = "btnTitleMgr";
            this.btnTitleMgr.Size = new System.Drawing.Size(95, 29);
            this.btnTitleMgr.TabIndex = 16;
            this.btnTitleMgr.Text = "Title Manager";
            this.btnTitleMgr.UseVisualStyleBackColor = true;
            this.btnTitleMgr.Click += new System.EventHandler(this.btnTitleMgr_Click);
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScan.Location = new System.Drawing.Point(0, 35);
            this.btnScan.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(95, 29);
            this.btnScan.TabIndex = 15;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 586);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormMain";
            this.Text = "Binder Title Scanner";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pnlTypeDisplay.ResumeLayout(false);
            this.tlpType.ResumeLayout(false);
            this.tlpType.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel pnlTypeDisplay;
        private PackageEntry setPackage;
        private LiveSet setLive;
        private System.Windows.Forms.TableLayoutPanel tlpType;
        private System.Windows.Forms.RadioButton rdoPkg;
        private SQLLocation setLocation;
        private System.Windows.Forms.RadioButton rdoLive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTitleMgr;
        private System.Windows.Forms.Button btnScan;

    }
}

