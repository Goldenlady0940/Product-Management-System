﻿namespace CSharp_Assignment4
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(12, 20);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(90, 27);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(190, 20);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(59, 27);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(435, 20);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(190, 27);
            this.lbl_Inventory.TabIndex = 2;
            this.lbl_Inventory.Text = "Inventory Number";
            // 
            // lbl_Object
            // 
            this.lbl_Object.AutoSize = true;
            this.lbl_Object.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Object.Location = new System.Drawing.Point(12, 136);
            this.lbl_Object.Name = "lbl_Object";
            this.lbl_Object.Size = new System.Drawing.Size(77, 27);
            this.lbl_Object.TabIndex = 3;
            this.lbl_Object.Text = "Object";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(10, 244);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(71, 27);
            this.lbl_Count.TabIndex = 4;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(307, 244);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(66, 27);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(2, 67);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(129, 20);
            this.txt_Number.TabIndex = 6;
            // 
            // txt_Inventory
            // 
            this.txt_Inventory.Location = new System.Drawing.Point(440, 67);
            this.txt_Inventory.Name = "txt_Inventory";
            this.txt_Inventory.Size = new System.Drawing.Size(171, 20);
            this.txt_Inventory.TabIndex = 8;
            // 
            // txt_Object
            // 
            this.txt_Object.Location = new System.Drawing.Point(12, 183);
            this.txt_Object.Name = "txt_Object";
            this.txt_Object.Size = new System.Drawing.Size(429, 20);
            this.txt_Object.TabIndex = 9;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(15, 286);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 20);
            this.txt_Count.TabIndex = 10;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(310, 285);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 11;
            // 
            // DatePicker1
            // 
            this.DatePicker1.Location = new System.Drawing.Point(172, 67);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(200, 20);
            this.DatePicker1.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(118, 337);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(288, 337);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btn_Cancel;
    }
}
