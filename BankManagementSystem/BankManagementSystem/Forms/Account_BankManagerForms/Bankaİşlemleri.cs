﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Forms.Account_BankManagerForms
{
    public partial class Bankaİşlemleri : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        public Bankaİşlemleri()
        {
            InitializeComponent();
            btn_Close.Visible = false;
        }
        //Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color backColor = ColorTranslator.FromHtml("#f6efff");
                    Color foreColor = ColorTranslator.FromHtml("#BD9DE5");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = backColor;
                    currentButton.ForeColor = foreColor;
                    backColorPanel.BackColor = backColor;
                    btn_Close.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in bankİşlemler_panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(232, 215, 255);
                    previousBtn.ForeColor = Color.FromArgb(63, 52, 76);
                    backColorPanel.BackColor = Color.FromArgb(232, 215, 255);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btn_Close.Visible = false;
        }

        private void btn_Tümİşlemler_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_GenelDurum_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }

}
