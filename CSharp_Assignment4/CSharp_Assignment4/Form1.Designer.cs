namespace CSharp_Assignment4
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_Object = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Inventory = new System.Windows.Forms.TextBox();
            this.txt_Object = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.DatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_User = new System.Windows.Forms.Label();
            this.group_Quality = new System.Windows.Forms.GroupBox();
            this.rad_NonPlastic = new System.Windows.Forms.RadioButton();
            this.rad_Plastic = new System.Windows.Forms.RadioButton();
            this.check_Availability = new System.Windows.Forms.CheckBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.group_Quality.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Number.Location = new System.Drawing.Point(12, 20);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(61, 19);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Date.Location = new System.Drawing.Point(14, 79);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Inventory.Location = new System.Drawing.Point(255, 20);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(127, 19);
            this.lbl_Inventory.TabIndex = 2;
            this.lbl_Inventory.Text = "Inventory Number";
            // 
            // lbl_Object
            // 
            this.lbl_Object.AutoSize = true;
            this.lbl_Object.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Object.Location = new System.Drawing.Point(10, 149);
            this.lbl_Object.Name = "lbl_Object";
            this.lbl_Object.Size = new System.Drawing.Size(52, 19);
            this.lbl_Object.TabIndex = 3;
            this.lbl_Object.Text = "Object";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Count.Location = new System.Drawing.Point(13, 210);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(49, 19);
            this.lbl_Count.TabIndex = 4;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_Price.Location = new System.Drawing.Point(13, 260);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(43, 19);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(15, 44);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(143, 20);
            this.txt_Number.TabIndex = 6;
            // 
            // txt_Inventory
            // 
            this.txt_Inventory.Location = new System.Drawing.Point(248, 44);
            this.txt_Inventory.Name = "txt_Inventory";
            this.txt_Inventory.Size = new System.Drawing.Size(171, 20);
            this.txt_Inventory.TabIndex = 8;
            // 
            // txt_Object
            // 
            this.txt_Object.Location = new System.Drawing.Point(14, 177);
            this.txt_Object.Name = "txt_Object";
            this.txt_Object.Size = new System.Drawing.Size(429, 20);
            this.txt_Object.TabIndex = 9;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(14, 232);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(144, 20);
            this.txt_Count.TabIndex = 10;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(14, 292);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(144, 20);
            this.txt_Price.TabIndex = 11;
            // 
            // DatePicker1
            // 
            this.DatePicker1.Location = new System.Drawing.Point(15, 110);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(200, 20);
            this.DatePicker1.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(731, 187);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(2, 318);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(644, 150);
            this.DataGridView.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(881, 44);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(29, 13);
            this.lbl_User.TabIndex = 17;
            this.lbl_User.Text = "User";
            // 
            // group_Quality
            // 
            this.group_Quality.Controls.Add(this.rad_NonPlastic);
            this.group_Quality.Controls.Add(this.rad_Plastic);
            this.group_Quality.Location = new System.Drawing.Point(330, 209);
            this.group_Quality.Name = "group_Quality";
            this.group_Quality.Size = new System.Drawing.Size(200, 100);
            this.group_Quality.TabIndex = 18;
            this.group_Quality.TabStop = false;
            this.group_Quality.Text = "Quality";
            // 
            // rad_NonPlastic
            // 
            this.rad_NonPlastic.AutoSize = true;
            this.rad_NonPlastic.Location = new System.Drawing.Point(19, 52);
            this.rad_NonPlastic.Name = "rad_NonPlastic";
            this.rad_NonPlastic.Size = new System.Drawing.Size(79, 17);
            this.rad_NonPlastic.TabIndex = 1;
            this.rad_NonPlastic.TabStop = true;
            this.rad_NonPlastic.Text = "Non Plastic";
            this.rad_NonPlastic.UseVisualStyleBackColor = true;
            // 
            // rad_Plastic
            // 
            this.rad_Plastic.AutoSize = true;
            this.rad_Plastic.Location = new System.Drawing.Point(19, 28);
            this.rad_Plastic.Name = "rad_Plastic";
            this.rad_Plastic.Size = new System.Drawing.Size(56, 17);
            this.rad_Plastic.TabIndex = 0;
            this.rad_Plastic.TabStop = true;
            this.rad_Plastic.Text = "Plastic";
            this.rad_Plastic.UseVisualStyleBackColor = true;
            // 
            // check_Availability
            // 
            this.check_Availability.AutoSize = true;
            this.check_Availability.Location = new System.Drawing.Point(571, 292);
            this.check_Availability.Name = "check_Availability";
            this.check_Availability.Size = new System.Drawing.Size(75, 17);
            this.check_Availability.TabIndex = 19;
            this.check_Availability.Text = "Availability";
            this.check_Availability.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(778, 145);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(835, 187);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(869, 318);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 23;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(666, 318);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(175, 20);
            this.txt_Search.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 522);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.check_Availability);
            this.Controls.Add(this.group_Quality);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_Object);
            this.Controls.Add(this.txt_Inventory);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lbl_Object);
            this.Controls.Add(this.lbl_Inventory);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.group_Quality.ResumeLayout(false);
            this.group_Quality.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_Object;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Inventory;
        private System.Windows.Forms.TextBox txt_Object;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.DateTimePicker DatePicker1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox check_Availability;
        private System.Windows.Forms.GroupBox group_Quality;
        private System.Windows.Forms.RadioButton rad_NonPlastic;
        private System.Windows.Forms.RadioButton rad_Plastic;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}

