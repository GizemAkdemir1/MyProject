namespace PiggyBankl
{
    partial class KumbaraFrm
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
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.lblKagitPara = new System.Windows.Forms.Label();
            this.lblBozukPara = new System.Windows.Forms.Label();
            this.btnKatla = new System.Windows.Forms.Button();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.lbKumbara = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKumbaraHacmi = new System.Windows.Forms.Label();
            this.lblParaHacmi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(263, 95);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(134, 28);
            this.cmbKagitPara.TabIndex = 0;
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(263, 145);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(134, 28);
            this.cmbBozukPara.TabIndex = 1;
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // lblKagitPara
            // 
            this.lblKagitPara.AutoSize = true;
            this.lblKagitPara.Location = new System.Drawing.Point(149, 98);
            this.lblKagitPara.Name = "lblKagitPara";
            this.lblKagitPara.Size = new System.Drawing.Size(82, 20);
            this.lblKagitPara.TabIndex = 2;
            this.lblKagitPara.Text = "Kağıt Para";
            // 
            // lblBozukPara
            // 
            this.lblBozukPara.AutoSize = true;
            this.lblBozukPara.Location = new System.Drawing.Point(149, 145);
            this.lblBozukPara.Name = "lblBozukPara";
            this.lblBozukPara.Size = new System.Drawing.Size(91, 20);
            this.lblBozukPara.TabIndex = 3;
            this.lblBozukPara.Text = "Bozuk Para";
            // 
            // btnKatla
            // 
            this.btnKatla.Location = new System.Drawing.Point(87, 207);
            this.btnKatla.Name = "btnKatla";
            this.btnKatla.Size = new System.Drawing.Size(77, 53);
            this.btnKatla.TabIndex = 4;
            this.btnKatla.Text = "Katla";
            this.btnKatla.UseVisualStyleBackColor = true;
            this.btnKatla.Click += new System.EventHandler(this.btnKatla_Click);
            // 
            // btnParaAt
            // 
            this.btnParaAt.Location = new System.Drawing.Point(183, 207);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(77, 53);
            this.btnParaAt.TabIndex = 5;
            this.btnParaAt.Text = "Para At";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(281, 207);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(77, 53);
            this.btnSalla.TabIndex = 6;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKir
            // 
            this.btnKir.Location = new System.Drawing.Point(374, 207);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(77, 53);
            this.btnKir.TabIndex = 7;
            this.btnKir.Text = "Kır";
            this.btnKir.UseVisualStyleBackColor = true;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // lbKumbara
            // 
            this.lbKumbara.FormattingEnabled = true;
            this.lbKumbara.ItemHeight = 20;
            this.lbKumbara.Location = new System.Drawing.Point(85, 301);
            this.lbKumbara.Name = "lbKumbara";
            this.lbKumbara.Size = new System.Drawing.Size(366, 184);
            this.lbKumbara.TabIndex = 8;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(86, 513);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(135, 20);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Kumbara Hacmi =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Paranın Fazla Hacmi  =";
            // 
            // lblKumbaraHacmi
            // 
            this.lblKumbaraHacmi.AutoSize = true;
            this.lblKumbaraHacmi.Location = new System.Drawing.Point(223, 513);
            this.lblKumbaraHacmi.Name = "lblKumbaraHacmi";
            this.lblKumbaraHacmi.Size = new System.Drawing.Size(18, 20);
            this.lblKumbaraHacmi.TabIndex = 12;
            this.lblKumbaraHacmi.Text = "0";
            // 
            // lblParaHacmi
            // 
            this.lblParaHacmi.AutoSize = true;
            this.lblParaHacmi.Location = new System.Drawing.Point(259, 544);
            this.lblParaHacmi.Name = "lblParaHacmi";
            this.lblParaHacmi.Size = new System.Drawing.Size(18, 20);
            this.lblParaHacmi.TabIndex = 13;
            this.lblParaHacmi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kumbara Para Tutarı =";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(259, 580);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(18, 20);
            this.lblToplam.TabIndex = 15;
            this.lblToplam.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 52);
            this.label2.TabIndex = 16;
            this.label2.Text = "Piggy Bank";
            // 
            // KumbaraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(539, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParaHacmi);
            this.Controls.Add(this.lblKumbaraHacmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbKumbara);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.btnKatla);
            this.Controls.Add(this.lblBozukPara);
            this.Controls.Add(this.lblKagitPara);
            this.Controls.Add(this.cmbBozukPara);
            this.Controls.Add(this.cmbKagitPara);
            this.Name = "KumbaraFrm";
            this.Text = "Kumbara";
            this.Load += new System.EventHandler(this.KumbaraFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.Label lblKagitPara;
        private System.Windows.Forms.Label lblBozukPara;
        private System.Windows.Forms.Button btnKatla;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.ListBox lbKumbara;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKumbaraHacmi;
        private System.Windows.Forms.Label lblParaHacmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label2;
    }
}

