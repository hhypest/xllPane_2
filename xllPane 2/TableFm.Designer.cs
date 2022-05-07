namespace xllPane_2
{
    partial class TableFm
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
            this.CancelButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableList = new System.Windows.Forms.ListView();
            this.coltable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OK_Butt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 376);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 35);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.OK_Butt.Size = new System.Drawing.Size(173, 29);
            this.OK_Butt.TabIndex = 0;
            this.OK_Butt.Text = "ОК";
            this.OK_Butt.UseVisualStyleBackColor = true;
            this.OK_Butt.Click += new System.EventHandler(this.OK_Butt_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButt.Image = global::xllPane_2.Properties.Resources.kxconfig;
            this.CancelButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButt.Location = new System.Drawing.Point(182, 3);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(174, 29);
            this.CancelButt.TabIndex = 1;
            this.CancelButt.Text = "Отмена";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 376);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы данных в книге";
            // 
            // TableList
            // 
            this.TableList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableList.CheckBoxes = true;
            this.TableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coltable});
            this.TableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.TableList.HideSelection = false;
            this.TableList.Location = new System.Drawing.Point(3, 16);
            this.TableList.Name = "TableList";
            this.TableList.Size = new System.Drawing.Size(347, 351);
            this.TableList.TabIndex = 0;
            this.TableList.UseCompatibleStateImageBehavior = false;
            this.TableList.View = System.Windows.Forms.View.Details;
            // 
            // coltable
            // 
            this.coltable.Text = "";
            this.coltable.Width = 187;
            // 
            // TableFm
            // 
            this.AcceptButton = this.OK_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButt;
            this.ClientSize = new System.Drawing.Size(359, 411);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TableFm";
            this.Shown += new System.EventHandler(this.TableFm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OK_Butt;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView TableList;
        private System.Windows.Forms.ColumnHeader coltable;
    }
}