﻿namespace DBMS_FitnessTracker
{
    partial class DietMaster
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
            this.ADDNEW = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.RichTextBox();
            this.fat = new System.Windows.Forms.RichTextBox();
            this.vit = new System.Windows.Forms.RichTextBox();
            this.prot = new System.Windows.Forms.RichTextBox();
            this.carbo = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.RadioButton();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.DietName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ADDNEW.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADDNEW
            // 
            this.ADDNEW.Controls.Add(this.Save);
            this.ADDNEW.Controls.Add(this.groupBox2);
            this.ADDNEW.Controls.Add(this.No);
            this.ADDNEW.Controls.Add(this.Yes);
            this.ADDNEW.Controls.Add(this.DietName);
            this.ADDNEW.Controls.Add(this.label4);
            this.ADDNEW.Controls.Add(this.label1);
            this.ADDNEW.Location = new System.Drawing.Point(11, 11);
            this.ADDNEW.Margin = new System.Windows.Forms.Padding(2);
            this.ADDNEW.Name = "ADDNEW";
            this.ADDNEW.Padding = new System.Windows.Forms.Padding(2);
            this.ADDNEW.Size = new System.Drawing.Size(661, 665);
            this.ADDNEW.TabIndex = 1;
            this.ADDNEW.TabStop = false;
            this.ADDNEW.Text = "ADD NEW";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Save.Location = new System.Drawing.Point(463, 306);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 60);
            this.Save.TabIndex = 2;
            this.Save.Text = "Add This Food";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cal);
            this.groupBox2.Controls.Add(this.fat);
            this.groupBox2.Controls.Add(this.vit);
            this.groupBox2.Controls.Add(this.prot);
            this.groupBox2.Controls.Add(this.carbo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(34, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 384);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Calories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(27, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nutrient Per Serving";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(169, 218);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(91, 32);
            this.cal.TabIndex = 21;
            this.cal.Text = "";
            // 
            // fat
            // 
            this.fat.Location = new System.Drawing.Point(169, 174);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(44, 32);
            this.fat.TabIndex = 19;
            this.fat.Text = "";
            // 
            // vit
            // 
            this.vit.Location = new System.Drawing.Point(169, 128);
            this.vit.Name = "vit";
            this.vit.Size = new System.Drawing.Size(44, 32);
            this.vit.TabIndex = 17;
            this.vit.Text = "";
            // 
            // prot
            // 
            this.prot.Location = new System.Drawing.Point(169, 92);
            this.prot.Name = "prot";
            this.prot.Size = new System.Drawing.Size(44, 32);
            this.prot.TabIndex = 15;
            this.prot.Text = "";
            // 
            // carbo
            // 
            this.carbo.Location = new System.Drawing.Point(169, 40);
            this.carbo.Name = "carbo";
            this.carbo.Size = new System.Drawing.Size(44, 32);
            this.carbo.TabIndex = 13;
            this.carbo.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vitamins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Protein";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carbohydrates";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(208, 148);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(54, 24);
            this.No.TabIndex = 6;
            this.No.TabStop = true;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(208, 102);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(62, 24);
            this.Yes.TabIndex = 5;
            this.Yes.TabStop = true;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // DietName
            // 
            this.DietName.Location = new System.Drawing.Point(208, 46);
            this.DietName.Margin = new System.Windows.Forms.Padding(2);
            this.DietName.Name = "DietName";
            this.DietName.Size = new System.Drawing.Size(112, 26);
            this.DietName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "JUNK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diet Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(718, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 650);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing";
            // 
            // DietMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 734);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ADDNEW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DietMaster";
            this.Text = "DietMaster";
            this.Load += new System.EventHandler(this.DietMaster_Load);
            this.ADDNEW.ResumeLayout(false);
            this.ADDNEW.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ADDNEW;
        private System.Windows.Forms.TextBox DietName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox cal;
        private System.Windows.Forms.RichTextBox fat;
        private System.Windows.Forms.RichTextBox vit;
        private System.Windows.Forms.RichTextBox prot;
        private System.Windows.Forms.RichTextBox carbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}