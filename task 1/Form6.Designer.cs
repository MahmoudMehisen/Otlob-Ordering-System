namespace task_1
{
    partial class Form6
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.OldOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(-1, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(1261, 338);
            this.Data.TabIndex = 0;
            // 
            // OldOrders
            // 
            this.OldOrders.BackColor = System.Drawing.SystemColors.Menu;
            this.OldOrders.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.OldOrders.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OldOrders.Location = new System.Drawing.Point(536, 338);
            this.OldOrders.Name = "OldOrders";
            this.OldOrders.Size = new System.Drawing.Size(163, 70);
            this.OldOrders.TabIndex = 8;
            this.OldOrders.Text = "Back";
            this.OldOrders.UseVisualStyleBackColor = false;
            this.OldOrders.Click += new System.EventHandler(this.OldOrders_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1260, 405);
            this.Controls.Add(this.OldOrders);
            this.Controls.Add(this.Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(-1, 86);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        public System.Windows.Forms.Button OldOrders;
    }
}