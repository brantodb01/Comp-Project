namespace Comp_Project_deluxe
{
    partial class battle_r1
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
            this.B_btn_Attack = new System.Windows.Forms.Button();
            this.B_txt_output = new System.Windows.Forms.TextBox();
            this.B_btn_Ranged = new System.Windows.Forms.Button();
            this.B_btn_Inv = new System.Windows.Forms.Button();
            this.B_btn_Escape = new System.Windows.Forms.Button();
            this.B_txt_playerHealth = new System.Windows.Forms.TextBox();
            this.B_txt_enemyHealth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_btn_Attack
            // 
            this.B_btn_Attack.Location = new System.Drawing.Point(32, 344);
            this.B_btn_Attack.Name = "B_btn_Attack";
            this.B_btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.B_btn_Attack.TabIndex = 0;
            this.B_btn_Attack.Text = "Melee";
            this.B_btn_Attack.UseVisualStyleBackColor = true;
            this.B_btn_Attack.Click += new System.EventHandler(this.B_btn_Attack_Click);
            // 
            // B_txt_output
            // 
            this.B_txt_output.Location = new System.Drawing.Point(12, 12);
            this.B_txt_output.Multiline = true;
            this.B_txt_output.Name = "B_txt_output";
            this.B_txt_output.ReadOnly = true;
            this.B_txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.B_txt_output.Size = new System.Drawing.Size(360, 244);
            this.B_txt_output.TabIndex = 1;
            this.B_txt_output.TextChanged += new System.EventHandler(this.B_txt_output_TextChanged);
            // 
            // B_btn_Ranged
            // 
            this.B_btn_Ranged.Location = new System.Drawing.Point(113, 344);
            this.B_btn_Ranged.Name = "B_btn_Ranged";
            this.B_btn_Ranged.Size = new System.Drawing.Size(75, 23);
            this.B_btn_Ranged.TabIndex = 2;
            this.B_btn_Ranged.Text = "Ranged";
            this.B_btn_Ranged.UseVisualStyleBackColor = true;
            this.B_btn_Ranged.Click += new System.EventHandler(this.B_btn_Ranged_Click);
            // 
            // B_btn_Inv
            // 
            this.B_btn_Inv.Location = new System.Drawing.Point(194, 344);
            this.B_btn_Inv.Name = "B_btn_Inv";
            this.B_btn_Inv.Size = new System.Drawing.Size(75, 23);
            this.B_btn_Inv.TabIndex = 3;
            this.B_btn_Inv.Text = "Inventory";
            this.B_btn_Inv.UseVisualStyleBackColor = true;
            this.B_btn_Inv.Click += new System.EventHandler(this.B_btn_Inv_Click);
            // 
            // B_btn_Escape
            // 
            this.B_btn_Escape.Location = new System.Drawing.Point(275, 344);
            this.B_btn_Escape.Name = "B_btn_Escape";
            this.B_btn_Escape.Size = new System.Drawing.Size(75, 23);
            this.B_btn_Escape.TabIndex = 4;
            this.B_btn_Escape.Text = "Escape";
            this.B_btn_Escape.UseVisualStyleBackColor = true;
            this.B_btn_Escape.Click += new System.EventHandler(this.B_btn_Escape_Click);
            // 
            // B_txt_playerHealth
            // 
            this.B_txt_playerHealth.Location = new System.Drawing.Point(12, 273);
            this.B_txt_playerHealth.Name = "B_txt_playerHealth";
            this.B_txt_playerHealth.ReadOnly = true;
            this.B_txt_playerHealth.Size = new System.Drawing.Size(100, 20);
            this.B_txt_playerHealth.TabIndex = 5;
            this.B_txt_playerHealth.TextChanged += new System.EventHandler(this.B_txt_playerHealth_TextChanged);
            // 
            // B_txt_enemyHealth
            // 
            this.B_txt_enemyHealth.Location = new System.Drawing.Point(272, 273);
            this.B_txt_enemyHealth.Name = "B_txt_enemyHealth";
            this.B_txt_enemyHealth.ReadOnly = true;
            this.B_txt_enemyHealth.Size = new System.Drawing.Size(100, 20);
            this.B_txt_enemyHealth.TabIndex = 6;
            this.B_txt_enemyHealth.TextChanged += new System.EventHandler(this.B_txt_enemyHealth_TextChanged);
            // 
            // battle_r1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 402);
            this.Controls.Add(this.B_txt_enemyHealth);
            this.Controls.Add(this.B_txt_playerHealth);
            this.Controls.Add(this.B_btn_Escape);
            this.Controls.Add(this.B_btn_Inv);
            this.Controls.Add(this.B_btn_Ranged);
            this.Controls.Add(this.B_txt_output);
            this.Controls.Add(this.B_btn_Attack);
            this.Name = "battle_r1";
            this.Text = "battle_r1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_btn_Attack;
        private System.Windows.Forms.TextBox B_txt_output;
        private System.Windows.Forms.Button B_btn_Ranged;
        private System.Windows.Forms.Button B_btn_Inv;
        private System.Windows.Forms.Button B_btn_Escape;
        private System.Windows.Forms.TextBox B_txt_playerHealth;
        private System.Windows.Forms.TextBox B_txt_enemyHealth;
    }
}