namespace pingapp2
{
    partial class Form2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button13 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pcCheck = new System.Windows.Forms.CheckBox();
            this.printerCheck = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.tempBar = new System.Windows.Forms.ProgressBar();
            this.ramBar = new System.Windows.Forms.ProgressBar();
            this.inkBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(300, 63);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 20);
            this.button13.TabIndex = 0;
            this.button13.Text = "Connect";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 63);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(282, 20);
            this.textBox13.TabIndex = 1;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Write IP Address Below";
            // 
            // pcCheck
            // 
            this.pcCheck.AccessibleName = "pcCheck";
            this.pcCheck.AutoSize = true;
            this.pcCheck.Location = new System.Drawing.Point(12, 12);
            this.pcCheck.Name = "pcCheck";
            this.pcCheck.Size = new System.Drawing.Size(40, 17);
            this.pcCheck.TabIndex = 4;
            this.pcCheck.Text = "PC";
            this.pcCheck.UseVisualStyleBackColor = true;
            this.pcCheck.CheckedChanged += new System.EventHandler(this.pcCheck_click);
            // 
            // printerCheck
            // 
            this.printerCheck.AccessibleName = "printerCheck";
            this.printerCheck.AutoSize = true;
            this.printerCheck.Location = new System.Drawing.Point(71, 12);
            this.printerCheck.Name = "printerCheck";
            this.printerCheck.Size = new System.Drawing.Size(56, 17);
            this.printerCheck.TabIndex = 5;
            this.printerCheck.Text = "Printer";
            this.printerCheck.UseVisualStyleBackColor = true;
            this.printerCheck.CheckedChanged += new System.EventHandler(this.printerCheck_click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Brother",
            "Canon",
            "HP",
            "Lexmark",
            "Toshiba"});
            this.comboBox1.Location = new System.Drawing.Point(12, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Printer Type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(13, 148);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(230, 23);
            this.cpuBar.TabIndex = 7;
            // 
            // tempBar
            // 
            this.tempBar.Location = new System.Drawing.Point(12, 192);
            this.tempBar.Name = "tempBar";
            this.tempBar.Size = new System.Drawing.Size(231, 23);
            this.tempBar.TabIndex = 8;
            // 
            // ramBar
            // 
            this.ramBar.Location = new System.Drawing.Point(13, 237);
            this.ramBar.Name = "ramBar";
            this.ramBar.Size = new System.Drawing.Size(231, 23);
            this.ramBar.TabIndex = 9;
            // 
            // inkBar
            // 
            this.inkBar.Location = new System.Drawing.Point(13, 148);
            this.inkBar.Name = "inkBar";
            this.inkBar.Size = new System.Drawing.Size(231, 23);
            this.inkBar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(247, 202);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "label3";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(247, 247);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 13);
            this.label41.TabIndex = 13;
            this.label41.Text = "label4";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(247, 158);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 13);
            this.label51.TabIndex = 14;
            this.label51.Text = "label5";
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(12, 106);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(121, 21);
            this.comboBox21.TabIndex = 15;
            this.comboBox21.Text = "PC Type";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.comboBox21);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inkBar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.printerCheck);
            this.Controls.Add(this.pcCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.cpuBar);
            this.Controls.Add(this.tempBar);
            this.Controls.Add(this.ramBar);
            this.Name = "Form2";
            this.Text = "AdminHelper SNMP";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox pcCheck;
        private System.Windows.Forms.CheckBox printerCheck;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.ProgressBar tempBar;
        private System.Windows.Forms.ProgressBar ramBar;
        private System.Windows.Forms.ProgressBar inkBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox comboBox21;
    }
}

