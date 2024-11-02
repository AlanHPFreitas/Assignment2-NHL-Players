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
            this.TxtSort = new System.Windows.Forms.TextBox();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.dgvPlayerStats = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSort
            // 
            this.TxtSort.Location = new System.Drawing.Point(612, 18);
            this.TxtSort.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSort.Name = "TxtSort";
            this.TxtSort.Size = new System.Drawing.Size(218, 29);
            this.TxtSort.TabIndex = 1;
            this.TxtSort.Text = "G des";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(874, 18);
            this.TxtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(208, 29);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.Text = "G >= 50";
            // 
            // dgvPlayerStats
            // 
            this.dgvPlayerStats.AccessibleName = "dgvPlayerStats";
            this.dgvPlayerStats.AllowUserToOrderColumns = true;
            this.dgvPlayerStats.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStats.Location = new System.Drawing.Point(16, 76);
            this.dgvPlayerStats.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.RowHeadersWidth = 51;
            this.dgvPlayerStats.RowTemplate.Height = 24;
            this.dgvPlayerStats.Size = new System.Drawing.Size(1067, 580);
            this.dgvPlayerStats.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.TxtSort);
            this.Controls.Add(this.dgvPlayerStats);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSort;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.DataGridView dgvPlayerStats;
        private System.Windows.Forms.Button button1;
    }
}

