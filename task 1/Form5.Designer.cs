namespace task_1
{
    partial class Form5
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
            this.OredrList = new System.Windows.Forms.ListView();
            this.Resturant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OredrList
            // 
            this.OredrList.BackColor = System.Drawing.SystemColors.Menu;
            this.OredrList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Resturant,
            this.Total_Price,
            this.Time});
            this.OredrList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OredrList.Location = new System.Drawing.Point(2, 1);
            this.OredrList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OredrList.Name = "OredrList";
            this.OredrList.Size = new System.Drawing.Size(1260, 399);
            this.OredrList.TabIndex = 0;
            this.OredrList.UseCompatibleStateImageBehavior = false;
            // 
            // Resturant
            // 
            this.Resturant.Text = "Resturant";
            this.Resturant.Width = 500;
            // 
            // Total_Price
            // 
            this.Total_Price.Text = "Total Price";
            this.Total_Price.Width = 300;
            // 
            // Time
            // 
            this.Time.Text = "Delivery time";
            this.Time.Width = 300;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Menu;
            this.Back.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Back.Location = new System.Drawing.Point(562, 397);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(163, 50);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1260, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OredrList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OredrList;
        private System.Windows.Forms.ColumnHeader Resturant;
        private System.Windows.Forms.ColumnHeader Total_Price;
        private System.Windows.Forms.ColumnHeader Time;
        public System.Windows.Forms.Button Back;
    }
}