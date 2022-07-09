namespace csharp_Assignment4
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
            this.lblManagement = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Field = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.txt_Field = new System.Windows.Forms.TextBox();
            this.lbl_DOR = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.Location = new System.Drawing.Point(193, 30);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(260, 24);
            this.lblManagement.TabIndex = 0;
            this.lblManagement.Text = "HILCoE Student Management";
            this.lblManagement.Click += new System.EventHandler(this.lblManagement_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(24, 99);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(24, 205);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(63, 20);
            this.lbl_Gender.TabIndex = 2;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Field
            // 
            this.lbl_Field.AutoSize = true;
            this.lbl_Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Field.Location = new System.Drawing.Point(458, 99);
            this.lbl_Field.Name = "lbl_Field";
            this.lbl_Field.Size = new System.Drawing.Size(43, 20);
            this.lbl_Field.TabIndex = 3;
            this.lbl_Field.Text = "Field";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(164, 349);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(438, 349);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_DatePicker
            // 
            this.txt_DatePicker.Location = new System.Drawing.Point(271, 290);
            this.txt_DatePicker.Name = "txt_DatePicker";
            this.txt_DatePicker.Size = new System.Drawing.Size(200, 20);
            this.txt_DatePicker.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(164, 99);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Gender
            // 
            this.txt_Gender.Location = new System.Drawing.Point(164, 205);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(100, 20);
            this.txt_Gender.TabIndex = 8;
            // 
            // txt_Field
            // 
            this.txt_Field.Location = new System.Drawing.Point(438, 154);
            this.txt_Field.Name = "txt_Field";
            this.txt_Field.Size = new System.Drawing.Size(100, 20);
            this.txt_Field.TabIndex = 9;
            // 
            // lbl_DOR
            // 
            this.lbl_DOR.AutoSize = true;
            this.lbl_DOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOR.Location = new System.Drawing.Point(50, 291);
            this.lbl_DOR.Name = "lbl_DOR";
            this.lbl_DOR.Size = new System.Drawing.Size(164, 20);
            this.lbl_DOR.TabIndex = 10;
            this.lbl_DOR.Text = "Date Of Registeration";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(38, 154);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(26, 20);
            this.lbl_Id.TabIndex = 11;
            this.lbl_Id.Text = "ID";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(164, 154);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_DOR);
            this.Controls.Add(this.txt_Field);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_DatePicker);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_Field);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lblManagement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Field;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker txt_DatePicker;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Gender;
        private System.Windows.Forms.TextBox txt_Field;
        private System.Windows.Forms.Label lbl_DOR;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
    }
}

