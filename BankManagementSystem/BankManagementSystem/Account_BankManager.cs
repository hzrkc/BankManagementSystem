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
    }
}
