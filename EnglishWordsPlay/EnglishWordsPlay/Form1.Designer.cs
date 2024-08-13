namespace EnglishWordsPlay
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
            this.components = new System.ComponentModel.Container();
            this.Dakikasec = new System.Windows.Forms.ComboBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.High_score_lbl = new System.Windows.Forms.Label();
            this.timer_Gerisayim = new System.Windows.Forms.Timer(this.components);
            this.High_score_text_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.engtr_btn = new System.Windows.Forms.RadioButton();
            this.treng_btn = new System.Windows.Forms.RadioButton();
            this.translate_btn = new System.Windows.Forms.Button();
            this.Checked_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scfdore_lbl = new System.Windows.Forms.Label();
            this.sscore_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dakikasec
            // 
            this.Dakikasec.BackColor = System.Drawing.Color.Linen;
            this.Dakikasec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Dakikasec.FormattingEnabled = true;
            this.Dakikasec.Items.AddRange(new object[] {
            "1 Minute",
            "3 Minutes",
            "5 Minutes"});
            this.Dakikasec.Location = new System.Drawing.Point(12, 12);
            this.Dakikasec.Name = "Dakikasec";
            this.Dakikasec.Size = new System.Drawing.Size(121, 24);
            this.Dakikasec.TabIndex = 0;
            this.Dakikasec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Gold;
            this.play_btn.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.play_btn.ForeColor = System.Drawing.Color.Red;
            this.play_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.play_btn.Location = new System.Drawing.Point(159, 16);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(129, 24);
            this.play_btn.TabIndex = 1;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // High_score_lbl
            // 
            this.High_score_lbl.AutoSize = true;
            this.High_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.High_score_lbl.Location = new System.Drawing.Point(344, 15);
            this.High_score_lbl.Name = "High_score_lbl";
            this.High_score_lbl.Size = new System.Drawing.Size(26, 25);
            this.High_score_lbl.TabIndex = 2;
            this.High_score_lbl.Text = "--";
            // 
            // timer_Gerisayim
            // 
            this.timer_Gerisayim.Interval = 1;
            this.timer_Gerisayim.Tick += new System.EventHandler(this.timer_Gerisayim_Tick);
            // 
            // High_score_text_lbl
            // 
            this.High_score_text_lbl.AutoSize = true;
            this.High_score_text_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.High_score_text_lbl.Location = new System.Drawing.Point(455, 12);
            this.High_score_text_lbl.Name = "High_score_text_lbl";
            this.High_score_text_lbl.Size = new System.Drawing.Size(29, 29);
            this.High_score_text_lbl.TabIndex = 3;
            this.High_score_text_lbl.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(407, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRANSLATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(179, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(317, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "FALSE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(407, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "-2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(561, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "TRUE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(638, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "+3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(234, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(483, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "|";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.richTextBox1.Location = new System.Drawing.Point(76, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 84);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.richTextBox2.Location = new System.Drawing.Point(497, 176);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(173, 84);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // engtr_btn
            // 
            this.engtr_btn.AutoSize = true;
            this.engtr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.engtr_btn.Location = new System.Drawing.Point(330, 194);
            this.engtr_btn.Name = "engtr_btn";
            this.engtr_btn.Size = new System.Drawing.Size(81, 24);
            this.engtr_btn.TabIndex = 9;
            this.engtr_btn.TabStop = true;
            this.engtr_btn.Text = "EN-TR";
            this.engtr_btn.UseVisualStyleBackColor = true;
            // 
            // treng_btn
            // 
            this.treng_btn.AutoSize = true;
            this.treng_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treng_btn.Location = new System.Drawing.Point(330, 230);
            this.treng_btn.Name = "treng_btn";
            this.treng_btn.Size = new System.Drawing.Size(94, 24);
            this.treng_btn.TabIndex = 9;
            this.treng_btn.TabStop = true;
            this.treng_btn.Text = "TR-ENG";
            this.treng_btn.UseVisualStyleBackColor = true;
            // 
            // translate_btn
            // 
            this.translate_btn.BackColor = System.Drawing.Color.Gold;
            this.translate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.translate_btn.ForeColor = System.Drawing.Color.Red;
            this.translate_btn.Location = new System.Drawing.Point(76, 323);
            this.translate_btn.Name = "translate_btn";
            this.translate_btn.Size = new System.Drawing.Size(173, 51);
            this.translate_btn.TabIndex = 10;
            this.translate_btn.Text = "TRANSLATE";
            this.translate_btn.UseVisualStyleBackColor = false;
            this.translate_btn.Click += new System.EventHandler(this.translate_btn_Click);
            // 
            // Checked_btn
            // 
            this.Checked_btn.BackColor = System.Drawing.Color.Gold;
            this.Checked_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Checked_btn.ForeColor = System.Drawing.Color.Red;
            this.Checked_btn.Location = new System.Drawing.Point(497, 323);
            this.Checked_btn.Name = "Checked_btn";
            this.Checked_btn.Size = new System.Drawing.Size(173, 51);
            this.Checked_btn.TabIndex = 10;
            this.Checked_btn.Text = "CHECK";
            this.Checked_btn.UseVisualStyleBackColor = false;
            this.Checked_btn.Click += new System.EventHandler(this.Checked_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(365, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "-";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LimeGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(344, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Puan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scfdore_lbl
            // 
            this.scfdore_lbl.AutoSize = true;
            this.scfdore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.scfdore_lbl.Location = new System.Drawing.Point(577, 12);
            this.scfdore_lbl.Name = "scfdore_lbl";
            this.scfdore_lbl.Size = new System.Drawing.Size(137, 24);
            this.scfdore_lbl.TabIndex = 15;
            this.scfdore_lbl.Text = "HİGH SCORE :";
            // 
            // sscore_lbl
            // 
            this.sscore_lbl.AutoSize = true;
            this.sscore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sscore_lbl.Location = new System.Drawing.Point(742, 13);
            this.sscore_lbl.Name = "sscore_lbl";
            this.sscore_lbl.Size = new System.Drawing.Size(20, 24);
            this.sscore_lbl.TabIndex = 15;
            this.sscore_lbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sscore_lbl);
            this.Controls.Add(this.scfdore_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Checked_btn);
            this.Controls.Add(this.translate_btn);
            this.Controls.Add(this.treng_btn);
            this.Controls.Add(this.engtr_btn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.High_score_text_lbl);
            this.Controls.Add(this.High_score_lbl);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.Dakikasec);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Dakikasec;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Label High_score_lbl;
        private System.Windows.Forms.Timer timer_Gerisayim;
        private System.Windows.Forms.Label High_score_text_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton engtr_btn;
        private System.Windows.Forms.RadioButton treng_btn;
        private System.Windows.Forms.Button translate_btn;
        private System.Windows.Forms.Button Checked_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label scfdore_lbl;
        private System.Windows.Forms.Label sscore_lbl;
    }
}

