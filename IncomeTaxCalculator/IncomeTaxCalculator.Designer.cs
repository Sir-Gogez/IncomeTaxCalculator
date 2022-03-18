
namespace Exercide2Exam1Final
{
    partial class IncomeTaxCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.txtIncomeTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Location = new System.Drawing.Point(47, 43);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(115, 20);
            this.lblTaxableIncome.TabIndex = 0;
            this.lblTaxableIncome.Text = "&Taxable Income:";
            this.lblTaxableIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(206, 40);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(125, 27);
            this.txtTaxableIncome.TabIndex = 1;
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(47, 112);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(126, 20);
            this.lblIncomeTaxOwed.TabIndex = 2;
            this.lblIncomeTaxOwed.Text = "Income tax owed:";
            this.lblIncomeTaxOwed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIncomeTaxOwed
            // 
            this.txtIncomeTaxOwed.Location = new System.Drawing.Point(206, 109);
            this.txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            this.txtIncomeTaxOwed.ReadOnly = true;
            this.txtIncomeTaxOwed.Size = new System.Drawing.Size(125, 27);
            this.txtIncomeTaxOwed.TabIndex = 3;
            this.txtIncomeTaxOwed.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(319, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IncomeTaxCalculatorForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(460, 219);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIncomeTaxOwed);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblTaxableIncome);
            this.Name = "IncomeTaxCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.TextBox txtIncomeTaxOwed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

