namespace AD_BS_Converter
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
            this.TxtBaseDateAD = new System.Windows.Forms.TextBox();
            this.TxtBaseDateBS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNewDateAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewDateBS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtN_Days = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDayslistbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMonthsinListbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnADtoBS = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotalDays = new System.Windows.Forms.TextBox();
            this.LblRemarks = new System.Windows.Forms.Label();
            this.TxtLastDateBS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLastDateAD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base date (AD)";
            // 
            // TxtBaseDateAD
            // 
            this.TxtBaseDateAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBaseDateAD.Location = new System.Drawing.Point(161, 54);
            this.TxtBaseDateAD.Name = "TxtBaseDateAD";
            this.TxtBaseDateAD.Size = new System.Drawing.Size(196, 22);
            this.TxtBaseDateAD.TabIndex = 1;
            this.TxtBaseDateAD.Text = "2022-04-14";
            this.TxtBaseDateAD.TextChanged += new System.EventHandler(this.TxtBaseDateAD_TextChanged);
            // 
            // TxtBaseDateBS
            // 
            this.TxtBaseDateBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBaseDateBS.Location = new System.Drawing.Point(492, 54);
            this.TxtBaseDateBS.Name = "TxtBaseDateBS";
            this.TxtBaseDateBS.Size = new System.Drawing.Size(196, 22);
            this.TxtBaseDateBS.TabIndex = 3;
            this.TxtBaseDateBS.Text = "2079-01-01";
            this.TxtBaseDateBS.TextChanged += new System.EventHandler(this.TxtBaseDateBS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base date (BS)";
            // 
            // TxtNewDateAD
            // 
            this.TxtNewDateAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewDateAD.Location = new System.Drawing.Point(161, 93);
            this.TxtNewDateAD.Name = "TxtNewDateAD";
            this.TxtNewDateAD.Size = new System.Drawing.Size(196, 22);
            this.TxtNewDateAD.TabIndex = 5;
            this.TxtNewDateAD.TextChanged += new System.EventHandler(this.TxtNewDateAD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "New date (AD)";
            // 
            // TxtNewDateBS
            // 
            this.TxtNewDateBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewDateBS.Location = new System.Drawing.Point(492, 96);
            this.TxtNewDateBS.Name = "TxtNewDateBS";
            this.TxtNewDateBS.Size = new System.Drawing.Size(196, 22);
            this.TxtNewDateBS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "New date (BS)";
            // 
            // TxtN_Days
            // 
            this.TxtN_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN_Days.Location = new System.Drawing.Point(241, 133);
            this.TxtN_Days.Name = "TxtN_Days";
            this.TxtN_Days.Size = new System.Drawing.Size(116, 22);
            this.TxtN_Days.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. of days (New - Base date)";
            // 
            // TxtDayslistbox
            // 
            this.TxtDayslistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDayslistbox.Location = new System.Drawing.Point(389, 249);
            this.TxtDayslistbox.Multiline = true;
            this.TxtDayslistbox.Name = "TxtDayslistbox";
            this.TxtDayslistbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDayslistbox.Size = new System.Drawing.Size(299, 128);
            this.TxtDayslistbox.TabIndex = 10;
            this.TxtDayslistbox.Text = "31,31,32,31,31,31,30,29,30,29,30,30,31,32,31,32,31,30";
            this.TxtDayslistbox.TextChanged += new System.EventHandler(this.TxtDayslistbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. of days in BS months";
            // 
            // TxtMonthsinListbox
            // 
            this.TxtMonthsinListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonthsinListbox.Location = new System.Drawing.Point(574, 380);
            this.TxtMonthsinListbox.Name = "TxtMonthsinListbox";
            this.TxtMonthsinListbox.Size = new System.Drawing.Size(68, 22);
            this.TxtMonthsinListbox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "No. of Months in above list";
            // 
            // BtnADtoBS
            // 
            this.BtnADtoBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnADtoBS.Location = new System.Drawing.Point(161, 332);
            this.BtnADtoBS.Name = "BtnADtoBS";
            this.BtnADtoBS.Size = new System.Drawing.Size(182, 45);
            this.BtnADtoBS.TabIndex = 14;
            this.BtnADtoBS.Text = "Convert AD to BS";
            this.BtnADtoBS.UseVisualStyleBackColor = true;
            this.BtnADtoBS.Click += new System.EventHandler(this.BtnADtoBS_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total no. of Days in above list";
            // 
            // TxtTotalDays
            // 
            this.TxtTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalDays.Location = new System.Drawing.Point(574, 408);
            this.TxtTotalDays.Name = "TxtTotalDays";
            this.TxtTotalDays.Size = new System.Drawing.Size(68, 22);
            this.TxtTotalDays.TabIndex = 15;
            // 
            // LblRemarks
            // 
            this.LblRemarks.AutoSize = true;
            this.LblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemarks.Location = new System.Drawing.Point(50, 252);
            this.LblRemarks.Name = "LblRemarks";
            this.LblRemarks.Size = new System.Drawing.Size(65, 16);
            this.LblRemarks.TabIndex = 17;
            this.LblRemarks.Text = "Remarks:";
            // 
            // TxtLastDateBS
            // 
            this.TxtLastDateBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastDateBS.Location = new System.Drawing.Point(492, 175);
            this.TxtLastDateBS.Name = "TxtLastDateBS";
            this.TxtLastDateBS.Size = new System.Drawing.Size(196, 22);
            this.TxtLastDateBS.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Last date (BS)";
            // 
            // TxtLastDateAD
            // 
            this.TxtLastDateAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastDateAD.Location = new System.Drawing.Point(161, 172);
            this.TxtLastDateAD.Name = "TxtLastDateAD";
            this.TxtLastDateAD.Size = new System.Drawing.Size(196, 22);
            this.TxtLastDateAD.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Last date (AD)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 485);
            this.Controls.Add(this.TxtLastDateBS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtLastDateAD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTotalDays);
            this.Controls.Add(this.BtnADtoBS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMonthsinListbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDayslistbox);
            this.Controls.Add(this.TxtN_Days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNewDateBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNewDateAD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBaseDateBS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBaseDateAD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CSAY AD to BS Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBaseDateAD;
        private System.Windows.Forms.TextBox TxtBaseDateBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNewDateAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewDateBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtN_Days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDayslistbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMonthsinListbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnADtoBS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalDays;
        private System.Windows.Forms.Label LblRemarks;
        private System.Windows.Forms.TextBox TxtLastDateBS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLastDateAD;
        private System.Windows.Forms.Label label10;
    }
}

