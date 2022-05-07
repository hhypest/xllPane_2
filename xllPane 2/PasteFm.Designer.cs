namespace xllPane_2
{
    partial class PasteFm
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
            this.PasteBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AllRadio = new System.Windows.Forms.RadioButton();
            this.PredRadio = new System.Windows.Forms.RadioButton();
            this.OutRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultlist = new System.Windows.Forms.ListView();
            this.colresult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 35);
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
            this.Ok_Butt.Size = new System.Drawing.Size(556, 29);
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
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 216);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
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
            this.groupBox1.Controls.Add(this.PasteBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инкапсулируемый текст";
            // 
            // PasteBox
            // 
            this.PasteBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasteBox.Location = new System.Drawing.Point(3, 16);
            this.PasteBox.Name = "PasteBox";
            this.PasteBox.Size = new System.Drawing.Size(544, 20);
            this.PasteBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AllRadio);
            this.groupBox2.Controls.Add(this.PredRadio);
            this.groupBox2.Controls.Add(this.OutRadio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Местоположение";
            // 
            // AllRadio
            // 
            this.AllRadio.AutoSize = true;
            this.AllRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllRadio.Location = new System.Drawing.Point(6, 85);
            this.AllRadio.Name = "AllRadio";
            this.AllRadio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.AllRadio.Size = new System.Drawing.Size(101, 27);
            this.AllRadio.TabIndex = 2;
            this.AllRadio.TabStop = true;
            this.AllRadio.Tag = "2";
            this.AllRadio.Text = "С обеих сторон";
            this.AllRadio.UseVisualStyleBackColor = true;
            this.AllRadio.CheckedChanged += new System.EventHandler(this.AllRadio_CheckedChanged);
            // 
            // PredRadio
            // 
            this.PredRadio.AutoSize = true;
            this.PredRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PredRadio.Location = new System.Drawing.Point(6, 19);
            this.PredRadio.Name = "PredRadio";
            this.PredRadio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PredRadio.Size = new System.Drawing.Size(101, 27);
            this.PredRadio.TabIndex = 0;
            this.PredRadio.TabStop = true;
            this.PredRadio.Tag = "0";
            this.PredRadio.Text = "Перед текстом";
            this.PredRadio.UseVisualStyleBackColor = true;
            this.PredRadio.CheckedChanged += new System.EventHandler(this.PredRadio_CheckedChanged);
            // 
            // OutRadio
            // 
            this.OutRadio.AutoSize = true;
            this.OutRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OutRadio.Location = new System.Drawing.Point(6, 52);
            this.OutRadio.Name = "OutRadio";
            this.OutRadio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.OutRadio.Size = new System.Drawing.Size(93, 27);
            this.OutRadio.TabIndex = 1;
            this.OutRadio.TabStop = true;
            this.OutRadio.Tag = "1";
            this.OutRadio.Text = "После текста";
            this.OutRadio.UseVisualStyleBackColor = true;
            this.OutRadio.CheckedChanged += new System.EventHandler(this.OutRadio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultlist);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(565, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 210);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
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
            // PasteFm
            // 
            this.AcceptButton = this.Ok_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Butt;
            this.ClientSize = new System.Drawing.Size(1125, 251);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasteFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasteFm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Ok_Butt;
        private System.Windows.Forms.Button Cancel_Butt;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.ColumnHeader colresult;
        private System.Windows.Forms.TextBox PasteBox;
        private System.Windows.Forms.RadioButton AllRadio;
        private System.Windows.Forms.RadioButton OutRadio;
        private System.Windows.Forms.RadioButton PredRadio;
    }
}