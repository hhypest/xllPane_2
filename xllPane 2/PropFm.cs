using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace xllPane_2
{
    public partial class PropFm : Form
    {
        private readonly string[] value;
        private int state;

        public PropFm(string[] value)
        {
            InitializeComponent();
            this.value = value;
            state = -1;

            resultlist.Items.AddRange(this.value
                                      .Select(item => new ListViewItem(item))
                                      .ToArray());
        }

        public byte GetState()
            => state.To<int, byte>();

        private void Cancel_button_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Ok_button_Click(object sender, System.EventArgs e)
        {
            if (state == -1)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Upcaseb_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!upcaseb.Checked)
                return;

            state = 0;
            var with = resultlist.Items;
            with.Clear();
            with.AddRange(value
                          .Select(key => key.ToUpperInvariant())
                          .Select(item => new ListViewItem(item))
                          .ToArray());
        }

        private void Lowcaseb_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!lowcaseb.Checked)
                return;

            state = 1;
            var with = resultlist.Items;
            with.Clear();
            with.AddRange(value
                          .Select(key => key.ToLowerInvariant())
                          .Select(item => new ListViewItem(item))
                          .ToArray());
        }

        private void Propcaseb_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!propcaseb.Checked)
                return;

            state = 2;
            var with = resultlist.Items;
            with.Clear();
            with.AddRange(value
                          .Select(key => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(key.ToLowerInvariant()))
                          .Select(item => new ListViewItem(item))
                          .ToArray());
        }
    }
}