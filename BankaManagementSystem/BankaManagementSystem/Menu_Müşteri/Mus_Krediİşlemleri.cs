using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaManagementSystem.Menu_Müşteri
{
    public partial class Mus_Krediİşlemleri : Form
    {
        public long tc;
        public Mus_Krediİşlemleri()
        {
            InitializeComponent();
        }

        private void Mus_Krediİşlemleri_Load(object sender, EventArgs e)
        {
            lbl_Tc.Text = Convert.ToString(tc);
        }

        private void btn_WindowClose_Click(object sender, EventArgs e)
        {
            Hesap_MüşteriHesabı hesap = new Hesap_MüşteriHesabı();
            hesap.tc = tc;
            hesap.Show();
            this.Hide();
        }

        private void btn_MinWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;
        }

        private void btn_Talep_Click(object sender, EventArgs e)
        {

        }
    }
}
