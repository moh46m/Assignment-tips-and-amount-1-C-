namespace Assigment_Tips_amount1
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipsAmount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceFood1 = new System.Windows.Forms.TextBox();
            this.txtFood2 = new System.Windows.Forms.TextBox();
            this.txtPriceFood2 = new System.Windows.Forms.TextBox();
            this.txtFood1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Enter Tips Amount:";
            // 
            // txtTipsAmount
            // 
            this.txtTipsAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipsAmount.Location = new System.Drawing.Point(437, 205);
            this.txtTipsAmount.Name = "txtTipsAmount";
            this.txtTipsAmount.Size = new System.Drawing.Size(322, 19);
            this.txtTipsAmount.TabIndex = 59;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Limelight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(560, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 49);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Limelight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(348, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 49);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 462);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(251, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Total Net Amount :";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(397, 459);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(321, 26);
            this.txtNetAmount.TabIndex = 55;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Limelight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(132, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 49);
            this.btnCalculate.TabIndex = 54;
            this.btnCalculate.Text = "Calculate The Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Total Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tips amount : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Sales Text is :";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(397, 318);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(321, 26);
            this.txtSalesTax.TabIndex = 50;
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(397, 368);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.ReadOnly = true;
            this.txtTipAmount.Size = new System.Drawing.Size(321, 26);
            this.txtTipAmount.TabIndex = 49;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(397, 413);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(321, 26);
            this.txtTotalAmount.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Enter Price Food 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Enter Name Food 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Enter Price Food 1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Limelight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Enter Name Food 1 :";
            // 
            // txtPriceFood1
            // 
            this.txtPriceFood1.Location = new System.Drawing.Point(437, 69);
            this.txtPriceFood1.Name = "txtPriceFood1";
            this.txtPriceFood1.Size = new System.Drawing.Size(322, 26);
            this.txtPriceFood1.TabIndex = 43;
            // 
            // txtFood2
            // 
            this.txtFood2.Location = new System.Drawing.Point(437, 119);
            this.txtFood2.Name = "txtFood2";
            this.txtFood2.Size = new System.Drawing.Size(322, 26);
            this.txtFood2.TabIndex = 42;
            // 
            // txtPriceFood2
            // 
            this.txtPriceFood2.Location = new System.Drawing.Point(437, 164);
            this.txtPriceFood2.Name = "txtPriceFood2";
            this.txtPriceFood2.Size = new System.Drawing.Size(322, 26);
            this.txtPriceFood2.TabIndex = 41;
            // 
            // txtFood1
            // 
            this.txtFood1.Location = new System.Drawing.Point(437, 23);
            this.txtFood1.Name = "txtFood1";
            this.txtFood1.Size = new System.Drawing.Size(322, 26);
            this.txtFood1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 515);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTipsAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceFood1);
            this.Controls.Add(this.txtFood2);
            this.Controls.Add(this.txtPriceFood2);
            this.Controls.Add(this.txtFood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipsAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceFood1;
        private System.Windows.Forms.TextBox txtFood2;
        private System.Windows.Forms.TextBox txtPriceFood2;
        private System.Windows.Forms.TextBox txtFood1;
    }
}

