namespace BankManagementSystem
{
    partial class Login
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.panelLoginMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_LoginCustomer = new System.Windows.Forms.Button();
            this.btn_CusRepresentative = new System.Windows.Forms.Button();
            this.btn_BankManager = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelLoginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panelLogin.Controls.Add(this.panel6);
            this.panelLogin.Controls.Add(this.panel_childForm);
            this.panelLogin.Controls.Add(this.panelLoginMenu);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 450);
            this.panelLogin.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.btn_Minimize);
            this.panel6.Controls.Add(this.btn_Maximize);
            this.panel6.Controls.Add(this.btn_CloseWindow);
            this.panel6.Location = new System.Drawing.Point(705, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(83, 24);
            this.panel6.TabIndex = 4;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_Minimize.Location = new System.Drawing.Point(0, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(27, 24);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "O";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_Maximize.Location = new System.Drawing.Point(27, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(28, 24);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.Text = "O";
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CloseWindow.FlatAppearance.BorderSize = 0;
            this.btn_CloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btn_CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_CloseWindow.Location = new System.Drawing.Point(55, 0);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(28, 24);
            this.btn_CloseWindow.TabIndex = 0;
            this.btn_CloseWindow.Text = "O";
            this.btn_CloseWindow.UseVisualStyleBackColor = true;
            this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // panel_childForm
            // 
            this.panel_childForm.Location = new System.Drawing.Point(281, 40);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(507, 398);
            this.panel_childForm.TabIndex = 1;
            // 
            // panelLoginMenu
            // 
            this.panelLoginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.panelLoginMenu.Controls.Add(this.btn_BankManager);
            this.panelLoginMenu.Controls.Add(this.btn_CusRepresentative);
            this.panelLoginMenu.Controls.Add(this.btn_LoginCustomer);
            this.panelLoginMenu.Controls.Add(this.panel4);
            this.panelLoginMenu.Controls.Add(this.panel3);
            this.panelLoginMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLoginMenu.Name = "panelLoginMenu";
            this.panelLoginMenu.Size = new System.Drawing.Size(263, 450);
            this.panelLoginMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 99);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 105);
            this.panel3.TabIndex = 0;
            // 
            // btn_LoginCustomer
            // 
            this.btn_LoginCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_LoginCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoginCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LoginCustomer.FlatAppearance.BorderSize = 0;
            this.btn_LoginCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_LoginCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_LoginCustomer.Location = new System.Drawing.Point(0, 105);
            this.btn_LoginCustomer.Name = "btn_LoginCustomer";
            this.btn_LoginCustomer.Size = new System.Drawing.Size(263, 77);
            this.btn_LoginCustomer.TabIndex = 2;
            this.btn_LoginCustomer.Text = "Müşteri";
            this.btn_LoginCustomer.UseVisualStyleBackColor = false;
            this.btn_LoginCustomer.Click += new System.EventHandler(this.btn_LoginCustomer_Click);
            // 
            // btn_CusRepresentative
            // 
            this.btn_CusRepresentative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_CusRepresentative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CusRepresentative.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CusRepresentative.FlatAppearance.BorderSize = 0;
            this.btn_CusRepresentative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_CusRepresentative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CusRepresentative.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CusRepresentative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_CusRepresentative.Location = new System.Drawing.Point(0, 182);
            this.btn_CusRepresentative.Name = "btn_CusRepresentative";
            this.btn_CusRepresentative.Size = new System.Drawing.Size(263, 82);
            this.btn_CusRepresentative.TabIndex = 3;
            this.btn_CusRepresentative.Text = "Müşteri Temsilcisi";
            this.btn_CusRepresentative.UseVisualStyleBackColor = false;
            this.btn_CusRepresentative.Click += new System.EventHandler(this.btn_CusRepresentative_Click);
            // 
            // btn_BankManager
            // 
            this.btn_BankManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_BankManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BankManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BankManager.FlatAppearance.BorderSize = 0;
            this.btn_BankManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btn_BankManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BankManager.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BankManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_BankManager.Location = new System.Drawing.Point(0, 264);
            this.btn_BankManager.Name = "btn_BankManager";
            this.btn_BankManager.Size = new System.Drawing.Size(263, 81);
            this.btn_BankManager.TabIndex = 4;
            this.btn_BankManager.Text = "Banka Müdürü";
            this.btn_BankManager.UseVisualStyleBackColor = false;
            this.btn_BankManager.Click += new System.EventHandler(this.btn_BankManager_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelLoginMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelLoginMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.Button btn_LoginCustomer;
        private System.Windows.Forms.Button btn_BankManager;
        private System.Windows.Forms.Button btn_CusRepresentative;
    }
}