namespace wfp_acd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_ophigh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_oplow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_low1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_high1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_close1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_high3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_low3 = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txtbox_atr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "The highest opening range";
            // 
            // txtbox_ophigh
            // 
            this.txtbox_ophigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_ophigh.Location = new System.Drawing.Point(280, 43);
            this.txtbox_ophigh.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ophigh.Name = "txtbox_ophigh";
            this.txtbox_ophigh.Size = new System.Drawing.Size(155, 30);
            this.txtbox_ophigh.TabIndex = 1;
            this.txtbox_ophigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_ophigh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "The lowest opening range";
            // 
            // txtbox_oplow
            // 
            this.txtbox_oplow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_oplow.Location = new System.Drawing.Point(280, 97);
            this.txtbox_oplow.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_oplow.Name = "txtbox_oplow";
            this.txtbox_oplow.Size = new System.Drawing.Size(155, 30);
            this.txtbox_oplow.TabIndex = 2;
            this.txtbox_oplow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_oplow_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price Low 1 day ago";
            // 
            // txtbox_low1
            // 
            this.txtbox_low1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_low1.Location = new System.Drawing.Point(280, 145);
            this.txtbox_low1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_low1.Name = "txtbox_low1";
            this.txtbox_low1.Size = new System.Drawing.Size(155, 30);
            this.txtbox_low1.TabIndex = 3;
            this.txtbox_low1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_low1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price High 1 day ago";
            // 
            // txtbox_high1
            // 
            this.txtbox_high1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_high1.Location = new System.Drawing.Point(280, 194);
            this.txtbox_high1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_high1.Name = "txtbox_high1";
            this.txtbox_high1.Size = new System.Drawing.Size(155, 30);
            this.txtbox_high1.TabIndex = 4;
            this.txtbox_high1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_high1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label5.Location = new System.Drawing.Point(11, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price close 1 day ago";
            // 
            // txtbox_close1
            // 
            this.txtbox_close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_close1.Location = new System.Drawing.Point(280, 240);
            this.txtbox_close1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_close1.Name = "txtbox_close1";
            this.txtbox_close1.Size = new System.Drawing.Size(155, 30);
            this.txtbox_close1.TabIndex = 5;
            this.txtbox_close1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_close1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label6.Location = new System.Drawing.Point(11, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Highest price 3 days ago";
            // 
            // txtbox_high3
            // 
            this.txtbox_high3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_high3.Location = new System.Drawing.Point(280, 328);
            this.txtbox_high3.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_high3.Name = "txtbox_high3";
            this.txtbox_high3.Size = new System.Drawing.Size(155, 30);
            this.txtbox_high3.TabIndex = 7;
            this.txtbox_high3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_high3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label7.Location = new System.Drawing.Point(10, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = " Low price 3 days ago";
            // 
            // txtbox_low3
            // 
            this.txtbox_low3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_low3.Location = new System.Drawing.Point(280, 285);
            this.txtbox_low3.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_low3.Name = "txtbox_low3";
            this.txtbox_low3.Size = new System.Drawing.Size(155, 30);
            this.txtbox_low3.TabIndex = 6;
            this.txtbox_low3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_low3_KeyPress);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_calculate.Location = new System.Drawing.Point(13, 464);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(152, 38);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "View analysis";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txtbox_atr
            // 
            this.txtbox_atr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbox_atr.Location = new System.Drawing.Point(277, 378);
            this.txtbox_atr.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_atr.Name = "txtbox_atr";
            this.txtbox_atr.Size = new System.Drawing.Size(155, 30);
            this.txtbox_atr.TabIndex = 9;
            this.txtbox_atr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_atr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.label9.Location = new System.Drawing.Point(10, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "ATR Indicator";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(324, 464);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 38);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clean";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 520);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txtbox_low3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_atr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_high3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_close1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_high1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_low1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_oplow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_ophigh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_ophigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_oplow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_low1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_high1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_close1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_high3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_low3;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txtbox_atr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_clear;
    }
}

