namespace task_1
{
    partial class MyOrder
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
            this.ViewOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewOrder
            // 
            this.ViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrder.Location = new System.Drawing.Point(0, 0);
            this.ViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(471, 456);
            this.ViewOrder.TabIndex = 0;
            this.ViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewOrder_CellContentClick);
            // 
            // MyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyOrder";
            this.Size = new System.Drawing.Size(471, 479);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView ViewOrder;
    }
}
