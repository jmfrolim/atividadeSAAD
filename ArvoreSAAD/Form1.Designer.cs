namespace ArvoreSAAD
{
    partial class Form1
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
            this.cboTempo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTemperatura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUmidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVento = new System.Windows.Forms.ComboBox();
            this.buttonPlayTennis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // cboTempo
            // 
            this.cboTempo.FormattingEnabled = true;
            this.cboTempo.Location = new System.Drawing.Point(76, 10);
            this.cboTempo.Name = "cboTempo";
            this.cboTempo.Size = new System.Drawing.Size(80, 21);
            this.cboTempo.TabIndex = 1;
            this.cboTempo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatura";
            // 
            // cboTemperatura
            // 
            this.cboTemperatura.FormattingEnabled = true;
            this.cboTemperatura.Location = new System.Drawing.Point(76, 53);
            this.cboTemperatura.Name = "cboTemperatura";
            this.cboTemperatura.Size = new System.Drawing.Size(80, 21);
            this.cboTemperatura.TabIndex = 3;
            this.cboTemperatura.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Umidade";
            // 
            // cboUmidade
            // 
            this.cboUmidade.FormattingEnabled = true;
            this.cboUmidade.Location = new System.Drawing.Point(76, 93);
            this.cboUmidade.Name = "cboUmidade";
            this.cboUmidade.Size = new System.Drawing.Size(80, 21);
            this.cboUmidade.TabIndex = 5;
            this.cboUmidade.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vento";
            // 
            // cboVento
            // 
            this.cboVento.FormattingEnabled = true;
            this.cboVento.Location = new System.Drawing.Point(76, 131);
            this.cboVento.Name = "cboVento";
            this.cboVento.Size = new System.Drawing.Size(80, 21);
            this.cboVento.TabIndex = 7;
            // 
            // buttonPlayTennis
            // 
            this.buttonPlayTennis.Location = new System.Drawing.Point(65, 177);
            this.buttonPlayTennis.Name = "buttonPlayTennis";
            this.buttonPlayTennis.Size = new System.Drawing.Size(102, 23);
            this.buttonPlayTennis.TabIndex = 8;
            this.buttonPlayTennis.Text = "Posso Jogar ?";
            this.buttonPlayTennis.UseVisualStyleBackColor = true;
            this.buttonPlayTennis.Click += new System.EventHandler(this.buttonPlayTennis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 230);
            this.Controls.Add(this.buttonPlayTennis);
            this.Controls.Add(this.cboVento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboUmidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTemperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTempo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Atividade SAAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUmidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboVento;
        private System.Windows.Forms.Button buttonPlayTennis;
    }
}

