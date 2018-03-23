﻿namespace Comp_Project_deluxe
{
    partial class Leaderboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSProjDataSet = new Comp_Project_deluxe.CSProjDataSet();
            this.L_btn_exit = new System.Windows.Forms.Button();
            this.playerScoreTableAdapter = new Comp_Project_deluxe.CSProjDataSetTableAdapters.PlayerScoreTableAdapter();
            this.playerUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSProjDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerUsernameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerScoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playerScoreBindingSource
            // 
            this.playerScoreBindingSource.DataMember = "PlayerScore";
            this.playerScoreBindingSource.DataSource = this.cSProjDataSet;
            // 
            // cSProjDataSet
            // 
            this.cSProjDataSet.DataSetName = "CSProjDataSet";
            this.cSProjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // L_btn_exit
            // 
            this.L_btn_exit.Location = new System.Drawing.Point(96, 385);
            this.L_btn_exit.Name = "L_btn_exit";
            this.L_btn_exit.Size = new System.Drawing.Size(75, 23);
            this.L_btn_exit.TabIndex = 1;
            this.L_btn_exit.Text = "Exit";
            this.L_btn_exit.UseVisualStyleBackColor = true;
            this.L_btn_exit.Click += new System.EventHandler(this.L_btn_exit_Click);
            // 
            // playerScoreTableAdapter
            // 
            this.playerScoreTableAdapter.ClearBeforeFill = true;
            // 
            // playerUsernameDataGridViewTextBoxColumn
            // 
            this.playerUsernameDataGridViewTextBoxColumn.DataPropertyName = "playerUsername";
            this.playerUsernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.playerUsernameDataGridViewTextBoxColumn.Name = "playerUsernameDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 412);
            this.Controls.Add(this.L_btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSProjDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button L_btn_exit;
        private CSProjDataSet cSProjDataSet;
        private System.Windows.Forms.BindingSource playerScoreBindingSource;
        private CSProjDataSetTableAdapters.PlayerScoreTableAdapter playerScoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}