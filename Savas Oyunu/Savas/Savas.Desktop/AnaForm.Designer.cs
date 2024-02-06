namespace Savas.Desktop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.ucaksavarPanel = new System.Windows.Forms.Panel();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(723, 80);
            this.bilgiPanel.TabIndex = 0;
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.Font = new System.Drawing.Font("Seven Segment", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.White;
            this.sureLabel.Location = new System.Drawing.Point(514, 19);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(197, 50);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "00:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.White;
            this.bilgiLabel.Location = new System.Drawing.Point(12, 9);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(447, 60);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\n";
            // 
            // ucaksavarPanel
            // 
            this.ucaksavarPanel.BackColor = System.Drawing.Color.Teal;
            this.ucaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavarPanel.Location = new System.Drawing.Point(0, 309);
            this.ucaksavarPanel.Name = "ucaksavarPanel";
            this.ucaksavarPanel.Size = new System.Drawing.Size(723, 50);
            this.ucaksavarPanel.TabIndex = 1;
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 80);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(723, 229);
            this.savasAlaniPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 359);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.ucaksavarPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Savas Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel ucaksavarPanel;
        private System.Windows.Forms.Panel savasAlaniPanel;
    }
}

