namespace k_nn
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
            this.yazdirBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.egitimBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSutunS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yazdirBtn
            // 
            this.yazdirBtn.Location = new System.Drawing.Point(32, 133);
            this.yazdirBtn.Name = "yazdirBtn";
            this.yazdirBtn.Size = new System.Drawing.Size(282, 27);
            this.yazdirBtn.TabIndex = 1;
            this.yazdirBtn.Text = "Yazdir";
            this.yazdirBtn.UseVisualStyleBackColor = true;
            this.yazdirBtn.Click += new System.EventHandler(this.yazdirBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(879, 321);
            this.dataGridView1.TabIndex = 3;
            // 
            // egitimBtn
            // 
            this.egitimBtn.Location = new System.Drawing.Point(32, 98);
            this.egitimBtn.Name = "egitimBtn";
            this.egitimBtn.Size = new System.Drawing.Size(136, 23);
            this.egitimBtn.TabIndex = 4;
            this.egitimBtn.Text = "Eğitim Verisi";
            this.egitimBtn.UseVisualStyleBackColor = true;
            this.egitimBtn.Click += new System.EventHandler(this.egitimBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(178, 97);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(136, 23);
            this.testBtn.TabIndex = 5;
            this.testBtn.Text = "Test Verisi";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oklit",
            "Manhattan",
            "Minkovski"});
            this.comboBox1.Location = new System.Drawing.Point(178, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uzunluk Hesapla Yöntemi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "k:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 9;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(333, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(578, 142);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sutun Sayısı :";
            // 
            // textBoxSutunS
            // 
            this.textBoxSutunS.Location = new System.Drawing.Point(178, 18);
            this.textBoxSutunS.Name = "textBoxSutunS";
            this.textBoxSutunS.Size = new System.Drawing.Size(136, 20);
            this.textBoxSutunS.TabIndex = 13;
            this.textBoxSutunS.Text = "6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 499);
            this.Controls.Add(this.textBoxSutunS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.egitimBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yazdirBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yazdirBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button egitimBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSutunS;
        public System.Windows.Forms.ListView listView2;
    }
}

