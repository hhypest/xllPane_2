namespace xllPane_2
{
    partial class SaveSheetFm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sheetlist = new System.Windows.Forms.ListView();
            this.colsheet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OK_Butt = new System.Windows.Forms.Button();
            this.Cancel_Butt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OK_Butt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_Butt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sheetlist);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Листы в книге";
            // 
            // sheetlist
            // 
            this.sheetlist.CheckBoxes = true;
            this.sheetlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colsheet});
            this.sheetlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetlist.FullRowSelect = true;
            this.sheetlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.sheetlist.HideSelection = false;
            this.sheetlist.Location = new System.Drawing.Point(3, 16);
            this.sheetlist.Name = "sheetlist";
            this.sheetlist.Size = new System.Drawing.Size(1103, 158);
            this.sheetlist.TabIndex = 0;
            this.sheetlist.UseCompatibleStateImageBehavior = false;
            this.sheetlist.View = System.Windows.Forms.View.List;
            // 
            // colsheet
            // 
            this.colsheet.Text = "";
            this.colsheet.Width = 250;
            // 
            // OK_Butt
            // 
            this.OK_Butt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK_Butt.Image = global::xllPane_2.Properties.Resources.agt_login;
            this.OK_Butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK_Butt.Location = new System.Drawing.Point(3, 3);
            this.OK_Butt.Name = "OK_Butt";
            this.OK_Butt.Size = new System.Drawing.Size(548, 29);
            this.OK_Butt.TabIndex = 0;
            this.OK_Butt.Text = "ОК";
            this.OK_Butt.UseVisualStyleBackColor = true;
            this.OK_Butt.Click += new System.EventHandler(this.OK_Butt_Click);
            // 
            // Cancel_Butt
            // 
            this.Cancel_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Butt.Image = global::xllPane_2.Properties.Resources.kxconfig;
            this.Cancel_Butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Butt.Location = new System.Drawing.Point(557, 3);
            this.Cancel_Butt.Name = "Cancel_Butt";
            this.Cancel_Butt.Size = new System.Drawing.Size(549, 29);
            this.Cancel_Butt.TabIndex = 1;
            this.Cancel_Butt.Text = "Отмена";
            this.Cancel_Butt.UseVisualStyleBackColor = true;
            this.Cancel_Butt.Click += new System.EventHandler(this.Cancel_Butt_Click);
            // 
            // SaveSheetFm
            // 
            this.AcceptButton = this.OK_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Butt;
            this.ClientSize = new System.Drawing.Size(1109, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveSheetFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveSheetFm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView sheetlist;
        private System.Windows.Forms.ColumnHeader colsheet;
        private System.Windows.Forms.Button OK_Butt;
        private System.Windows.Forms.Button Cancel_Butt;
    }
}