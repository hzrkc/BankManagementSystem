namespace BankaManagementSystem.Menu_Müşteri_Temsilcisi
{
    partial class HesapOluşturma
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
            this.pnl_AnaPanel = new System.Windows.Forms.Panel();
            this.Dgv_HesapTalep = new System.Windows.Forms.DataGridView();
            this.pnl_label = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmBox_HesapTür = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmBox_YatırımFonuTürü = new System.Windows.Forms.ComboBox();
            this.TxtBox_Hesapİsmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HesapOluştur = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_AnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HesapTalep)).BeginInit();
            this.pnl_label.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AnaPanel
            // 
            this.pnl_AnaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_AnaPanel.Controls.Add(this.Dgv_HesapTalep);
            this.pnl_AnaPanel.Controls.Add(this.pnl_label);
            this.pnl_AnaPanel.Controls.Add(this.groupBox2);
            this.pnl_AnaPanel.Controls.Add(this.groupBox1);
            this.pnl_AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AnaPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaPanel.Name = "pnl_AnaPanel";
            this.pnl_AnaPanel.Size = new System.Drawing.Size(417, 724);
            this.pnl_AnaPanel.TabIndex = 1;
            // 
            // Dgv_HesapTalep
            // 
            this.Dgv_HesapTalep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_HesapTalep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Dgv_HesapTalep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_HesapTalep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Dgv_HesapTalep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_HesapTalep.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_HesapTalep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Dgv_HesapTalep.Location = new System.Drawing.Point(0, 46);
            this.Dgv_HesapTalep.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_HesapTalep.MultiSelect = false;
            this.Dgv_HesapTalep.Name = "Dgv_HesapTalep";
            this.Dgv_HesapTalep.RowHeadersWidth = 51;
            this.Dgv_HesapTalep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_HesapTalep.Size = new System.Drawing.Size(417, 207);
            this.Dgv_HesapTalep.TabIndex = 29;
            // 
            // pnl_label
            // 
            this.pnl_label.BackColor = System.Drawing.Color.Transparent;
            this.pnl_label.Controls.Add(this.label3);
            this.pnl_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_label.Location = new System.Drawing.Point(0, 0);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(417, 46);
            this.pnl_label.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlgili Müşterinin Hesap Talepleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_Onay);
            this.groupBox2.Controls.Add(this.txtBox_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 120);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Talebi Onaylama";
            // 
            // btn_Onay
            // 
            this.btn_Onay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_Onay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Onay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Onay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_Onay.FlatAppearance.BorderSize = 2;
            this.btn_Onay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_Onay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Onay.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Onay.Location = new System.Drawing.Point(3, 76);
            this.btn_Onay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(364, 41);
            this.btn_Onay.TabIndex = 21;
            this.btn_Onay.Text = "Talep Onayla";
            this.btn_Onay.UseVisualStyleBackColor = false;
            this.btn_Onay.Click += new System.EventHandler(this.btn_Onay_Click);
            // 
            // txtBox_id
            // 
            this.txtBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.txtBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_id.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_id.Location = new System.Drawing.Point(106, 29);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(194, 27);
            this.txtBox_id.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Talep Id  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.CmBox_HesapTür);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmBox_YatırımFonuTürü);
            this.groupBox1.Controls.Add(this.TxtBox_Hesapİsmi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_HesapOluştur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 283);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Oluşturma";
            // 
            // CmBox_HesapTür
            // 
            this.CmBox_HesapTür.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.CmBox_HesapTür.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmBox_HesapTür.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBox_HesapTür.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.CmBox_HesapTür.FormattingEnabled = true;
            this.CmBox_HesapTür.Location = new System.Drawing.Point(90, 71);
            this.CmBox_HesapTür.Name = "CmBox_HesapTür";
            this.CmBox_HesapTür.Size = new System.Drawing.Size(210, 30);
            this.CmBox_HesapTür.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(85, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hesap Türü Seçiniz : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CmBox_YatırımFonuTürü
            // 
            this.CmBox_YatırımFonuTürü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.CmBox_YatırımFonuTürü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmBox_YatırımFonuTürü.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBox_YatırımFonuTürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.CmBox_YatırımFonuTürü.FormattingEnabled = true;
            this.CmBox_YatırımFonuTürü.Location = new System.Drawing.Point(90, 128);
            this.CmBox_YatırımFonuTürü.Name = "CmBox_YatırımFonuTürü";
            this.CmBox_YatırımFonuTürü.Size = new System.Drawing.Size(210, 30);
            this.CmBox_YatırımFonuTürü.TabIndex = 24;
            // 
            // TxtBox_Hesapİsmi
            // 
            this.TxtBox_Hesapİsmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TxtBox_Hesapİsmi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Hesapİsmi.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Hesapİsmi.Location = new System.Drawing.Point(90, 195);
            this.TxtBox_Hesapİsmi.Name = "TxtBox_Hesapİsmi";
            this.TxtBox_Hesapİsmi.Size = new System.Drawing.Size(210, 23);
            this.TxtBox_Hesapİsmi.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(85, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hesap İsmi Giriniz : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_HesapOluştur
            // 
            this.btn_HesapOluştur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_HesapOluştur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HesapOluştur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_HesapOluştur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_HesapOluştur.FlatAppearance.BorderSize = 2;
            this.btn_HesapOluştur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btn_HesapOluştur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HesapOluştur.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HesapOluştur.Location = new System.Drawing.Point(3, 237);
            this.btn_HesapOluştur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HesapOluştur.Name = "btn_HesapOluştur";
            this.btn_HesapOluştur.Size = new System.Drawing.Size(367, 43);
            this.btn_HesapOluştur.TabIndex = 21;
            this.btn_HesapOluştur.Text = "Hesap Oluştur";
            this.btn_HesapOluştur.UseVisualStyleBackColor = false;
            this.btn_HesapOluştur.Click += new System.EventHandler(this.btn_HesapOluştur_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(85, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yatırım Fonu Seçiniz : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HesapOluşturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 724);
            this.Controls.Add(this.pnl_AnaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HesapOluşturma";
            this.Text = "HesapOluşturma";
            this.Load += new System.EventHandler(this.HesapOluşturma_Load);
            this.pnl_AnaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HesapTalep)).EndInit();
            this.pnl_label.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AnaPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBox_Hesapİsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HesapOluştur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmBox_YatırımFonuTürü;
        private System.Windows.Forms.ComboBox CmBox_HesapTür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_HesapTalep;
        private System.Windows.Forms.Panel pnl_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Label label4;
    }
}