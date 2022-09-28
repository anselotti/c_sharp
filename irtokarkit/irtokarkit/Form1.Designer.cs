namespace irtokarkit
{
    partial class Form1
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
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKg
            // 
            this.textBoxKg.Location = new System.Drawing.Point(46, 72);
            this.textBoxKg.Name = "textBoxKg";
            this.textBoxKg.Size = new System.Drawing.Size(125, 27);
            this.textBoxKg.TabIndex = 0;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(46, 153);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(125, 27);
            this.textBoxMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kilohinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Käytettävissä oleva rahamäärä";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(46, 199);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(94, 29);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Laske";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(46, 270);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(137, 20);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Rahalla saa karkkia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 362);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxKg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKg;
        private TextBox textBoxMoney;
        private Label label1;
        private Label label2;
        private Button buttonCalc;
        private Label labelSum;
    }
}