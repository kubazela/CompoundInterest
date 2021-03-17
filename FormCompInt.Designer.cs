
namespace CompoundInterest {
    partial class FormCompInt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tBoxInitialSum = new System.Windows.Forms.TextBox();
            this.lbInitialSum = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMonthlyDeposit = new System.Windows.Forms.Label();
            this.tBoxMonthlyDep = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbInterRate = new System.Windows.Forms.Label();
            this.tBoxInterRate = new System.Windows.Forms.TextBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.tBoxCalc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxInitialSum
            // 
            this.tBoxInitialSum.Location = new System.Drawing.Point(188, 110);
            this.tBoxInitialSum.Name = "tBoxInitialSum";
            this.tBoxInitialSum.Size = new System.Drawing.Size(140, 20);
            this.tBoxInitialSum.TabIndex = 0;
            // 
            // lbInitialSum
            // 
            this.lbInitialSum.AutoSize = true;
            this.lbInitialSum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitialSum.Location = new System.Drawing.Point(14, 105);
            this.lbInitialSum.Name = "lbInitialSum";
            this.lbInitialSum.Size = new System.Drawing.Size(126, 25);
            this.lbInitialSum.TabIndex = 1;
            this.lbInitialSum.Text = "Initial deposit";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(181, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(368, 37);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Compound interest calculator";
            // 
            // lbMonthlyDeposit
            // 
            this.lbMonthlyDeposit.AutoSize = true;
            this.lbMonthlyDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthlyDeposit.Location = new System.Drawing.Point(14, 159);
            this.lbMonthlyDeposit.Name = "lbMonthlyDeposit";
            this.lbMonthlyDeposit.Size = new System.Drawing.Size(149, 25);
            this.lbMonthlyDeposit.TabIndex = 3;
            this.lbMonthlyDeposit.Text = "Monthly deposit";
            // 
            // tBoxMonthlyDep
            // 
            this.tBoxMonthlyDep.Location = new System.Drawing.Point(188, 165);
            this.tBoxMonthlyDep.Name = "tBoxMonthlyDep";
            this.tBoxMonthlyDep.Size = new System.Drawing.Size(140, 20);
            this.tBoxMonthlyDep.TabIndex = 4;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(14, 214);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(56, 25);
            this.lbYear.TabIndex = 5;
            this.lbYear.Text = "Years";
            // 
            // lbInterRate
            // 
            this.lbInterRate.AutoSize = true;
            this.lbInterRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterRate.Location = new System.Drawing.Point(14, 264);
            this.lbInterRate.Name = "lbInterRate";
            this.lbInterRate.Size = new System.Drawing.Size(113, 25);
            this.lbInterRate.TabIndex = 9;
            this.lbInterRate.Text = "Interest rate";
            // 
            // tBoxInterRate
            // 
            this.tBoxInterRate.Location = new System.Drawing.Point(188, 270);
            this.tBoxInterRate.Name = "tBoxInterRate";
            this.tBoxInterRate.Size = new System.Drawing.Size(69, 20);
            this.tBoxInterRate.TabIndex = 10;
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btCalc.Location = new System.Drawing.Point(107, 331);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(181, 33);
            this.btCalc.TabIndex = 11;
            this.btCalc.Text = "Calculate";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(188, 219);
            this.numYear.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(69, 20);
            this.numYear.TabIndex = 12;
            this.numYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBoxCalc
            // 
            this.tBoxCalc.Location = new System.Drawing.Point(440, 105);
            this.tBoxCalc.Name = "tBoxCalc";
            this.tBoxCalc.Size = new System.Drawing.Size(273, 259);
            this.tBoxCalc.TabIndex = 13;
            this.tBoxCalc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 402);
            this.Controls.Add(this.tBoxCalc);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.tBoxInterRate);
            this.Controls.Add(this.lbInterRate);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.tBoxMonthlyDep);
            this.Controls.Add(this.lbMonthlyDeposit);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbInitialSum);
            this.Controls.Add(this.tBoxInitialSum);
            this.Name = "Form1";
            this.Text = "Compound Interest";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxInitialSum;
        private System.Windows.Forms.Label lbInitialSum;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMonthlyDeposit;
        private System.Windows.Forms.TextBox tBoxMonthlyDep;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbInterRate;
        private System.Windows.Forms.TextBox tBoxInterRate;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.RichTextBox tBoxCalc;
    }
}

