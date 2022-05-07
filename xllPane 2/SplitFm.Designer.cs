namespace xllPane_2
{
    partial class SplitFm
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
            this.Ok_Butt = new System.Windows.Forms.Button();
            this.Cancel_Butt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeparatorBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberSplit = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearButt = new System.Windows.Forms.Button();
            this.ShowButt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultlist = new System.Windows.Forms.ListView();
            this.colresult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSplit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Ok_Butt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_Butt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Ok_Butt
            // 
            this.Ok_Butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ok_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok_Butt.Image = global::xllPane_2.Properties.Resources.agt_login;
            this.Ok_Butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok_Butt.Location = new System.Drawing.Point(3, 3);
            this.Ok_Butt.Name = "Ok_Butt";
            this.Ok_Butt.Size = new System.Drawing.Size(548, 29);
            this.Ok_Butt.TabIndex = 0;
            this.Ok_Butt.Text = "ОК";
            this.Ok_Butt.UseVisualStyleBackColor = true;
            this.Ok_Butt.Click += new System.EventHandler(this.Ok_Butt_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1109, 177);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 171);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeparatorBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите разделитель";
            // 
            // SeparatorBox
            // 
            this.SeparatorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeparatorBox.Location = new System.Drawing.Point(3, 16);
            this.SeparatorBox.Name = "SeparatorBox";
            this.SeparatorBox.Size = new System.Drawing.Size(536, 20);
            this.SeparatorBox.TabIndex = 0;
            this.SeparatorBox.TextChanged += new System.EventHandler(this.SeparatorBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberSplit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Номер вхождения";
            // 
            // NumberSplit
            // 
            this.NumberSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberSplit.Location = new System.Drawing.Point(3, 16);
            this.NumberSplit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberSplit.Name = "NumberSplit";
            this.NumberSplit.Size = new System.Drawing.Size(536, 20);
            this.NumberSplit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearButt);
            this.groupBox3.Controls.Add(this.ShowButt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(3, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Предпросмотр";
            // 
            // ClearButt
            // 
            this.ClearButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButt.Image = global::xllPane_2.Properties.Resources.agt_action_fail;
            this.ClearButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButt.Location = new System.Drawing.Point(385, 19);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(151, 29);
            this.ClearButt.TabIndex = 1;
            this.ClearButt.Text = "Очистить всё...";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // ShowButt
            // 
            this.ShowButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowButt.Image = global::xllPane_2.Properties.Resources.xmag;
            this.ShowButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButt.Location = new System.Drawing.Point(6, 19);
            this.ShowButt.Name = "ShowButt";
            this.ShowButt.Size = new System.Drawing.Size(151, 29);
            this.ShowButt.TabIndex = 0;
            this.ShowButt.Text = "Показать результат";
            this.ShowButt.UseVisualStyleBackColor = true;
            this.ShowButt.Click += new System.EventHandler(this.ShowButt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultlist);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(557, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(549, 171);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
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
            this.resultlist.Size = new System.Drawing.Size(543, 152);
            this.resultlist.TabIndex = 0;
            this.resultlist.UseCompatibleStateImageBehavior = false;
            this.resultlist.View = System.Windows.Forms.View.Details;
            // 
            // colresult
            // 
            this.colresult.Text = "";
            this.colresult.Width = 535;
            // 
            // SplitFm
            // 
            this.AcceptButton = this.Ok_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Butt;
            this.ClientSize = new System.Drawing.Size(1109, 212);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplitFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SplitFm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberSplit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SeparatorBox;
        private System.Windows.Forms.NumericUpDown NumberSplit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Ok_Butt;
        private System.Windows.Forms.Button Cancel_Butt;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button ShowButt;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.ColumnHeader colresult;
    }
}