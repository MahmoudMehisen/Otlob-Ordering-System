namespace task_1
{
    partial class UserMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.Sign_Out = new System.Windows.Forms.Button();
            this.MyOrder = new System.Windows.Forms.Button();
            this.OldOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.Menu;
            this.UserName.Location = new System.Drawing.Point(19, 16);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(276, 58);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // Sign_Out
            // 
            this.Sign_Out.BackColor = System.Drawing.SystemColors.Menu;
            this.Sign_Out.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Out.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Sign_Out.Location = new System.Drawing.Point(1064, 3);
            this.Sign_Out.Name = "Sign_Out";
            this.Sign_Out.Size = new System.Drawing.Size(213, 92);
            this.Sign_Out.TabIndex = 1;
            this.Sign_Out.Text = "Sign Out";
            this.Sign_Out.UseVisualStyleBackColor = false;
            this.Sign_Out.Click += new System.EventHandler(this.Sign_Out_Click);
            // 
            // MyOrder
            // 
            this.MyOrder.BackColor = System.Drawing.SystemColors.Menu;
            this.MyOrder.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.MyOrder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MyOrder.Location = new System.Drawing.Point(848, 3);
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(221, 92);
            this.MyOrder.TabIndex = 2;
            this.MyOrder.Text = "MyOrder";
            this.MyOrder.UseVisualStyleBackColor = false;
            // 
            // OldOrders
            // 
            this.OldOrders.BackColor = System.Drawing.SystemColors.Menu;
            this.OldOrders.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.OldOrders.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OldOrders.Location = new System.Drawing.Point(631, 3);
            this.OldOrders.Name = "OldOrders";
            this.OldOrders.Size = new System.Drawing.Size(221, 92);
            this.OldOrders.TabIndex = 3;
            this.OldOrders.Text = "OldOrders";
            this.OldOrders.UseVisualStyleBackColor = false;
            this.OldOrders.Click += new System.EventHandler(this.OldOrders_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.OldOrders);
            this.Controls.Add(this.MyOrder);
            this.Controls.Add(this.Sign_Out);
            this.Controls.Add(this.UserName);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "UserMenu";
            this.Size = new System.Drawing.Size(1280, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Button Sign_Out;
        public System.Windows.Forms.Button MyOrder;
        public System.Windows.Forms.Button OldOrders;
    }
}
