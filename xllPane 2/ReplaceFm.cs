using System;
using System.Collections.Generic;
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

            var with = resultlist.Items;
            foreach (string key in source)
                with.Add(key);
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

            foreach (string key in source)
                with.Add(key);
        }

        private void ShowButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegBox.Text))
                return;

            pattern = RegBox.Text;
            replacer = ReplacerBox.Text;

            Regex ex = new Regex(pattern);
            IEnumerable<string> result = from string c in source
                                         let k = ex.Replace(c, replacer)
                                         select k;

            var with = resultlist.Items;
            with.Clear();
            foreach (string key in result)
                with.Add(key);
        }

        private void RegBox_TextChanged(object sender, EventArgs e)
        {
            pattern = RegBox.Text;
        }

        private void ReplacerBox_TextChanged(object sender, EventArgs e)
        {
            replacer = ReplacerBox.Text;
        }
    }
}