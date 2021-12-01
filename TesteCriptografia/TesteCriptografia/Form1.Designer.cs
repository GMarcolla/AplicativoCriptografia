namespace TesteCriptografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEscolherDocumento = new System.Windows.Forms.Button();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEscolherDocumento
            // 
            this.btnEscolherDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolherDocumento.Image")));
            this.btnEscolherDocumento.Location = new System.Drawing.Point(12, 12);
            this.btnEscolherDocumento.Name = "btnEscolherDocumento";
            this.btnEscolherDocumento.Size = new System.Drawing.Size(38, 34);
            this.btnEscolherDocumento.TabIndex = 0;
            this.btnEscolherDocumento.UseVisualStyleBackColor = true;
            this.btnEscolherDocumento.Click += new System.EventHandler(this.btnEscolherDocumento_Click);
            // 
            // txDocumento
            // 
            this.txDocumento.Enabled = false;
            this.txDocumento.Location = new System.Drawing.Point(56, 23);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(504, 23);
            this.txDocumento.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decriptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DES",
            "3-DES",
            "AES"});
            this.comboBox1.Location = new System.Drawing.Point(222, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 124);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.btnEscolherDocumento);
            this.Name = "Form1";
            this.Text = "Aplicativo Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnEscolherDocumento;
        private TextBox txDocumento;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
    }
}