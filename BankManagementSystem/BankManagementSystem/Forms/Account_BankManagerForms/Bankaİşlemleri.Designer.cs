namespace BankManagementSystem.Forms.Account_BankManagerForms
{
    partial class Bankaİşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bankaİşlemleri));
            this.bankİşlemler_panelMenu = new System.Windows.Forms.Panel();
            this.btn_Tümİşlemler = new System.Windows.Forms.Button();
            this.btn_GenelDurum = new System.Windows.Forms.Button();
            this.backColorPanel = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.bankİşlemler_panelMenu.SuspendLayout();
            this.backColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankİşlemler_panelMenu
            // 
            this.bankİşlemler_panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bankİşlemler_panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.bankİşlemler_panelMenu.Controls.Add(this.btn_GenelDurum);
            this.bankİşlemler_panelMenu.Controls.Add(this.btn_Tümİşlemler);
            this.bankİşlemler_panelMenu.Location = new System.Drawing.Point(0, 339);
            this.bankİşlemler_panelMenu.Name = "bankİşlemler_panelMenu";
            this.bankİşlemler_panelMenu.Size = new System.Drawing.Size(936, 73);
            this.bankİşlemler_panelMenu.TabIndex = 4;
            // 
            // btn_Tümİşlemler
            // 
            this.btn_Tümİşlemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Tümİşlemler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_Tümİşlemler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_Tümİşlemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tümİşlemler.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tümİşlemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_Tümİşlemler.Location = new System.Drawing.Point(0, 0);
            this.btn_Tümİşlemler.Name = "btn_Tümİşlemler";
            this.btn_Tümİşlemler.Size = new System.Drawing.Size(468, 73);
            this.btn_Tümİşlemler.TabIndex = 5;
            this.btn_Tümİşlemler.Text = "Tüm İşlemler";
            this.btn_Tümİşlemler.UseVisualStyleBackColor = true;
            this.btn_Tümİşlemler.Click += new System.EventHandler(this.btn_Tümİşlemler_Click);
            // 
            // btn_GenelDurum
            // 
            this.btn_GenelDurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GenelDurum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_GenelDurum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_GenelDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenelDurum.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenelDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_GenelDurum.Location = new System.Drawing.Point(468, 0);
            this.btn_GenelDurum.Name = "btn_GenelDurum";
            this.btn_GenelDurum.Size = new System.Drawing.Size(456, 73);
            this.btn_GenelDurum.TabIndex = 6;
            this.btn_GenelDurum.Text = "Genel Durum";
            this.btn_GenelDurum.UseVisualStyleBackColor = true;
            this.btn_GenelDurum.Click += new System.EventHandler(this.btn_GenelDurum_Click);
            // 
            // backColorPanel
            // 
            this.backColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.backColorPanel.Controls.Add(this.btn_Close);
            this.backColorPanel.Controls.Add(this.childFormPanel);
            this.backColorPanel.Location = new System.Drawing.Point(0, -3);
            this.backColorPanel.Name = "backColorPanel";
            this.backColorPanel.Size = new System.Drawing.Size(936, 345);
            this.backColorPanel.TabIndex = 5;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.childFormPanel.Location = new System.Drawing.Point(12, 15);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(912, 321);
            this.childFormPanel.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageOptions.Image")));
            this.btn_Close.Location = new System.Drawing.Point(0, 4);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Close.Size = new System.Drawing.Size(40, 33);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // Bankaİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(936, 411);
            this.Controls.Add(this.backColorPanel);
            this.Controls.Add(this.bankİşlemler_panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bankaİşlemleri";
            this.Text = "Bankaİşlemleri";
            this.bankİşlemler_panelMenu.ResumeLayout(false);
            this.backColorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bankİşlemler_panelMenu;
        private System.Windows.Forms.Button btn_Tümİşlemler;
        private System.Windows.Forms.Button btn_GenelDurum;
        private System.Windows.Forms.Panel backColorPanel;
        private System.Windows.Forms.Panel childFormPanel;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
    }
}