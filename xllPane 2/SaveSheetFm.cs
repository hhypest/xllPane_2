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

            sheetlist.Items.AddRange(source
                                     .Select(item => new ListViewItem(item))
                                     .ToArray());
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