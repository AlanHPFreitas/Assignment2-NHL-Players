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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.filterErrorTxt = new System.Windows.Forms.Label();
            this.sortErrorTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSort
            // 
            this.TxtSort.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSort.Location = new System.Drawing.Point(1189, 30);
            this.TxtSort.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSort.Name = "TxtSort";
            this.TxtSort.Size = new System.Drawing.Size(419, 61);
            this.TxtSort.TabIndex = 1;
            this.TxtSort.Text = "G des";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilter.Location = new System.Drawing.Point(516, 32);
            this.TxtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(379, 61);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.Text = "G >= 50";
            // 
            // dgvPlayerStats
            // 
            this.dgvPlayerStats.AccessibleName = "dgvPlayerStats";
            this.dgvPlayerStats.AllowUserToOrderColumns = true;
            this.dgvPlayerStats.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStats.Location = new System.Drawing.Point(36, 140);
            this.dgvPlayerStats.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.RowHeadersWidth = 51;
            this.dgvPlayerStats.RowTemplate.Height = 24;
            this.dgvPlayerStats.Size = new System.Drawing.Size(2750, 1275);
            this.dgvPlayerStats.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1671, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 116);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(972, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Sort:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(278, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 53);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Filter:";
            // 
            // filterErrorTxt
            // 
            this.filterErrorTxt.AutoSize = true;
            this.filterErrorTxt.ForeColor = System.Drawing.Color.Red;
            this.filterErrorTxt.Location = new System.Drawing.Point(525, 111);
            this.filterErrorTxt.Name = "filterErrorTxt";
            this.filterErrorTxt.Size = new System.Drawing.Size(0, 25);
            this.filterErrorTxt.TabIndex = 6;
            this.filterErrorTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // sortErrorTxt
            // 
            this.sortErrorTxt.AutoSize = true;
            this.sortErrorTxt.ForeColor = System.Drawing.Color.Red;
            this.sortErrorTxt.Location = new System.Drawing.Point(1199, 111);
            this.sortErrorTxt.Name = "sortErrorTxt";
            this.sortErrorTxt.Size = new System.Drawing.Size(0, 25);
            this.sortErrorTxt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2274, 675);
            this.Controls.Add(this.sortErrorTxt);
            this.Controls.Add(this.filterErrorTxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label filterErrorTxt;
        private System.Windows.Forms.Label sortErrorTxt;
    }
}

