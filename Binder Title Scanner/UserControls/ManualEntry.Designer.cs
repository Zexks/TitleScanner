namespace BTS.UserControls
{
    partial class ManualEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpManualLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.lblGuid = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpManualLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpManualLayout
            // 
            this.tlpManualLayout.ColumnCount = 4;
            this.tlpManualLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpManualLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpManualLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpManualLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpManualLayout.Controls.Add(this.txtVersion, 2, 1);
            this.tlpManualLayout.Controls.Add(this.txtYear, 3, 1);
            this.tlpManualLayout.Controls.Add(this.lblYear, 3, 0);
            this.tlpManualLayout.Controls.Add(this.lblVersion, 2, 0);
            this.tlpManualLayout.Controls.Add(this.txtGuid, 1, 1);
            this.tlpManualLayout.Controls.Add(this.lblGuid, 0, 1);
            this.tlpManualLayout.Controls.Add(this.txtTitle, 1, 0);
            this.tlpManualLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tlpManualLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpManualLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpManualLayout.Name = "tlpManualLayout";
            this.tlpManualLayout.RowCount = 2;
            this.tlpManualLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpManualLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpManualLayout.Size = new System.Drawing.Size(436, 52);
            this.tlpManualLayout.TabIndex = 0;
            // 
            // txtVersion
            // 
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(319, 29);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(54, 20);
            this.txtVersion.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Location = new System.Drawing.Point(379, 29);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(54, 20);
            this.txtYear.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Location = new System.Drawing.Point(379, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 26);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "&Year*";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(319, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 26);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "&Version*";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtGuid
            // 
            this.txtGuid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGuid.Location = new System.Drawing.Point(48, 29);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(265, 20);
            this.txtGuid.TabIndex = 1;
            // 
            // lblGuid
            // 
            this.lblGuid.AutoSize = true;
            this.lblGuid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuid.Location = new System.Drawing.Point(3, 26);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Size = new System.Drawing.Size(39, 26);
            this.lblGuid.TabIndex = 1;
            this.lblGuid.Text = "&Guid*";
            this.lblGuid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(48, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "&Title*";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManualEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpManualLayout);
            this.Name = "ManualEntry";
            this.Size = new System.Drawing.Size(436, 52);
            this.tlpManualLayout.ResumeLayout(false);
            this.tlpManualLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpManualLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtVersion;
    }
}
