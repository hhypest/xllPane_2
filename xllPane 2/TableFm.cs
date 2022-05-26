using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class TableFm : Form
    {
        public TableFm((string SheetName, string[] TableName)[] item)
        {
            InitializeComponent();

            foreach ((string shname, string[] tableName) in item)
                TableList.Groups.Add(shname, shname).Tag = tableName;
        }

        public IEnumerable<(string SheetName, string[] TableName)> GetNames()
            => from ListViewGroup items in TableList.Groups.Cast<ListViewGroup>()
               let result = items.Items.Cast<ListViewItem>()
                                       .Where(item => item.Checked)
                                       .Select(item => item.Text)
                                       .ToArray()
               select (items.Header, result);

        private void CancelButt_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Butt_Click(object sender, System.EventArgs e)
        {
            if (TableList.CheckedItems.Count == 0)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void TableFm_Shown(object sender, System.EventArgs e)
        {
            foreach ((ListViewGroup key, string item) in from ListViewGroup key in TableList.Groups
                                                         from string item in key.Tag as string[]
                                                         select (key, item))
            {
                TableList.Items.Add(item).Group = key;
            }
        }
    }
}