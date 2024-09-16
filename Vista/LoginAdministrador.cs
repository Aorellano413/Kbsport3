using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginAdministador : Form
    {
        public LoginAdministador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonExitAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegresarAdmin_Click(object sender, EventArgs e)
        {
            LoginGeneral loginGeneralForm = new LoginGeneral();
            loginGeneralForm.Show();
            this.Close();
        }
    }
}
