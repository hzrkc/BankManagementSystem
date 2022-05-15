namespace BankaManagementSystem.Menu_Müşteri_Temsilcisi
{
    partial class MT_Krediİşlemleri
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
            this.Dgv_KrediTalep = new System.Windows.Forms.DataGridView();
            this.pnl_label = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_AnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_KrediTalep)).BeginInit();
            this.pnl_label.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AnaPanel
            // 
            this.pnl_AnaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_AnaPanel.Controls.Add(this.Dgv_KrediTalep);
            this.pnl_AnaPanel.Controls.Add(this.pnl_label);
            this.pnl_AnaPanel.Controls.Add(this.groupBox1);
            this.pnl_AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AnaPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaPanel.Name = "pnl_AnaPanel";
            this.pnl_AnaPanel.Size = new System.Drawing.Size(417, 724);
            this.pnl_AnaPanel.TabIndex = 0;
            // 
            // Dgv_KrediTalep
            // 
            this.Dgv_KrediTalep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_KrediTalep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Dgv_KrediTalep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_KrediTalep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Dgv_KrediTalep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_KrediTalep.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dgv_KrediTalep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Dgv_KrediTalep.Location = new System.Drawing.Point(0, 125);
            this.Dgv_KrediTalep.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_KrediTalep.MultiSelect = false;
            this.Dgv_KrediTalep.Name = "Dgv_KrediTalep";
            this.Dgv_KrediTalep.RowHeadersWidth = 51;
            this.Dgv_KrediTalep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_KrediTalep.Size = new System.Drawing.Size(417, 181);
            this.Dgv_KrediTalep.TabIndex = 26;
            // 
            // pnl_label
            // 
            this.pnl_label.BackColor = System.Drawing.Color.Transparent;
            this.pnl_label.Controls.Add(this.label1);
            this.pnl_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_label.Location = new System.Drawing.Point(0, 0);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(417, 125);
            this.pnl_label.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlgili Müşterinin Kredi Talepleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn_Onay);
            this.groupBox1.Controls.Add(this.txtBox_id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Talebi Onaylama";
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
            this.btn_Onay.Location = new System.Drawing.Point(3, 109);
            this.btn_Onay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(385, 54);
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
            this.txtBox_id.Location = new System.Drawing.Point(130, 60);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(210, 27);
            this.txtBox_id.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(16, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Talep Id  :";
            // 
            // MT_Krediİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 724);
            this.Controls.Add(this.pnl_AnaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MT_Krediİşlemleri";
            this.Text = "MT_Krediİşlemleri";
            this.Load += new System.EventHandler(this.MT_Krediİşlemleri_Load);
            this.pnl_AnaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_KrediTalep)).EndInit();
            this.pnl_label.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AnaPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dgv_KrediTalep;
        private System.Windows.Forms.Panel pnl_label;
        private System.Windows.Forms.Label label1;
    }
}