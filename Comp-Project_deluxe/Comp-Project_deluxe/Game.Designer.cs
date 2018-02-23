namespace Comp_Project_deluxe
{
    partial class Game
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
            this.tb_output = new System.Windows.Forms.TextBox();
            this.bn_up = new System.Windows.Forms.Button();
            this.bn_right = new System.Windows.Forms.Button();
            this.bn_left = new System.Windows.Forms.Button();
            this.bn_down = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(246, 45);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(335, 264);
            this.tb_output.TabIndex = 0;
            // 
            // bn_up
            // 
            this.bn_up.Location = new System.Drawing.Point(373, 417);
            this.bn_up.Name = "bn_up";
            this.bn_up.Size = new System.Drawing.Size(75, 23);
            this.bn_up.TabIndex = 1;
            this.bn_up.Text = "Up";
            this.bn_up.UseVisualStyleBackColor = true;
            this.bn_up.Click += new System.EventHandler(this.bn_up_Click);
            // 
            // bn_right
            // 
            this.bn_right.Location = new System.Drawing.Point(455, 466);
            this.bn_right.Name = "bn_right";
            this.bn_right.Size = new System.Drawing.Size(75, 23);
            this.bn_right.TabIndex = 2;
            this.bn_right.Text = "Right";
            this.bn_right.UseVisualStyleBackColor = true;
            this.bn_right.Click += new System.EventHandler(this.bn_right_Click);
            // 
            // bn_left
            // 
            this.bn_left.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bn_left.Location = new System.Drawing.Point(281, 466);
            this.bn_left.Name = "bn_left";
            this.bn_left.Size = new System.Drawing.Size(75, 23);
            this.bn_left.TabIndex = 3;
            this.bn_left.Text = "Left";
            this.bn_left.UseVisualStyleBackColor = true;
            this.bn_left.Click += new System.EventHandler(this.bn_left_Click);
            // 
            // bn_down
            // 
            this.bn_down.Location = new System.Drawing.Point(373, 510);
            this.bn_down.Name = "bn_down";
            this.bn_down.Size = new System.Drawing.Size(75, 23);
            this.bn_down.TabIndex = 4;
            this.bn_down.Text = "Down";
            this.bn_down.UseVisualStyleBackColor = true;
            this.bn_down.Click += new System.EventHandler(this.bn_down_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(246, 344);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(335, 38);
            this.tb_input.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.bn_down);
            this.Controls.Add(this.bn_left);
            this.Controls.Add(this.bn_right);
            this.Controls.Add(this.bn_up);
            this.Controls.Add(this.tb_output);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.f_explore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button bn_up;
        private System.Windows.Forms.Button bn_right;
        private System.Windows.Forms.Button bn_left;
        private System.Windows.Forms.Button bn_down;
        private System.Windows.Forms.TextBox tb_input;
    }
}

