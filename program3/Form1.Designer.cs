
namespace program3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CreateRSA = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPublicKeyXML = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_en = new System.Windows.Forms.TextBox();
            this.btn_SavePrivateKey = new System.Windows.Forms.Button();
            this.btn_SavePublicKey = new System.Windows.Forms.Button();
            this.btn_LoadPublicKey = new System.Windows.Forms.Button();
            this.btn_LoadPrivateKey = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_de = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textCipherbytes = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CreateRSA
            // 
            this.btn_CreateRSA.Location = new System.Drawing.Point(12, 76);
            this.btn_CreateRSA.Name = "btn_CreateRSA";
            this.btn_CreateRSA.Size = new System.Drawing.Size(103, 23);
            this.btn_CreateRSA.TabIndex = 0;
            this.btn_CreateRSA.Text = "Create New RSA";
            this.btn_CreateRSA.UseVisualStyleBackColor = true;
            this.btn_CreateRSA.Click += new System.EventHandler(this.btn_CreateRSA_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPublicKeyXML);
            this.groupBox5.Location = new System.Drawing.Point(12, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(605, 176);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RSA Parameters";
            // 
            // textBoxPublicKeyXML
            // 
            this.textBoxPublicKeyXML.Location = new System.Drawing.Point(8, 24);
            this.textBoxPublicKeyXML.Multiline = true;
            this.textBoxPublicKeyXML.Name = "textBoxPublicKeyXML";
            this.textBoxPublicKeyXML.ReadOnly = true;
            this.textBoxPublicKeyXML.Size = new System.Drawing.Size(591, 146);
            this.textBoxPublicKeyXML.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_en);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 49);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // textBox_en
            // 
            this.textBox_en.Location = new System.Drawing.Point(6, 19);
            this.textBox_en.Name = "textBox_en";
            this.textBox_en.Size = new System.Drawing.Size(318, 20);
            this.textBox_en.TabIndex = 0;
            // 
            // btn_SavePrivateKey
            // 
            this.btn_SavePrivateKey.Location = new System.Drawing.Point(389, 9);
            this.btn_SavePrivateKey.Name = "btn_SavePrivateKey";
            this.btn_SavePrivateKey.Size = new System.Drawing.Size(103, 23);
            this.btn_SavePrivateKey.TabIndex = 20;
            this.btn_SavePrivateKey.Text = "Save Private Key";
            this.btn_SavePrivateKey.UseVisualStyleBackColor = true;
            this.btn_SavePrivateKey.Click += new System.EventHandler(this.btn_SavePrivateKey_Click);
            // 
            // btn_SavePublicKey
            // 
            this.btn_SavePublicKey.Location = new System.Drawing.Point(389, 38);
            this.btn_SavePublicKey.Name = "btn_SavePublicKey";
            this.btn_SavePublicKey.Size = new System.Drawing.Size(103, 23);
            this.btn_SavePublicKey.TabIndex = 21;
            this.btn_SavePublicKey.Text = "Save Public Key";
            this.btn_SavePublicKey.UseVisualStyleBackColor = true;
            this.btn_SavePublicKey.Click += new System.EventHandler(this.btn_SavePublicKey_Click);
            // 
            // btn_LoadPublicKey
            // 
            this.btn_LoadPublicKey.Location = new System.Drawing.Point(508, 38);
            this.btn_LoadPublicKey.Name = "btn_LoadPublicKey";
            this.btn_LoadPublicKey.Size = new System.Drawing.Size(103, 23);
            this.btn_LoadPublicKey.TabIndex = 23;
            this.btn_LoadPublicKey.Text = "Load Public Key";
            this.btn_LoadPublicKey.UseVisualStyleBackColor = true;
            this.btn_LoadPublicKey.Click += new System.EventHandler(this.btn_LoadPublicKey_Click);
            // 
            // btn_LoadPrivateKey
            // 
            this.btn_LoadPrivateKey.Location = new System.Drawing.Point(508, 9);
            this.btn_LoadPrivateKey.Name = "btn_LoadPrivateKey";
            this.btn_LoadPrivateKey.Size = new System.Drawing.Size(103, 23);
            this.btn_LoadPrivateKey.TabIndex = 22;
            this.btn_LoadPrivateKey.Text = "Load Private Key";
            this.btn_LoadPrivateKey.UseVisualStyleBackColor = true;
            this.btn_LoadPrivateKey.Click += new System.EventHandler(this.btn_LoadPrivateKey_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(282, 57);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(70, 23);
            this.btn_Encrypt.TabIndex = 24;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(282, 381);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(70, 23);
            this.btn_Decrypt.TabIndex = 26;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_de);
            this.groupBox2.Location = new System.Drawing.Point(22, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 49);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // textBox_de
            // 
            this.textBox_de.Location = new System.Drawing.Point(6, 19);
            this.textBox_de.Name = "textBox_de";
            this.textBox_de.Size = new System.Drawing.Size(318, 20);
            this.textBox_de.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textCipherbytes);
            this.groupBox4.Location = new System.Drawing.Point(12, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 88);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ciphertext Displayed as String";
            // 
            // textCipherbytes
            // 
            this.textCipherbytes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCipherbytes.Location = new System.Drawing.Point(10, 19);
            this.textCipherbytes.Multiline = true;
            this.textCipherbytes.Name = "textCipherbytes";
            this.textCipherbytes.ReadOnly = true;
            this.textCipherbytes.Size = new System.Drawing.Size(589, 56);
            this.textCipherbytes.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 482);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_LoadPublicKey);
            this.Controls.Add(this.btn_LoadPrivateKey);
            this.Controls.Add(this.btn_SavePublicKey);
            this.Controls.Add(this.btn_SavePrivateKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_CreateRSA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateRSA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPublicKeyXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_en;
        private System.Windows.Forms.Button btn_SavePrivateKey;
        private System.Windows.Forms.Button btn_SavePublicKey;
        private System.Windows.Forms.Button btn_LoadPublicKey;
        private System.Windows.Forms.Button btn_LoadPrivateKey;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_de;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textCipherbytes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

