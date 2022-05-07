using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{

    public partial class Account_BankManager : Form
    {   //Fields
        private Button currentButton;
        private Form activeForm;
        public Account_BankManager()
        {
            InitializeComponent();
            btn_AnaSayfa.Visible = false;
        }
        //Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color backColor = ColorTranslator.FromHtml("#e8d7ff");
                    Color foreColor = ColorTranslator.FromHtml("#BD9DE5");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = backColor;
                    currentButton.ForeColor = foreColor;
                    BackColorpanel.BackColor = backColor;
                    btn_AnaSayfa.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(210, 175, 255);
                    previousBtn.ForeColor = Color.FromArgb(63, 52, 76);
                    BackColorpanel.BackColor = Color.FromArgb(210, 175, 255);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_childform.Controls.Add(childForm);
            this.panel_childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_BankYönetimi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Account_BankManagerForms.BankaYönetimi(), sender);
        }

        private void btn_Bankaİşlemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Account_BankManagerForms.Bankaİşlemleri(), sender);
        }

        private void btn_Müşteriİşlemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Account_BankManagerForms.Müşteriİşlemleri(), sender);
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            if(activeForm !=null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btn_AnaSayfa.Visible = false;
        }

        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;
        }
    }
}
