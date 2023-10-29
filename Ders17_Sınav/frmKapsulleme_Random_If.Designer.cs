namespace Ders17_Sınav
{
    partial class frmKapsulleme_Random_If
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Dort_islem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_number1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_number2 = new System.Windows.Forms.Label();
            this.btn_Sonuc_Bul = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapsulleme Random If";
            // 
            // cmb_Dort_islem
            // 
            this.cmb_Dort_islem.FormattingEnabled = true;
            this.cmb_Dort_islem.Location = new System.Drawing.Point(308, 125);
            this.cmb_Dort_islem.Name = "cmb_Dort_islem";
            this.cmb_Dort_islem.Size = new System.Drawing.Size(192, 21);
            this.cmb_Dort_islem.TabIndex = 1;
            this.cmb_Dort_islem.SelectedIndexChanged += new System.EventHandler(this.cmb_Dort_islem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = " İŞLEM SEÇİNİZ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "1.Sayi :";
            // 
            // lbl_number1
            // 
            this.lbl_number1.AutoSize = true;
            this.lbl_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_number1.Location = new System.Drawing.Point(363, 182);
            this.lbl_number1.Name = "lbl_number1";
            this.lbl_number1.Size = new System.Drawing.Size(36, 39);
            this.lbl_number1.TabIndex = 4;
            this.lbl_number1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(166, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "2.Sayi :";
            // 
            // lbl_number2
            // 
            this.lbl_number2.AutoSize = true;
            this.lbl_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_number2.Location = new System.Drawing.Point(363, 243);
            this.lbl_number2.Name = "lbl_number2";
            this.lbl_number2.Size = new System.Drawing.Size(36, 39);
            this.lbl_number2.TabIndex = 6;
            this.lbl_number2.Text = "0";
            // 
            // btn_Sonuc_Bul
            // 
            this.btn_Sonuc_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sonuc_Bul.Location = new System.Drawing.Point(21, 348);
            this.btn_Sonuc_Bul.Name = "btn_Sonuc_Bul";
            this.btn_Sonuc_Bul.Size = new System.Drawing.Size(212, 68);
            this.btn_Sonuc_Bul.TabIndex = 7;
            this.btn_Sonuc_Bul.Text = "SONUC BUL";
            this.btn_Sonuc_Bul.UseVisualStyleBackColor = true;
            this.btn_Sonuc_Bul.Click += new System.EventHandler(this.btn_Sonuc_Bul_Click);
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sonuc.Location = new System.Drawing.Point(363, 362);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(36, 39);
            this.lbl_Sonuc.TabIndex = 8;
            this.lbl_Sonuc.Text = "0";
            // 
            // frmKapsulleme_Random_If
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.btn_Sonuc_Bul);
            this.Controls.Add(this.lbl_number2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_number1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Dort_islem);
            this.Controls.Add(this.label1);
            this.Name = "frmKapsulleme_Random_If";
            this.Text = "frmKapsulleme_Random_If";
            this.Load += new System.EventHandler(this.frmKapsulleme_Random_If_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Dort_islem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_number1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_number2;
        private System.Windows.Forms.Button btn_Sonuc_Bul;
        private System.Windows.Forms.Label lbl_Sonuc;
    }
}