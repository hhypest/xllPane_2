using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class ReplaceFm : Form
    {
        private readonly string[] source;
        private string replacer;
        private string pattern;

        public ReplaceFm(string[] source)
        {
            InitializeComponent();
            this.source = source;
            ReplacerBox.Text = string.Empty;

            resultlist.Items.AddRange(source
                                      .Select(item => new ListViewItem(item))
                                      .ToArray());
        }

        public (string pattern, string replacement) GetState()
            => (pattern, replacer);

        private void Cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Butt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegBox.Text))
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

        private void ShowButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegBox.Text))
                return;

            pattern = RegBox.Text;
            replacer = ReplacerBox.Text;

            Regex ex = new Regex(pattern);

            var with = resultlist.Items;
            with.Clear();
            with.AddRange((from string key in source
                           let item = ex.Replace(key, replacer)
                           select new ListViewItem(item))
                           .ToArray());
        }

        private void RegBox_TextChanged(object sender, EventArgs e)
            => pattern = RegBox.Text;

        private void ReplacerBox_TextChanged(object sender, EventArgs e)
            => replacer = ReplacerBox.Text;
    }
}