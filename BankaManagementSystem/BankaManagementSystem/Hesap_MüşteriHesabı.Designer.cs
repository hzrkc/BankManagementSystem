namespace BankaManagementSystem
{
    partial class Hesap_MüşteriHesabı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesap_MüşteriHesabı));
            this.pnl_anaPanel = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_TransferVeÖdeme = new System.Windows.Forms.Button();
            this.pnl_Back = new System.Windows.Forms.Panel();
            this.btn_CloseChildForm = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_childFrom = new System.Windows.Forms.Panel();
            this.pnl_AnaMenu = new System.Windows.Forms.Panel();
            this.btn_Krediİşlemleri = new System.Windows.Forms.Button();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_HesapSil = new System.Windows.Forms.Button();
            this.btn_YeniHesap = new System.Windows.Forms.Button();
            this.Dgv_HesapBilgileri = new System.Windows.Forms.DataGridView();
            this.pnl_Label2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_AylikOzet = new System.Windows.Forms.DataGridView();
            this.pnl_label = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MinWindow = new System.Windows.Forms.Button();
            this.btn_WindowClose = new System.Windows.Forms.Button();
            this.pnl_anaPanel.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Back.SuspendLayout();
            this.pnl_childFrom.SuspendLayout();
            this.pnl_AnaMenu.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HesapBilgileri)).BeginInit();
            this.pnl_Label2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AylikOzet)).BeginInit();
            this.pnl_label.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_anaPanel
            // 
            this.pnl_anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.pnl_anaPanel.Controls.Add(this.pnl_Menu);
            this.pnl_anaPanel.Controls.Add(this.pnl_Back);
            this.pnl_anaPanel.Controls.Add(this.pnl_top);
            this.pnl_anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_anaPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_anaPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_anaPanel.Name = "pnl_anaPanel";
            this.pnl_anaPanel.Size = new System.Drawing.Size(600, 678);
            this.pnl_anaPanel.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_Menu.Controls.Add(this.btn_Ayarlar);
            this.pnl_Menu.Controls.Add(this.btn_TransferVeÖdeme);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 628);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(600, 50);
            this.pnl_Menu.TabIndex = 18;
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ayarlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Ayarlar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_Ayarlar.FlatAppearance.BorderSize = 0;
            this.btn_Ayarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_Ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_Ayarlar.Location = new System.Drawing.Point(300, 0);
            this.btn_Ayarlar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(300, 50);
            this.btn_Ayarlar.TabIndex = 8;
            this.btn_Ayarlar.Text = "Ayarlar";
            this.btn_Ayarlar.UseVisualStyleBackColor = true;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_TransferVeÖdeme
            // 
            this.btn_TransferVeÖdeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TransferVeÖdeme.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TransferVeÖdeme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_TransferVeÖdeme.FlatAppearance.BorderSize = 0;
            this.btn_TransferVeÖdeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_TransferVeÖdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TransferVeÖdeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_TransferVeÖdeme.Location = new System.Drawing.Point(0, 0);
            this.btn_TransferVeÖdeme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TransferVeÖdeme.Name = "btn_TransferVeÖdeme";
            this.btn_TransferVeÖdeme.Size = new System.Drawing.Size(300, 50);
            this.btn_TransferVeÖdeme.TabIndex = 7;
            this.btn_TransferVeÖdeme.Text = "Transfer ve Ödeme işlemleri";
            this.btn_TransferVeÖdeme.UseVisualStyleBackColor = true;
            this.btn_TransferVeÖdeme.Click += new System.EventHandler(this.btn_TransferVeÖdeme_Click);
            // 
            // pnl_Back
            // 
            this.pnl_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_Back.Controls.Add(this.btn_CloseChildForm);
            this.pnl_Back.Controls.Add(this.pnl_childFrom);
            this.pnl_Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Back.Location = new System.Drawing.Point(0, 33);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Size = new System.Drawing.Size(600, 578);
            this.pnl_Back.TabIndex = 1;
            // 
            // btn_CloseChildForm
            // 
            this.btn_CloseChildForm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_CloseChildForm.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_CloseChildForm.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_CloseChildForm.Appearance.Options.UseBackColor = true;
            this.btn_CloseChildForm.Appearance.Options.UseBorderColor = true;
            this.btn_CloseChildForm.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_CloseChildForm.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_CloseChildForm.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_CloseChildForm.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearanceHovered.Options.UseBackColor = true;
            this.btn_CloseChildForm.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_CloseChildForm.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearancePressed.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CloseChildForm.AppearancePressed.Options.UseBackColor = true;
            this.btn_CloseChildForm.AppearancePressed.Options.UseBorderColor = true;
            this.btn_CloseChildForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseChildForm.ImageOptions.Image")));
            this.btn_CloseChildForm.Location = new System.Drawing.Point(565, 0);
            this.btn_CloseChildForm.Name = "btn_CloseChildForm";
            this.btn_CloseChildForm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_CloseChildForm.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_CloseChildForm.Size = new System.Drawing.Size(35, 38);
            this.btn_CloseChildForm.TabIndex = 23;
            this.btn_CloseChildForm.Click += new System.EventHandler(this.btn_CloseChildForm_Click);
            // 
            // pnl_childFrom
            // 
            this.pnl_childFrom.Controls.Add(this.pnl_AnaMenu);
            this.pnl_childFrom.Location = new System.Drawing.Point(3, 5);
            this.pnl_childFrom.Name = "pnl_childFrom";
            this.pnl_childFrom.Size = new System.Drawing.Size(594, 570);
            this.pnl_childFrom.TabIndex = 0;
            // 
            // pnl_AnaMenu
            // 
            this.pnl_AnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_AnaMenu.Controls.Add(this.btn_Krediİşlemleri);
            this.pnl_AnaMenu.Controls.Add(this.pnl_Button);
            this.pnl_AnaMenu.Controls.Add(this.Dgv_HesapBilgileri);
            this.pnl_AnaMenu.Controls.Add(this.pnl_Label2);
            this.pnl_AnaMenu.Controls.Add(this.Dgv_AylikOzet);
            this.pnl_AnaMenu.Controls.Add(this.pnl_label);
            this.pnl_AnaMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaMenu.Name = "pnl_AnaMenu";
            this.pnl_AnaMenu.Size = new System.Drawing.Size(594, 570);
            this.pnl_AnaMenu.TabIndex = 3;
            // 
            // btn_Krediİşlemleri
            // 
            this.btn_Krediİşlemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_Krediİşlemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Krediİşlemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Krediİşlemleri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_Krediİşlemleri.FlatAppearance.BorderSize = 2;
            this.btn_Krediİşlemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_Krediİşlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Krediİşlemleri.Location = new System.Drawing.Point(0, 470);
            this.btn_Krediİşlemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Krediİşlemleri.Name = "btn_Krediİşlemleri";
            this.btn_Krediİşlemleri.Size = new System.Drawing.Size(594, 58);
            this.btn_Krediİşlemleri.TabIndex = 20;
            this.btn_Krediİşlemleri.Text = "Kredi İşlemleri";
            this.btn_Krediİşlemleri.UseVisualStyleBackColor = false;
            this.btn_Krediİşlemleri.Click += new System.EventHandler(this.btn_Krediİşlemleri_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_Button.Controls.Add(this.btn_HesapSil);
            this.pnl_Button.Controls.Add(this.btn_YeniHesap);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Button.Location = new System.Drawing.Point(0, 420);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(594, 50);
            this.pnl_Button.TabIndex = 18;
            // 
            // btn_HesapSil
            // 
            this.btn_HesapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HesapSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_HesapSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_HesapSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_HesapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HesapSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_HesapSil.Location = new System.Drawing.Point(300, 0);
            this.btn_HesapSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HesapSil.Name = "btn_HesapSil";
            this.btn_HesapSil.Size = new System.Drawing.Size(294, 50);
            this.btn_HesapSil.TabIndex = 8;
            this.btn_HesapSil.Text = "Hesap Sil\r\n(Seçili hesabı silme talebi oluşturur)";
            this.btn_HesapSil.UseVisualStyleBackColor = true;
            this.btn_HesapSil.Click += new System.EventHandler(this.btn_HesapSil_Click);
            // 
            // btn_YeniHesap
            // 
            this.btn_YeniHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_YeniHesap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_YeniHesap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_YeniHesap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_YeniHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YeniHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_YeniHesap.Location = new System.Drawing.Point(0, 0);
            this.btn_YeniHesap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_YeniHesap.Name = "btn_YeniHesap";
            this.btn_YeniHesap.Size = new System.Drawing.Size(300, 50);
            this.btn_YeniHesap.TabIndex = 7;
            this.btn_YeniHesap.Text = "Yeni Hesap";
            this.btn_YeniHesap.UseVisualStyleBackColor = true;
            this.btn_YeniHesap.Click += new System.EventHandler(this.btn_YeniHesap_Click);
            // 
            // Dgv_HesapBilgileri
            // 
            this.Dgv_HesapBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_HesapBilgileri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Dgv_HesapBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_HesapBilgileri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Dgv_HesapBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_HesapBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_HesapBilgileri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Dgv_HesapBilgileri.Location = new System.Drawing.Point(0, 262);
            this.Dgv_HesapBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_HesapBilgileri.MultiSelect = false;
            this.Dgv_HesapBilgileri.Name = "Dgv_HesapBilgileri";
            this.Dgv_HesapBilgileri.RowHeadersWidth = 51;
            this.Dgv_HesapBilgileri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_HesapBilgileri.Size = new System.Drawing.Size(594, 158);
            this.Dgv_HesapBilgileri.TabIndex = 16;
            // 
            // pnl_Label2
            // 
            this.pnl_Label2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Label2.Controls.Add(this.label3);
            this.pnl_Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Label2.Location = new System.Drawing.Point(0, 210);
            this.pnl_Label2.Name = "pnl_Label2";
            this.pnl_Label2.Size = new System.Drawing.Size(594, 52);
            this.pnl_Label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(0, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hesap Bilgileri";
            // 
            // Dgv_AylikOzet
            // 
            this.Dgv_AylikOzet.AllowUserToAddRows = false;
            this.Dgv_AylikOzet.AllowUserToDeleteRows = false;
            this.Dgv_AylikOzet.AllowUserToOrderColumns = true;
            this.Dgv_AylikOzet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_AylikOzet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Dgv_AylikOzet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_AylikOzet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Dgv_AylikOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AylikOzet.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_AylikOzet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Dgv_AylikOzet.Location = new System.Drawing.Point(0, 52);
            this.Dgv_AylikOzet.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_AylikOzet.MultiSelect = false;
            this.Dgv_AylikOzet.Name = "Dgv_AylikOzet";
            this.Dgv_AylikOzet.ReadOnly = true;
            this.Dgv_AylikOzet.RowHeadersWidth = 51;
            this.Dgv_AylikOzet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_AylikOzet.Size = new System.Drawing.Size(594, 158);
            this.Dgv_AylikOzet.TabIndex = 14;
            // 
            // pnl_label
            // 
            this.pnl_label.BackColor = System.Drawing.Color.Transparent;
            this.pnl_label.Controls.Add(this.label1);
            this.pnl_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_label.Location = new System.Drawing.Point(0, 0);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(594, 52);
            this.pnl_label.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aylık Özet";
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.btn_MinWindow);
            this.pnl_top.Controls.Add(this.btn_WindowClose);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(600, 33);
            this.pnl_top.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Müsteri Girisi";
            // 
            // btn_MinWindow
            // 
            this.btn_MinWindow.BackColor = System.Drawing.Color.Transparent;
            this.btn_MinWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MinWindow.FlatAppearance.BorderSize = 0;
            this.btn_MinWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btn_MinWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_MinWindow.Location = new System.Drawing.Point(530, 0);
            this.btn_MinWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MinWindow.Name = "btn_MinWindow";
            this.btn_MinWindow.Size = new System.Drawing.Size(35, 33);
            this.btn_MinWindow.TabIndex = 21;
            this.btn_MinWindow.Text = "O";
            this.btn_MinWindow.UseVisualStyleBackColor = false;
            this.btn_MinWindow.Click += new System.EventHandler(this.btn_MinWindow_Click);
            // 
            // btn_WindowClose
            // 
            this.btn_WindowClose.BackColor = System.Drawing.Color.Transparent;
            this.btn_WindowClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_WindowClose.FlatAppearance.BorderSize = 0;
            this.btn_WindowClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btn_WindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WindowClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_WindowClose.Location = new System.Drawing.Point(565, 0);
            this.btn_WindowClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_WindowClose.Name = "btn_WindowClose";
            this.btn_WindowClose.Size = new System.Drawing.Size(35, 33);
            this.btn_WindowClose.TabIndex = 20;
            this.btn_WindowClose.Text = "O";
            this.btn_WindowClose.UseVisualStyleBackColor = false;
            this.btn_WindowClose.Click += new System.EventHandler(this.btn_WindowClose_Click);
            // 
            // Hesap_MüşteriHesabı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 678);
            this.Controls.Add(this.pnl_anaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hesap_MüşteriHesabı";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MüşteriHesabı_Load);
            this.pnl_anaPanel.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Back.ResumeLayout(false);
            this.pnl_childFrom.ResumeLayout(false);
            this.pnl_AnaMenu.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HesapBilgileri)).EndInit();
            this.pnl_Label2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AylikOzet)).EndInit();
            this.pnl_label.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_anaPanel;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_WindowClose;
        private System.Windows.Forms.Button btn_MinWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_TransferVeÖdeme;
        private System.Windows.Forms.Panel pnl_Back;
        private System.Windows.Forms.Panel pnl_childFrom;
        private System.Windows.Forms.Panel pnl_AnaMenu;
        private System.Windows.Forms.Button btn_Krediİşlemleri;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_HesapSil;
        private System.Windows.Forms.Button btn_YeniHesap;
        private System.Windows.Forms.DataGridView Dgv_HesapBilgileri;
        private System.Windows.Forms.Panel pnl_Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_AylikOzet;
        private System.Windows.Forms.Panel pnl_label;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_CloseChildForm;
    }
}

