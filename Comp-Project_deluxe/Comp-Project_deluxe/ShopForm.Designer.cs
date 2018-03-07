namespace Comp_Project_deluxe
{
    partial class ShopForm
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
            this.s_txt_money = new System.Windows.Forms.TextBox();
            this.s_txt_title = new System.Windows.Forms.TextBox();
            this.s_btn_1 = new System.Windows.Forms.Button();
            this.s_btn_2 = new System.Windows.Forms.Button();
            this.s_btn_3 = new System.Windows.Forms.Button();
            this.s_btn_4 = new System.Windows.Forms.Button();
            this.s_txt_1 = new System.Windows.Forms.TextBox();
            this.s_txt_2 = new System.Windows.Forms.TextBox();
            this.s_txt_3 = new System.Windows.Forms.TextBox();
            this.s_txt_4 = new System.Windows.Forms.TextBox();
            this.S_btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // s_txt_money
            // 
            this.s_txt_money.Location = new System.Drawing.Point(212, 101);
            this.s_txt_money.Name = "s_txt_money";
            this.s_txt_money.ReadOnly = true;
            this.s_txt_money.Size = new System.Drawing.Size(100, 20);
            this.s_txt_money.TabIndex = 0;
            this.s_txt_money.TextChanged += new System.EventHandler(this.s_txt_money_TextChanged);
            // 
            // s_txt_title
            // 
            this.s_txt_title.Location = new System.Drawing.Point(139, 12);
            this.s_txt_title.Multiline = true;
            this.s_txt_title.Name = "s_txt_title";
            this.s_txt_title.ReadOnly = true;
            this.s_txt_title.Size = new System.Drawing.Size(287, 61);
            this.s_txt_title.TabIndex = 1;
            this.s_txt_title.TextChanged += new System.EventHandler(this.s_txt_title_TextChanged);
            // 
            // s_btn_1
            // 
            this.s_btn_1.Location = new System.Drawing.Point(318, 148);
            this.s_btn_1.Name = "s_btn_1";
            this.s_btn_1.Size = new System.Drawing.Size(75, 23);
            this.s_btn_1.TabIndex = 8;
            this.s_btn_1.Text = "Buy";
            this.s_btn_1.UseVisualStyleBackColor = true;
            this.s_btn_1.Click += new System.EventHandler(this.s_btn_1_Click);
            // 
            // s_btn_2
            // 
            this.s_btn_2.Location = new System.Drawing.Point(318, 195);
            this.s_btn_2.Name = "s_btn_2";
            this.s_btn_2.Size = new System.Drawing.Size(75, 23);
            this.s_btn_2.TabIndex = 9;
            this.s_btn_2.Text = "Buy";
            this.s_btn_2.UseVisualStyleBackColor = true;
            this.s_btn_2.Click += new System.EventHandler(this.s_btn_2_Click);
            // 
            // s_btn_3
            // 
            this.s_btn_3.Location = new System.Drawing.Point(318, 248);
            this.s_btn_3.Name = "s_btn_3";
            this.s_btn_3.Size = new System.Drawing.Size(75, 23);
            this.s_btn_3.TabIndex = 10;
            this.s_btn_3.Text = "Buy";
            this.s_btn_3.UseVisualStyleBackColor = true;
            this.s_btn_3.Click += new System.EventHandler(this.s_btn_3_Click);
            // 
            // s_btn_4
            // 
            this.s_btn_4.Location = new System.Drawing.Point(318, 301);
            this.s_btn_4.Name = "s_btn_4";
            this.s_btn_4.Size = new System.Drawing.Size(75, 23);
            this.s_btn_4.TabIndex = 11;
            this.s_btn_4.Text = "Buy";
            this.s_btn_4.UseVisualStyleBackColor = true;
            this.s_btn_4.Click += new System.EventHandler(this.s_btn_4_Click);
            // 
            // s_txt_1
            // 
            this.s_txt_1.Location = new System.Drawing.Point(150, 148);
            this.s_txt_1.Name = "s_txt_1";
            this.s_txt_1.Size = new System.Drawing.Size(162, 20);
            this.s_txt_1.TabIndex = 26;
            this.s_txt_1.TextChanged += new System.EventHandler(this.s_txt_1_TextChanged);
            // 
            // s_txt_2
            // 
            this.s_txt_2.Location = new System.Drawing.Point(150, 195);
            this.s_txt_2.Name = "s_txt_2";
            this.s_txt_2.Size = new System.Drawing.Size(162, 20);
            this.s_txt_2.TabIndex = 27;
            this.s_txt_2.TextChanged += new System.EventHandler(this.s_txt_2_TextChanged);
            // 
            // s_txt_3
            // 
            this.s_txt_3.Location = new System.Drawing.Point(150, 248);
            this.s_txt_3.Name = "s_txt_3";
            this.s_txt_3.Size = new System.Drawing.Size(162, 20);
            this.s_txt_3.TabIndex = 28;
            this.s_txt_3.TextChanged += new System.EventHandler(this.s_txt_3_TextChanged);
            // 
            // s_txt_4
            // 
            this.s_txt_4.Location = new System.Drawing.Point(150, 301);
            this.s_txt_4.Name = "s_txt_4";
            this.s_txt_4.Size = new System.Drawing.Size(162, 20);
            this.s_txt_4.TabIndex = 29;
            this.s_txt_4.TextChanged += new System.EventHandler(this.s_txt_4_TextChanged);
            // 
            // S_btn_exit
            // 
            this.S_btn_exit.Location = new System.Drawing.Point(237, 365);
            this.S_btn_exit.Name = "S_btn_exit";
            this.S_btn_exit.Size = new System.Drawing.Size(75, 23);
            this.S_btn_exit.TabIndex = 30;
            this.S_btn_exit.Text = "Exit";
            this.S_btn_exit.UseVisualStyleBackColor = true;
            this.S_btn_exit.Click += new System.EventHandler(this.S_btn_exit_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 422);
            this.Controls.Add(this.S_btn_exit);
            this.Controls.Add(this.s_txt_4);
            this.Controls.Add(this.s_txt_3);
            this.Controls.Add(this.s_txt_2);
            this.Controls.Add(this.s_txt_1);
            this.Controls.Add(this.s_btn_4);
            this.Controls.Add(this.s_btn_3);
            this.Controls.Add(this.s_btn_2);
            this.Controls.Add(this.s_btn_1);
            this.Controls.Add(this.s_txt_title);
            this.Controls.Add(this.s_txt_money);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox s_txt_money;
        private System.Windows.Forms.TextBox s_txt_title;
        private System.Windows.Forms.Button s_btn_1;
        private System.Windows.Forms.Button s_btn_2;
        private System.Windows.Forms.Button s_btn_3;
        private System.Windows.Forms.Button s_btn_4;
        private System.Windows.Forms.TextBox s_txt_1;
        private System.Windows.Forms.TextBox s_txt_2;
        private System.Windows.Forms.TextBox s_txt_3;
        private System.Windows.Forms.TextBox s_txt_4;
        private System.Windows.Forms.Button S_btn_exit;
        
    }
}