namespace BTS.UserControls
{
    partial class LiveSet
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.lblFRID = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.txtFileRoom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtBid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFRID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFileRoom, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBid
            // 
            this.txtBid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBid.Location = new System.Drawing.Point(78, 33);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(550, 20);
            this.txtBid.TabIndex = 3;
            // 
            // lblFRID
            // 
            this.lblFRID.AutoSize = true;
            this.lblFRID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFRID.Location = new System.Drawing.Point(3, 0);
            this.lblFRID.Name = "lblFRID";
            this.lblFRID.Size = new System.Drawing.Size(69, 28);
            this.lblFRID.TabIndex = 0;
            this.lblFRID.Text = "File Room";
            this.lblFRID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBID.Location = new System.Drawing.Point(3, 28);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(69, 28);
            this.lblBID.TabIndex = 1;
            this.lblBID.Text = "Binder GUID";
            this.lblBID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileRoom
            // 
            this.txtFileRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileRoom.Location = new System.Drawing.Point(78, 5);
            this.txtFileRoom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtFileRoom.Name = "txtFileRoom";
            this.txtFileRoom.Size = new System.Drawing.Size(550, 20);
            this.txtFileRoom.TabIndex = 2;
            // 
            // LiveSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LiveSet";
            this.Size = new System.Drawing.Size(631, 56);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label lblFRID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox txtFileRoom;
    }
}
