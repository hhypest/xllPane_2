namespace xllPane_2
{
    partial class PropFm
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
            this.ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propcaseb = new System.Windows.Forms.RadioButton();
            this.lowcaseb = new System.Windows.Forms.RadioButton();
            this.upcaseb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultlist = new System.Windows.Forms.ListView();
            this.colresult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ok_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ok_button
            // 
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Image = global::xllPane_2.Properties.Resources.agt_login;
            this.ok_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_button.Location = new System.Drawing.Point(3, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(556, 29);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_button.Image = global::xllPane_2.Properties.Resources.kxconfig;
            this.Cancel_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_button.Location = new System.Drawing.Point(565, 3);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(557, 29);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 216);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propcaseb);
            this.groupBox1.Controls.Add(this.lowcaseb);
            this.groupBox1.Controls.Add(this.upcaseb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преобразование символов";
            // 
            // propcaseb
            // 
            this.propcaseb.AutoSize = true;
            this.propcaseb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.propcaseb.Location = new System.Drawing.Point(9, 105);
            this.propcaseb.Name = "propcaseb";
            this.propcaseb.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.propcaseb.Size = new System.Drawing.Size(195, 37);
            this.propcaseb.TabIndex = 2;
            this.propcaseb.TabStop = true;
            this.propcaseb.Tag = "2";
            this.propcaseb.Text = "Каждое слово с заглавной буквы";
            this.propcaseb.UseVisualStyleBackColor = true;
            this.propcaseb.CheckedChanged += new System.EventHandler(this.Propcaseb_CheckedChanged);
            // 
            // lowcaseb
            // 
            this.lowcaseb.AutoSize = true;
            this.lowcaseb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lowcaseb.Location = new System.Drawing.Point(9, 62);
            this.lowcaseb.Name = "lowcaseb";
            this.lowcaseb.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lowcaseb.Size = new System.Drawing.Size(172, 37);
            this.lowcaseb.TabIndex = 1;
            this.lowcaseb.TabStop = true;
            this.lowcaseb.Tag = "1";
            this.lowcaseb.Text = "Символы в нижнем регистре";
            this.lowcaseb.UseVisualStyleBackColor = true;
            this.lowcaseb.CheckedChanged += new System.EventHandler(this.Lowcaseb_CheckedChanged);
            // 
            // upcaseb
            // 
            this.upcaseb.AutoSize = true;
            this.upcaseb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upcaseb.Location = new System.Drawing.Point(9, 19);
            this.upcaseb.Name = "upcaseb";
            this.upcaseb.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.upcaseb.Size = new System.Drawing.Size(175, 37);
            this.upcaseb.TabIndex = 0;
            this.upcaseb.TabStop = true;
            this.upcaseb.Tag = "0";
            this.upcaseb.Text = "Символы в верхнем регистре";
            this.upcaseb.UseVisualStyleBackColor = true;
            this.upcaseb.CheckedChanged += new System.EventHandler(this.Upcaseb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultlist);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(565, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // resultlist
            // 
            this.resultlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colresult});
            this.resultlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultlist.GridLines = true;
            this.resultlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.resultlist.HideSelection = false;
            this.resultlist.Location = new System.Drawing.Point(3, 16);
            this.resultlist.Name = "resultlist";
            this.resultlist.Size = new System.Drawing.Size(551, 191);
            this.resultlist.TabIndex = 0;
            this.resultlist.UseCompatibleStateImageBehavior = false;
            this.resultlist.View = System.Windows.Forms.View.Details;
            // 
            // colresult
            // 
            this.colresult.Text = "";
            this.colresult.Width = 540;
            // 
            // PropFm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1125, 251);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PropFm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton propcaseb;
        private System.Windows.Forms.RadioButton lowcaseb;
        private System.Windows.Forms.RadioButton upcaseb;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.ColumnHeader colresult;
    }
}