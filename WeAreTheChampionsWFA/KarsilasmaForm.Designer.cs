
namespace WeAreTheChampionsWFA
{
    partial class KarsilasmaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTakim1 = new System.Windows.Forms.ComboBox();
            this.cboTakim2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpMacTime = new System.Windows.Forms.DateTimePicker();
            this.mtbSkor1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbSkor2 = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takım 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.Takım Skor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "2.Takım Skor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maç Tarihi ";
            // 
            // cboTakim1
            // 
            this.cboTakim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakim1.FormattingEnabled = true;
            this.cboTakim1.Location = new System.Drawing.Point(61, 138);
            this.cboTakim1.Name = "cboTakim1";
            this.cboTakim1.Size = new System.Drawing.Size(140, 24);
            this.cboTakim1.TabIndex = 5;
            // 
            // cboTakim2
            // 
            this.cboTakim2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakim2.FormattingEnabled = true;
            this.cboTakim2.Location = new System.Drawing.Point(290, 138);
            this.cboTakim2.Name = "cboTakim2";
            this.cboTakim2.Size = new System.Drawing.Size(146, 24);
            this.cboTakim2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "VS";
            // 
            // dtpMacTime
            // 
            this.dtpMacTime.Location = new System.Drawing.Point(131, 61);
            this.dtpMacTime.Name = "dtpMacTime";
            this.dtpMacTime.Size = new System.Drawing.Size(200, 22);
            this.dtpMacTime.TabIndex = 8;
            // 
            // mtbSkor1
            // 
            this.mtbSkor1.HidePromptOnLeave = true;
            this.mtbSkor1.Location = new System.Drawing.Point(163, 177);
            this.mtbSkor1.Mask = "00";
            this.mtbSkor1.Name = "mtbSkor1";
            this.mtbSkor1.Size = new System.Drawing.Size(27, 22);
            this.mtbSkor1.TabIndex = 9;
            this.mtbSkor1.ValidatingType = typeof(int);
            // 
            // mtbSkor2
            // 
            this.mtbSkor2.HidePromptOnLeave = true;
            this.mtbSkor2.Location = new System.Drawing.Point(398, 174);
            this.mtbSkor2.Mask = "00";
            this.mtbSkor2.Name = "mtbSkor2";
            this.mtbSkor2.Size = new System.Drawing.Size(23, 22);
            this.mtbSkor2.TabIndex = 10;
            this.mtbSkor2.ValidatingType = typeof(int);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(256, 255);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(131, 255);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "IPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            // 
            // KarsilasmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.mtbSkor2);
            this.Controls.Add(this.mtbSkor1);
            this.Controls.Add(this.dtpMacTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTakim2);
            this.Controls.Add(this.cboTakim1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KarsilasmaForm";
            this.Text = "KarsilasmaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTakim1;
        private System.Windows.Forms.ComboBox cboTakim2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMacTime;
        private System.Windows.Forms.MaskedTextBox mtbSkor1;
        private System.Windows.Forms.MaskedTextBox mtbSkor2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
    }
}