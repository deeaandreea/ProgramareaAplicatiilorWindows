using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoUserControl
{
    public partial class InfoUserControl: UserControl
    {
        string info = "Mesaj informare";

        public InfoUserControl()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(info, "Informatii generale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string Info
        {
            set
            {
                if (value != null)
                    info = value;
            }
        }
    }
}
