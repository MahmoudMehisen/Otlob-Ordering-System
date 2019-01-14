namespace task_1
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_city = new System.Windows.Forms.Button();
            this.City_name_delete = new System.Windows.Forms.ComboBox();
            this.Add_City = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.City_name_add = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.District_name_add = new System.Windows.Forms.TextBox();
            this.City_distict = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.District_name_delete = new System.Windows.Forms.ComboBox();
            this.Delete_district = new System.Windows.Forms.Button();
            this.Add_district = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pic_Res = new System.Windows.Forms.PictureBox();
            this.Choose_Pic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.District_resturant = new System.Windows.Forms.ComboBox();
            this.Resturant_name_add = new System.Windows.Forms.TextBox();
            this.City_resturant = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Resturant_name_delete = new System.Windows.Forms.ComboBox();
            this.Delete_resturant = new System.Windows.Forms.Button();
            this.Add_resturant = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Edit_Meal = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Res)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::task_1.Properties.Resources._1280x960_Food_Tea;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(735, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 394);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Delete_city);
            this.groupBox1.Controls.Add(this.City_name_delete);
            this.groupBox1.Controls.Add(this.Add_City);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.City_name_add);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City";
            // 
            // Delete_city
            // 
            this.Delete_city.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Delete_city.ForeColor = System.Drawing.Color.White;
            this.Delete_city.Location = new System.Drawing.Point(134, 186);
            this.Delete_city.Name = "Delete_city";
            this.Delete_city.Size = new System.Drawing.Size(116, 43);
            this.Delete_city.TabIndex = 5;
            this.Delete_city.Text = "Delete";
            this.Delete_city.UseVisualStyleBackColor = false;
            this.Delete_city.Click += new System.EventHandler(this.Delete_city_Click);
            // 
            // City_name_delete
            // 
            this.City_name_delete.FormattingEnabled = true;
            this.City_name_delete.Location = new System.Drawing.Point(99, 143);
            this.City_name_delete.Name = "City_name_delete";
            this.City_name_delete.Size = new System.Drawing.Size(198, 37);
            this.City_name_delete.TabIndex = 4;
            this.City_name_delete.SelectedIndexChanged += new System.EventHandler(this.City_name_delete_SelectedIndexChanged);
            // 
            // Add_City
            // 
            this.Add_City.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Add_City.ForeColor = System.Drawing.Color.White;
            this.Add_City.Location = new System.Drawing.Point(134, 75);
            this.Add_City.Name = "Add_City";
            this.Add_City.Size = new System.Drawing.Size(116, 43);
            this.Add_City.TabIndex = 3;
            this.Add_City.Text = "Add";
            this.Add_City.UseVisualStyleBackColor = false;
            this.Add_City.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // City_name_add
            // 
            this.City_name_add.Location = new System.Drawing.Point(101, 33);
            this.City_name_add.Name = "City_name_add";
            this.City_name_add.Size = new System.Drawing.Size(196, 36);
            this.City_name_add.TabIndex = 0;
            this.City_name_add.TextChanged += new System.EventHandler(this.City_name_add_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.District_name_add);
            this.groupBox2.Controls.Add(this.City_distict);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.District_name_delete);
            this.groupBox2.Controls.Add(this.Delete_district);
            this.groupBox2.Controls.Add(this.Add_district);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 289);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "District";
            // 
            // District_name_add
            // 
            this.District_name_add.Location = new System.Drawing.Point(101, 91);
            this.District_name_add.Name = "District_name_add";
            this.District_name_add.Size = new System.Drawing.Size(196, 36);
            this.District_name_add.TabIndex = 6;
            this.District_name_add.TextChanged += new System.EventHandler(this.District_name_add_TextChanged);
            // 
            // City_distict
            // 
            this.City_distict.FormattingEnabled = true;
            this.City_distict.Location = new System.Drawing.Point(99, 45);
            this.City_distict.Name = "City_distict";
            this.City_distict.Size = new System.Drawing.Size(198, 37);
            this.City_distict.TabIndex = 9;
            this.City_distict.SelectedIndexChanged += new System.EventHandler(this.City_distict_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // District_name_delete
            // 
            this.District_name_delete.FormattingEnabled = true;
            this.District_name_delete.Location = new System.Drawing.Point(99, 184);
            this.District_name_delete.Name = "District_name_delete";
            this.District_name_delete.Size = new System.Drawing.Size(198, 37);
            this.District_name_delete.TabIndex = 6;
            this.District_name_delete.SelectedIndexChanged += new System.EventHandler(this.District_name_delete_SelectedIndexChanged);
            // 
            // Delete_district
            // 
            this.Delete_district.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Delete_district.ForeColor = System.Drawing.Color.White;
            this.Delete_district.Location = new System.Drawing.Point(134, 227);
            this.Delete_district.Name = "Delete_district";
            this.Delete_district.Size = new System.Drawing.Size(116, 43);
            this.Delete_district.TabIndex = 6;
            this.Delete_district.Text = "Delete";
            this.Delete_district.UseVisualStyleBackColor = false;
            this.Delete_district.Click += new System.EventHandler(this.Delete_district_Click);
            // 
            // Add_district
            // 
            this.Add_district.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Add_district.ForeColor = System.Drawing.Color.White;
            this.Add_district.Location = new System.Drawing.Point(134, 135);
            this.Add_district.Name = "Add_district";
            this.Add_district.Size = new System.Drawing.Size(116, 43);
            this.Add_district.TabIndex = 6;
            this.Add_district.Text = "Add";
            this.Add_district.UseVisualStyleBackColor = false;
            this.Add_district.Click += new System.EventHandler(this.Add_district_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Pic_Res);
            this.groupBox3.Controls.Add(this.Choose_Pic);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.District_resturant);
            this.groupBox3.Controls.Add(this.Resturant_name_add);
            this.groupBox3.Controls.Add(this.City_resturant);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Resturant_name_delete);
            this.groupBox3.Controls.Add(this.Delete_resturant);
            this.groupBox3.Controls.Add(this.Add_resturant);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(398, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 542);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resturant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Image";
            // 
            // Pic_Res
            // 
            this.Pic_Res.BackColor = System.Drawing.Color.White;
            this.Pic_Res.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Res.ErrorImage = global::task_1.Properties.Resources._1280x960_Food_Fruit;
            this.Pic_Res.InitialImage = global::task_1.Properties.Resources._3872x2592_Food_Cake;
            this.Pic_Res.Location = new System.Drawing.Point(116, 204);
            this.Pic_Res.Name = "Pic_Res";
            this.Pic_Res.Size = new System.Drawing.Size(198, 127);
            this.Pic_Res.TabIndex = 14;
            this.Pic_Res.TabStop = false;
            this.Pic_Res.WaitOnLoad = true;
            this.Pic_Res.Click += new System.EventHandler(this.Pic_Res_Click);
            // 
            // Choose_Pic
            // 
            this.Choose_Pic.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Choose_Pic.ForeColor = System.Drawing.Color.White;
            this.Choose_Pic.Location = new System.Drawing.Point(153, 337);
            this.Choose_Pic.Name = "Choose_Pic";
            this.Choose_Pic.Size = new System.Drawing.Size(116, 43);
            this.Choose_Pic.TabIndex = 13;
            this.Choose_Pic.Text = "Choose";
            this.Choose_Pic.UseVisualStyleBackColor = false;
            this.Choose_Pic.Click += new System.EventHandler(this.Choose_Pic_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "District";
            // 
            // District_resturant
            // 
            this.District_resturant.FormattingEnabled = true;
            this.District_resturant.Location = new System.Drawing.Point(116, 108);
            this.District_resturant.Name = "District_resturant";
            this.District_resturant.Size = new System.Drawing.Size(198, 37);
            this.District_resturant.TabIndex = 10;
            this.District_resturant.SelectedIndexChanged += new System.EventHandler(this.District_resturant_SelectedIndexChanged);
            // 
            // Resturant_name_add
            // 
            this.Resturant_name_add.Location = new System.Drawing.Point(118, 162);
            this.Resturant_name_add.Name = "Resturant_name_add";
            this.Resturant_name_add.Size = new System.Drawing.Size(196, 36);
            this.Resturant_name_add.TabIndex = 6;
            this.Resturant_name_add.TextChanged += new System.EventHandler(this.Resturant_name_add_TextChanged);
            // 
            // City_resturant
            // 
            this.City_resturant.FormattingEnabled = true;
            this.City_resturant.Location = new System.Drawing.Point(116, 50);
            this.City_resturant.Name = "City_resturant";
            this.City_resturant.Size = new System.Drawing.Size(198, 37);
            this.City_resturant.TabIndex = 9;
            this.City_resturant.SelectedIndexChanged += new System.EventHandler(this.City_resturant_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // Resturant_name_delete
            // 
            this.Resturant_name_delete.FormattingEnabled = true;
            this.Resturant_name_delete.Location = new System.Drawing.Point(116, 450);
            this.Resturant_name_delete.Name = "Resturant_name_delete";
            this.Resturant_name_delete.Size = new System.Drawing.Size(198, 37);
            this.Resturant_name_delete.TabIndex = 6;
            this.Resturant_name_delete.SelectedIndexChanged += new System.EventHandler(this.Resturant_name_delete_SelectedIndexChanged);
            // 
            // Delete_resturant
            // 
            this.Delete_resturant.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Delete_resturant.ForeColor = System.Drawing.Color.White;
            this.Delete_resturant.Location = new System.Drawing.Point(153, 493);
            this.Delete_resturant.Name = "Delete_resturant";
            this.Delete_resturant.Size = new System.Drawing.Size(116, 43);
            this.Delete_resturant.TabIndex = 6;
            this.Delete_resturant.Text = "Delete";
            this.Delete_resturant.UseVisualStyleBackColor = false;
            this.Delete_resturant.Click += new System.EventHandler(this.button4_Click);
            // 
            // Add_resturant
            // 
            this.Add_resturant.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Add_resturant.ForeColor = System.Drawing.Color.White;
            this.Add_resturant.Location = new System.Drawing.Point(153, 401);
            this.Add_resturant.Name = "Add_resturant";
            this.Add_resturant.Size = new System.Drawing.Size(116, 43);
            this.Add_resturant.TabIndex = 6;
            this.Add_resturant.Text = "Add";
            this.Add_resturant.UseVisualStyleBackColor = false;
            this.Add_resturant.Click += new System.EventHandler(this.Add_resturant_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Edit_Meal);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(783, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Meal";
            // 
            // Edit_Meal
            // 
            this.Edit_Meal.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Edit_Meal.ForeColor = System.Drawing.Color.White;
            this.Edit_Meal.Location = new System.Drawing.Point(153, 39);
            this.Edit_Meal.Name = "Edit_Meal";
            this.Edit_Meal.Size = new System.Drawing.Size(116, 43);
            this.Edit_Meal.TabIndex = 7;
            this.Edit_Meal.Text = "Edit";
            this.Edit_Meal.UseVisualStyleBackColor = false;
            this.Edit_Meal.Click += new System.EventHandler(this.Edit_Meal_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Back.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(816, 505);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(116, 43);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::task_1.Properties.Resources._1280x960_Food_Tea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 566);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Res)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox City_name_add;
        private System.Windows.Forms.Button Add_City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_city;
        private System.Windows.Forms.ComboBox City_name_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox City_distict;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox District_name_delete;
        private System.Windows.Forms.Button Delete_district;
        private System.Windows.Forms.Button Add_district;
        private System.Windows.Forms.TextBox District_name_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox District_resturant;
        private System.Windows.Forms.TextBox Resturant_name_add;
        private System.Windows.Forms.ComboBox City_resturant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Resturant_name_delete;
        private System.Windows.Forms.Button Delete_resturant;
        private System.Windows.Forms.Button Add_resturant;
        private System.Windows.Forms.Button Choose_Pic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Edit_Meal;
        private System.Windows.Forms.PictureBox Pic_Res;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Back;
    }
}