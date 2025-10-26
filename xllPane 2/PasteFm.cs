using System;
using System.Linq;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class PasteFm : Form
    {
        private readonly string[] source;
        private int state;

        public PasteFm(string[] source)
        {
            InitializeComponent();
            this.source = source;
            state = -1;

            resultlist.Items.AddRange(source
                                      .Select(item => new ListViewItem(item))
                                      .ToArray());
        }

        public byte GetState()
            => state.To<int, byte>();

        public string GetPaste()
            => PasteBox.Text;

        private void Cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Ok_Butt_Click(object sender, EventArgs e)
        {
            if (state == -1 || string.IsNullOrEmpty(PasteBox.Text))
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void PredRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!PredRadio.Checked || string.IsNullOrEmpty(PasteBox.Text))
                return;

            state = 0;

            var with = resultlist.Items;
            with.Clear();
            foreach (string key in source)
                with.Add($"{PasteBox.Text}{key}");
        }

        private void OutRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!OutRadio.Checked || string.IsNullOrEmpty(PasteBox.Text))
                return;

            state = 1;

            var with = resultlist.Items;
            with.Clear();
            foreach (string key in source)
                with.Add($"{key}{PasteBox.Text}");
        }

        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!AllRadio.Checked || string.IsNullOrEmpty(PasteBox.Text))
                return;

            state = 2;

            var with = resultlist.Items;
            with.Clear();
            foreach (string key in source)
                with.Add($"{PasteBox.Text}{key}{PasteBox.Text}");
        }
    }
}