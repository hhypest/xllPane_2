using System;
using System.Linq;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class SplitFm : Form
    {
        private readonly string[] source;
        private string separator;

        public SplitFm(string[] source)
        {
            InitializeComponent();
            this.source = source;

            resultlist.Items.AddRange(source
                                      .Select(item => new ListViewItem(item))
                                      .ToArray());
        }

        public (char[] separator, int count) GetState()
            => (separator.ToArray(), NumberSplit.Value.To<decimal, int>());

        private void Cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Ok_Butt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(separator) || NumberSplit.Value < 0)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            var with = resultlist.Items;
            with.Clear();
            with.AddRange(source
                          .Select(item => new ListViewItem(item))
                          .ToArray());
        }

        private void SeparatorBox_TextChanged(object sender, EventArgs e)
            => separator = SeparatorBox.Text;

        private void ShowButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(separator))
                return;

            string cast(string value) => value.Split(separator.ToArray())
                                              .Length > NumberSplit.Value
                                              .To<decimal, int>() ?
                                              value.Split(separator.ToArray())[NumberSplit.Value.To<decimal, int>()] :
                                              value;

            var with = resultlist.Items;
            with.Clear();

            foreach (string key in source)
                with.Add(cast(key));
        }
    }
}