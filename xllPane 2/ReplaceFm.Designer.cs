namespace xllPane_2
{
    partial class ReplaceFm
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
            this.OK_Butt = new System.Windows.Forms.Button();
            this.Cancel_Butt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReplacerBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Butt
            // 
            this.OK_Butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK_Butt.Image = global::xllPane_2.Properties.Resources.agt_login;
            this.OK_Butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK_Butt.Location = new System.Drawing.Point(3, 3);
            this.OK_Butt.Name = "OK_Butt";
            this.OK_Butt.Size = new System.Drawing.Size(556, 29);
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
            this.Cancel_Butt.Location = new System.Drawing.Point(565, 3);
            this.Cancel_Butt.Name = "Cancel_Butt";
            this.Cancel_Butt.Size = new System.Drawing.Size(557, 29);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 216);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(556, 210);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регулярное выражение";
            // 
            // RegBox
            // 
            this.RegBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegBox.Location = new System.Drawing.Point(3, 16);
            this.RegBox.Name = "RegBox";
            this.RegBox.Size = new System.Drawing.Size(544, 20);
            this.RegBox.TabIndex = 0;
            this.RegBox.TextChanged += new System.EventHandler(this.RegBox_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(550, 152);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReplacerBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заменить на...";
            // 
            // ReplacerBox
            // 
            this.ReplacerBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReplacerBox.Location = new System.Drawing.Point(3, 16);
            this.ReplacerBox.Name = "ReplacerBox";
            this.ReplacerBox.Size = new System.Drawing.Size(263, 20);
            this.ReplacerBox.TabIndex = 0;
            this.ReplacerBox.TextChanged += new System.EventHandler(this.ReplacerBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearButt);
            this.groupBox3.Controls.Add(this.ShowButt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(278, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 146);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Предпросмотр";
            // 
            // ClearButt
            // 
            this.ClearButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButt.Image = global::xllPane_2.Properties.Resources.agt_action_fail;
            this.ClearButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButt.Location = new System.Drawing.Point(6, 111);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(257, 29);
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
            this.ShowButt.Size = new System.Drawing.Size(257, 29);
            this.ShowButt.TabIndex = 0;
            this.ShowButt.Text = "Предпросмотр результата";
            this.ShowButt.UseVisualStyleBackColor = true;
            this.ShowButt.Click += new System.EventHandler(this.ShowButt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultlist);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(565, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 210);
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
            // ReplaceFm
            // 
            this.AcceptButton = this.OK_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Butt;
            this.ClientSize = new System.Drawing.Size(1125, 251);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplaceFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReplaceFm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OK_Butt;
        private System.Windows.Forms.Button Cancel_Butt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.TextBox RegBox;
        private System.Windows.Forms.TextBox ReplacerBox;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button ShowButt;
        private System.Windows.Forms.ColumnHeader colresult;
    }
}