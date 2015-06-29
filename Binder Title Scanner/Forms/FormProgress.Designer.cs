namespace BTS.Forms
{
    partial class FormProgress
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
            this.pbarTitleProgress = new System.Windows.Forms.ProgressBar();
            this.lblEventText = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.pbarTitleProgress, 0, 1);
            this.tlpMain.Controls.Add(this.lblEventText, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(671, 136);
            this.tlpMain.TabIndex = 0;
            // 
            // pbarTitleProgress
            // 
            this.pbarTitleProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbarTitleProgress.Location = new System.Drawing.Point(3, 78);
            this.pbarTitleProgress.Name = "pbarTitleProgress";
            this.pbarTitleProgress.Size = new System.Drawing.Size(665, 34);
            this.pbarTitleProgress.TabIndex = 0;
            // 
            // lblEventText
            // 
            this.lblEventText.AutoSize = true;
            this.lblEventText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventText.Location = new System.Drawing.Point(3, 0);
            this.lblEventText.Name = "lblEventText";
            this.lblEventText.Size = new System.Drawing.Size(665, 75);
            this.lblEventText.TabIndex = 1;
            this.lblEventText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 136);
            this.Controls.Add(this.tlpMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.Text = "Progress";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ProgressBar pbarTitleProgress;
        private System.Windows.Forms.Label lblEventText;
    }
}