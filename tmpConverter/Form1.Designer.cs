namespace tmpConverter
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
            this.buttonConv = new System.Windows.Forms.Button();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConv
            // 
            this.buttonConv.Location = new System.Drawing.Point(12, 163);
            this.buttonConv.Name = "buttonConv";
            this.buttonConv.Size = new System.Drawing.Size(94, 29);
            this.buttonConv.TabIndex = 0;
            this.buttonConv.Text = "Convert";
            this.buttonConv.UseVisualStyleBackColor = true;
            this.buttonConv.Click += new System.EventHandler(this.buttonConv_Click);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(114, 122);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(93, 27);
            this.textBoxTemp.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(114, 164);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(93, 27);
            this.textBoxResult.TabIndex = 2;
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(14, 53);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(165, 24);
            this.radioButtonFtoC.TabIndex = 3;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "Fahrenheit to Celsius";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(14, 83);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(165, 24);
            this.radioButtonCtoF.TabIndex = 4;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "Celsius to Fahrenheit";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperature Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.buttonConv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConv;
        private TextBox textBoxTemp;
        private TextBox textBoxResult;
        private RadioButton radioButtonFtoC;
        private RadioButton radioButtonCtoF;
        private Label label1;
        private Label label2;
    }
}