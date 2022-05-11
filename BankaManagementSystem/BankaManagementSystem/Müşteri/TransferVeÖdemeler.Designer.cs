namespace BankaManagementSystem.Müşteri
{
    partial class TransferVeÖdemeler
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
            this.pnl_childFrom = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_childFrom.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_childFrom
            // 
            this.pnl_childFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl_childFrom.Controls.Add(this.pnl_top);
            this.pnl_childFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_childFrom.Location = new System.Drawing.Point(0, 0);
            this.pnl_childFrom.Name = "pnl_childFrom";
            this.pnl_childFrom.Size = new System.Drawing.Size(600, 578);
            this.pnl_childFrom.TabIndex = 2;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Transparent;
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(600, 52);
            this.pnl_top.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transfer ve Ödeme İşlemleri";
            // 
            // TransferVeÖdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 578);
            this.Controls.Add(this.pnl_childFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferVeÖdemeler";
            this.Text = "TransferVeÖdemeler";
            this.pnl_childFrom.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_childFrom;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
    }
}