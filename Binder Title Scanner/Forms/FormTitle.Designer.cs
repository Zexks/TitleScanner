using BTS.UserControls;

namespace BTS.Forms
{
    partial class FormTitle
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.packageEntry = new PackageEntry();
            this.manualEntry = new ManualEntry();
            this.tlpInteration = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoManual = new System.Windows.Forms.RadioButton();
            this.rdoPackage = new System.Windows.Forms.RadioButton();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tlpInteration.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.packageEntry);
            this.splitMain.Panel1.Controls.Add(this.manualEntry);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tlpInteration);
            this.splitMain.Size = new System.Drawing.Size(672, 117);
            this.splitMain.SplitterDistance = 81;
            this.splitMain.TabIndex = 0;
            this.splitMain.TabStop = false;
            // 
            // packageEntry
            // 
            this.packageEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.packageEntry.Location = new System.Drawing.Point(0, 52);
            this.packageEntry.Name = "packageEntry";
            this.packageEntry.Size = new System.Drawing.Size(672, 27);
            this.packageEntry.TabIndex = 1;
            // 
            // manualEntry
            // 
            this.manualEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.manualEntry.Location = new System.Drawing.Point(0, 0);
            this.manualEntry.Name = "manualEntry";
            this.manualEntry.Size = new System.Drawing.Size(672, 52);
            this.manualEntry.TabIndex = 0;
            // 
            // tlpInteration
            // 
            this.tlpInteration.ColumnCount = 6;
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInteration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInteration.Controls.Add(this.btnCancel, 5, 0);
            this.tlpInteration.Controls.Add(this.btnSave, 4, 0);
            this.tlpInteration.Controls.Add(this.rdoManual, 1, 0);
            this.tlpInteration.Controls.Add(this.rdoPackage, 0, 0);
            this.tlpInteration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInteration.Location = new System.Drawing.Point(0, 0);
            this.tlpInteration.Name = "tlpInteration";
            this.tlpInteration.RowCount = 1;
            this.tlpInteration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInteration.Size = new System.Drawing.Size(672, 32);
            this.tlpInteration.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(585, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(495, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoManual
            // 
            this.rdoManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoManual.AutoSize = true;
            this.rdoManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoManual.Location = new System.Drawing.Point(93, 3);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(84, 26);
            this.rdoManual.TabIndex = 2;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "Manual";
            this.rdoManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoManual.UseVisualStyleBackColor = true;
            this.rdoManual.CheckedChanged += new System.EventHandler(this.rdoManual_CheckedChanged);
            // 
            // rdoPackage
            // 
            this.rdoPackage.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPackage.AutoSize = true;
            this.rdoPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoPackage.Location = new System.Drawing.Point(3, 3);
            this.rdoPackage.Name = "rdoPackage";
            this.rdoPackage.Size = new System.Drawing.Size(84, 26);
            this.rdoPackage.TabIndex = 3;
            this.rdoPackage.TabStop = true;
            this.rdoPackage.Text = "Package";
            this.rdoPackage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPackage.UseVisualStyleBackColor = true;
            this.rdoPackage.CheckedChanged += new System.EventHandler(this.rdoPackage_CheckedChanged);
            // 
            // bgwSave
            // 
            this.bgwSave.WorkerReportsProgress = true;
            this.bgwSave.WorkerSupportsCancellation = true;
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSave_ProgressChanged);
            // 
            // FormTitle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(672, 117);
            this.Controls.Add(this.splitMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTitle";
            this.Text = "Title";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.tlpInteration.ResumeLayout(false);
            this.tlpInteration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private PackageEntry packageEntry;
        private ManualEntry manualEntry;
        private System.Windows.Forms.TableLayoutPanel tlpInteration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoManual;
        private System.Windows.Forms.RadioButton rdoPackage;
        private System.ComponentModel.BackgroundWorker bgwSave;
    }
}