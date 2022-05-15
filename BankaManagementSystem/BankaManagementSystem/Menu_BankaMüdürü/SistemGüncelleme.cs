using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaManagementSystem.Menu_BankaMüdürü
{
    public partial class SistemGüncelleme : Form
    {
        public long tc;
        public SistemGüncelleme()
        {
            InitializeComponent();
        }

        private void SistemGüncelleme_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
