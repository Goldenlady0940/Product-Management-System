namespace CSharp_Assignment4
{
    partial class Product_Detail
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Number, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Inventory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Price, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Count, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(76, 34);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(258, 34);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(44, 13);
            this.lbl_Number.TabIndex = 1;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Location = new System.Drawing.Point(442, 34);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(51, 13);
            this.lbl_Inventory.TabIndex = 2;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(78, 115);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(265, 115);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Count
            // 
            this.lbl_Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(450, 115);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(35, 13);
            this.lbl_Count.TabIndex = 5;
            this.lbl_Count.Text = "Count";
            // 
            // Product_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Product_Detail";
            this.Text = "Product_Detail";
            this.Load += new System.EventHandler(this.Product_Detail_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Count;
    }
}