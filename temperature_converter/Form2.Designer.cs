namespace temperature_converter
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 0;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(135, 182);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(94, 29);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(139, 67);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(203, 24);
            this.radioButtonFtoC.TabIndex = 2;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "From Fahrenheit to Celsius";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(138, 96);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(203, 24);
            this.radioButtonCtoF.TabIndex = 3;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "From Celsius to Fahrenheit";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(135, 232);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(247, 182);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 29);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button buttonCalc;
        private RadioButton radioButtonFtoC;
        private RadioButton radioButtonCtoF;
        private Button buttonClose;
        private Button buttonReturn;
    }
}