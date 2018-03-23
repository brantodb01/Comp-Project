namespace Comp_Project_deluxe
{
    partial class Menu
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
            this.M_txt_name = new System.Windows.Forms.TextBox();
            this.M_btn_play = new System.Windows.Forms.Button();
            this.M_btn_leaderboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // M_txt_name
            // 
            this.M_txt_name.Location = new System.Drawing.Point(53, 12);
            this.M_txt_name.Name = "M_txt_name";
            this.M_txt_name.Size = new System.Drawing.Size(119, 20);
            this.M_txt_name.TabIndex = 0;
            this.M_txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // M_btn_play
            // 
            this.M_btn_play.Location = new System.Drawing.Point(53, 73);
            this.M_btn_play.Name = "M_btn_play";
            this.M_btn_play.Size = new System.Drawing.Size(119, 23);
            this.M_btn_play.TabIndex = 1;
            this.M_btn_play.Text = "Play";
            this.M_btn_play.UseVisualStyleBackColor = true;
            this.M_btn_play.Click += new System.EventHandler(this.M_btn_play_Click);
            // 
            // M_btn_leaderboard
            // 
            this.M_btn_leaderboard.Location = new System.Drawing.Point(53, 150);
            this.M_btn_leaderboard.Name = "M_btn_leaderboard";
            this.M_btn_leaderboard.Size = new System.Drawing.Size(119, 23);
            this.M_btn_leaderboard.TabIndex = 2;
            this.M_btn_leaderboard.Text = "Leaderboard";
            this.M_btn_leaderboard.UseVisualStyleBackColor = true;
            this.M_btn_leaderboard.Click += new System.EventHandler(this.M_btn_leaderboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.M_btn_leaderboard);
            this.Controls.Add(this.M_btn_play);
            this.Controls.Add(this.M_txt_name);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox M_txt_name;
        private System.Windows.Forms.Button M_btn_play;
        private System.Windows.Forms.Button M_btn_leaderboard;
        private System.Windows.Forms.Label label1;
    }
}