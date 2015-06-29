namespace BTS.UserControls
{
    partial class SQLLocation
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpFileRoom = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoLFR = new System.Windows.Forms.RadioButton();
            this.rdoCFR = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.tlpLocation = new System.Windows.Forms.TableLayoutPanel();
            this.rdoRemote = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.lblOfficeServer = new System.Windows.Forms.Label();
            this.txtOfficeServer = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.grpFileRoom.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.tlpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpFileRoom, 0, 0);
            this.tlpMain.Controls.Add(this.grpLocation, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(543, 53);
            this.tlpMain.TabIndex = 7;
            // 
            // grpFileRoom
            // 
            this.grpFileRoom.Controls.Add(this.flowLayoutPanel3);
            this.grpFileRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFileRoom.Location = new System.Drawing.Point(3, 3);
            this.grpFileRoom.Name = "grpFileRoom";
            this.grpFileRoom.Size = new System.Drawing.Size(114, 47);
            this.grpFileRoom.TabIndex = 3;
            this.grpFileRoom.TabStop = false;
            this.grpFileRoom.Text = "File Room";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.rdoLFR);
            this.flowLayoutPanel3.Controls.Add(this.rdoCFR);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(108, 28);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // rdoLFR
            // 
            this.rdoLFR.AutoSize = true;
            this.rdoLFR.Checked = true;
            this.rdoLFR.Location = new System.Drawing.Point(3, 3);
            this.rdoLFR.Name = "rdoLFR";
            this.rdoLFR.Size = new System.Drawing.Size(45, 17);
            this.rdoLFR.TabIndex = 0;
            this.rdoLFR.TabStop = true;
            this.rdoLFR.Text = "LFR";
            this.rdoLFR.UseVisualStyleBackColor = true;
            // 
            // rdoCFR
            // 
            this.rdoCFR.AutoSize = true;
            this.rdoCFR.Location = new System.Drawing.Point(54, 3);
            this.rdoCFR.Name = "rdoCFR";
            this.rdoCFR.Size = new System.Drawing.Size(46, 17);
            this.rdoCFR.TabIndex = 1;
            this.rdoCFR.Text = "CFR";
            this.rdoCFR.UseVisualStyleBackColor = true;
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.tlpLocation);
            this.grpLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLocation.Location = new System.Drawing.Point(123, 3);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(417, 47);
            this.grpLocation.TabIndex = 2;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // tlpLocation
            // 
            this.tlpLocation.ColumnCount = 4;
            this.tlpLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLocation.Controls.Add(this.rdoRemote, 0, 0);
            this.tlpLocation.Controls.Add(this.rdoLocal, 0, 0);
            this.tlpLocation.Controls.Add(this.lblOfficeServer, 2, 0);
            this.tlpLocation.Controls.Add(this.txtOfficeServer, 3, 0);
            this.tlpLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLocation.Location = new System.Drawing.Point(3, 16);
            this.tlpLocation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.tlpLocation.Name = "tlpLocation";
            this.tlpLocation.RowCount = 1;
            this.tlpLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLocation.Size = new System.Drawing.Size(411, 28);
            this.tlpLocation.TabIndex = 0;
            // 
            // rdoRemote
            // 
            this.rdoRemote.AutoSize = true;
            this.rdoRemote.Location = new System.Drawing.Point(63, 3);
            this.rdoRemote.Name = "rdoRemote";
            this.rdoRemote.Size = new System.Drawing.Size(62, 17);
            this.rdoRemote.TabIndex = 11;
            this.rdoRemote.TabStop = true;
            this.rdoRemote.Text = "Remote";
            this.rdoRemote.UseVisualStyleBackColor = true;
            this.rdoRemote.CheckedChanged += new System.EventHandler(this.rdoRemote_CheckedChanged);
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Checked = true;
            this.rdoLocal.Location = new System.Drawing.Point(3, 3);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(51, 17);
            this.rdoLocal.TabIndex = 7;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local";
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.rdoLocal_CheckedChanged);
            // 
            // lblOfficeServer
            // 
            this.lblOfficeServer.AutoSize = true;
            this.lblOfficeServer.Location = new System.Drawing.Point(153, 5);
            this.lblOfficeServer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblOfficeServer.Name = "lblOfficeServer";
            this.lblOfficeServer.Size = new System.Drawing.Size(72, 13);
            this.lblOfficeServer.TabIndex = 9;
            this.lblOfficeServer.Text = "Office Server:";
            this.lblOfficeServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOfficeServer
            // 
            this.txtOfficeServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOfficeServer.Enabled = false;
            this.txtOfficeServer.Location = new System.Drawing.Point(233, 3);
            this.txtOfficeServer.Name = "txtOfficeServer";
            this.txtOfficeServer.Size = new System.Drawing.Size(175, 20);
            this.txtOfficeServer.TabIndex = 10;
            // 
            // SQLLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "SQLLocation";
            this.Size = new System.Drawing.Size(543, 53);
            this.tlpMain.ResumeLayout(false);
            this.grpFileRoom.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.tlpLocation.ResumeLayout(false);
            this.tlpLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpFileRoom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoLFR;
        private System.Windows.Forms.RadioButton rdoCFR;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.TableLayoutPanel tlpLocation;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.Label lblOfficeServer;
        private System.Windows.Forms.TextBox txtOfficeServer;
        private System.Windows.Forms.RadioButton rdoRemote;


    }
}
