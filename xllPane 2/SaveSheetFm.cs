using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class SaveSheetFm : Form
    {
        public SaveSheetFm(string[] source)
        {
            InitializeComponent();

            var with = sheetlist.Items;
            foreach (string key in source)
                with.Add(key);
        }

        public string[] GetNames()
            => sheetlist.Items.Cast<ListViewItem>()
                              .Where(item => item.Checked)
                              .Select(item => item.Text)
                              .ToArray();

        private void Cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Butt_Click(object sender, EventArgs e)
        {
            if (sheetlist.CheckedItems.Count < 1)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}