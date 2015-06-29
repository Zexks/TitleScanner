using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BTS.Forms
{
    partial class FormTitleMgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.splitMain = new SplitContainer();
            this.flpFunctions = new FlowLayoutPanel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.dgvTitles = new DataGridView();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.flpFunctions.SuspendLayout();
            ((ISupportInitialize)(this.dgvTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = DockStyle.Fill;
            this.splitMain.FixedPanel = FixedPanel.Panel1;
            this.splitMain.Location = new Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.flpFunctions);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.dgvTitles);
            this.splitMain.Size = new Size(692, 439);
            this.splitMain.SplitterDistance = 34;
            this.splitMain.TabIndex = 0;
            // 
            // flpFunctions
            // 
            this.flpFunctions.Controls.Add(this.btnAdd);
            this.flpFunctions.Controls.Add(this.btnEdit);
            this.flpFunctions.Controls.Add(this.btnDelete);
            this.flpFunctions.Dock = DockStyle.Fill;
            this.flpFunctions.Location = new Point(0, 0);
            this.flpFunctions.Name = "flpFunctions";
            this.flpFunctions.Padding = new Padding(5, 3, 0, 0);
            this.flpFunctions.Size = new Size(692, 34);
            this.flpFunctions.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(8, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new Point(89, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(170, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // dgvTitles
            // 
            this.dgvTitles.AllowUserToAddRows = false;
            this.dgvTitles.AllowUserToDeleteRows = false;
            this.dgvTitles.AllowUserToResizeRows = false;
            this.dgvTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitles.Dock = DockStyle.Fill;
            this.dgvTitles.Location = new Point(0, 0);
            this.dgvTitles.MultiSelect = false;
            this.dgvTitles.Name = "dgvTitles";
            this.dgvTitles.ReadOnly = true;
            this.dgvTitles.RowHeadersVisible = false;
            this.dgvTitles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitles.Size = new Size(692, 401);
            this.dgvTitles.TabIndex = 0;
            // 
            // FormTitleMgr
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(692, 439);
            this.Controls.Add(this.splitMain);
            this.Name = "FormTitleMgr";
            this.Text = "Title Manager";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.flpFunctions.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvTitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitMain;
        private FlowLayoutPanel flpFunctions;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvTitles;
    }
}