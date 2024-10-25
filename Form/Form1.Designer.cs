namespace Assignment2_NHL_Players.Forms
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
        /// Método necessário para o suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlayerStats = new System.Windows.Forms.DataGridView();
            this.TxtSort = new System.Windows.Forms.TextBox();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayerStats
            // 
            this.dgvPlayerStats.AccessibleName = "dgvPlayerStats";
            this.dgvPlayerStats.AllowUserToOrderColumns = true;
            this.dgvPlayerStats.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStats.Location = new System.Drawing.Point(12, 51);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.RowHeadersWidth = 51;
            this.dgvPlayerStats.RowTemplate.Height = 24;
            this.dgvPlayerStats.Size = new System.Drawing.Size(776, 387);
            this.dgvPlayerStats.TabIndex = 0;
            // 
            // TxtSort
            // 
            this.TxtSort.Location = new System.Drawing.Point(445, 12);
            this.TxtSort.Name = "TxtSort";
            this.TxtSort.Size = new System.Drawing.Size(160, 22);
            this.TxtSort.TabIndex = 1;
            this.TxtSort.Text = "G des";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(636, 12);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(152, 22);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.Text = "G >= 50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.TxtSort);
            this.Controls.Add(this.dgvPlayerStats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerStats;
        private System.Windows.Forms.TextBox TxtSort;
        private System.Windows.Forms.TextBox TxtFilter;
    }
}

