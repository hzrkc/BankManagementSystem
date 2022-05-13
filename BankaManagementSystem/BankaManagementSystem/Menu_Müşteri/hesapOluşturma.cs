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
    public partial class hesapOluşturma : Form
    {
        public int tc;
        public hesapOluşturma()
        {
            InitializeComponent();
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

        private void btn_TalepOluştur_Click(object sender, EventArgs e)
        {
            
        }

        private void hesapOluşturma_Load(object sender, EventArgs e)
        {
            lbl_Tc.Text =Convert.ToString(tc);
        }
    }
}
