namespace makihyppy3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jumpersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumpLenghtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuuliarvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuomari1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuomari2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuomari3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuomari4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuomari5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windPointsDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylePointsDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisteet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jumpersName,
            this.jumpLenghtdg,
            this.kPiste,
            this.tuuliarvo,
            this.tuomari1,
            this.tuomari2,
            this.tuomari3,
            this.tuomari4,
            this.tuomari5,
            this.windPointsDg,
            this.lenghtPoints,
            this.stylePointsDg,
            this.pisteet});
            this.dataGridView1.Location = new System.Drawing.Point(6, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // jumpersName
            // 
            this.jumpersName.Frozen = true;
            this.jumpersName.HeaderText = "Ski Jumper´s Name";
            this.jumpersName.MinimumWidth = 6;
            this.jumpersName.Name = "jumpersName";
            this.jumpersName.Width = 250;
            // 
            // jumpLenghtdg
            // 
            this.jumpLenghtdg.Frozen = true;
            this.jumpLenghtdg.HeaderText = "Lenght";
            this.jumpLenghtdg.MinimumWidth = 6;
            this.jumpLenghtdg.Name = "jumpLenghtdg";
            this.jumpLenghtdg.Width = 90;
            // 
            // kPiste
            // 
            this.kPiste.Frozen = true;
            this.kPiste.HeaderText = "K-point";
            this.kPiste.MinimumWidth = 6;
            this.kPiste.Name = "kPiste";
            this.kPiste.Width = 90;
            // 
            // tuuliarvo
            // 
            this.tuuliarvo.Frozen = true;
            this.tuuliarvo.HeaderText = "Wind";
            this.tuuliarvo.MinimumWidth = 6;
            this.tuuliarvo.Name = "tuuliarvo";
            this.tuuliarvo.Width = 90;
            // 
            // tuomari1
            // 
            this.tuomari1.Frozen = true;
            this.tuomari1.HeaderText = "Judge 1";
            this.tuomari1.MinimumWidth = 6;
            this.tuomari1.Name = "tuomari1";
            this.tuomari1.Width = 90;
            // 
            // tuomari2
            // 
            this.tuomari2.Frozen = true;
            this.tuomari2.HeaderText = "Judge 2";
            this.tuomari2.MinimumWidth = 6;
            this.tuomari2.Name = "tuomari2";
            this.tuomari2.Width = 90;
            // 
            // tuomari3
            // 
            this.tuomari3.Frozen = true;
            this.tuomari3.HeaderText = "Judge 3";
            this.tuomari3.MinimumWidth = 6;
            this.tuomari3.Name = "tuomari3";
            this.tuomari3.Width = 90;
            // 
            // tuomari4
            // 
            this.tuomari4.Frozen = true;
            this.tuomari4.HeaderText = "Judge 4";
            this.tuomari4.MinimumWidth = 6;
            this.tuomari4.Name = "tuomari4";
            this.tuomari4.Width = 90;
            // 
            // tuomari5
            // 
            this.tuomari5.Frozen = true;
            this.tuomari5.HeaderText = "Judge 5";
            this.tuomari5.MinimumWidth = 6;
            this.tuomari5.Name = "tuomari5";
            this.tuomari5.Width = 90;
            // 
            // windPointsDg
            // 
            this.windPointsDg.Frozen = true;
            this.windPointsDg.HeaderText = "Wind Points";
            this.windPointsDg.MinimumWidth = 6;
            this.windPointsDg.Name = "windPointsDg";
            this.windPointsDg.ReadOnly = true;
            this.windPointsDg.Width = 90;
            // 
            // lenghtPoints
            // 
            this.lenghtPoints.Frozen = true;
            this.lenghtPoints.HeaderText = "Lenght Points";
            this.lenghtPoints.MinimumWidth = 6;
            this.lenghtPoints.Name = "lenghtPoints";
            this.lenghtPoints.ReadOnly = true;
            this.lenghtPoints.Width = 90;
            // 
            // stylePointsDg
            // 
            this.stylePointsDg.HeaderText = "Style Points";
            this.stylePointsDg.MinimumWidth = 6;
            this.stylePointsDg.Name = "stylePointsDg";
            this.stylePointsDg.ReadOnly = true;
            this.stylePointsDg.Width = 90;
            // 
            // pisteet
            // 
            this.pisteet.HeaderText = "Total points";
            this.pisteet.MinimumWidth = 6;
            this.pisteet.Name = "pisteet";
            this.pisteet.ReadOnly = true;
            this.pisteet.Width = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(6, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ski Jumping Points Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Location = new System.Drawing.Point(1161, 480);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 42);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear all";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 560);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn jumpersName;
        private DataGridViewTextBoxColumn jumpLenghtdg;
        private DataGridViewTextBoxColumn kPiste;
        private DataGridViewTextBoxColumn tuuliarvo;
        private DataGridViewTextBoxColumn tuomari1;
        private DataGridViewTextBoxColumn tuomari2;
        private DataGridViewTextBoxColumn tuomari3;
        private DataGridViewTextBoxColumn tuomari4;
        private DataGridViewTextBoxColumn tuomari5;
        private DataGridViewTextBoxColumn windPointsDg;
        private DataGridViewTextBoxColumn lenghtPoints;
        private DataGridViewTextBoxColumn stylePointsDg;
        private DataGridViewTextBoxColumn pisteet;
        private Label label1;
        private Label label2;
        private Button buttonClear;
    }
}