﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_Decrypt.Enabled = false;
            btn_Encrypt.Enabled = false;
            btn_SavePrivateKey.Enabled = false;
            btn_SavePublicKey.Enabled = false;

            openFileDialog1.Filter = "XML files(*.xml)|*.xml";
            openFileDialog1.DefaultExt = "xml";

            saveFileDialog1.Filter = "XML files(*.xml)|*.xml";
            saveFileDialog1.DefaultExt = "xml";
        }
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        private string RSAPrivateKey = null;
        private string RSAPublicKey = null;
        byte[] cipherbytes;

        private void btn_CreateRSA_Click(object sender, EventArgs e)
        {
           
            //provide public and private RSA params
            RSAPrivateKey = rsa.ToXmlString(true);

            //provide public RSA params
            RSAPublicKey = rsa.ToXmlString(false);


            //display public and private RSA key
            textBoxPublicKeyXML.Text = RSAPrivateKey;

            btn_Encrypt.Enabled = true;
            btn_SavePrivateKey.Enabled = true;
            btn_SavePublicKey.Enabled = true;
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            //read plaintext, encrypt it to ciphertext
            byte[] plainbytes = Encoding.UTF8.GetBytes(textBox_en.Text);
            cipherbytes = rsa.Encrypt(plainbytes, false); //fOAEP needs high encryption pack

            //display ciphertext as text string
            //textCiphertext.Text = Encoding.UTF8.GetString(cipherbytes);

            //display ciphertext byte array in hex format
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cipherbytes.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", cipherbytes[i]));
            }
            textCipherbytes.Text = sb.ToString();

            btn_Decrypt.Enabled = true;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //read ciphertext, decrypt it to plaintext
                byte[] plainbytes = rsa.Decrypt(cipherbytes, false); //fOAEP needs high encryption pack

                textBox_de.Text = Encoding.UTF8.GetString(plainbytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LoadPrivateKey_Click(object sender, EventArgs e)
        {
            string path = "PrivateKey.xml";
            openFileDialog1.FileName = path;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                string key;
                using (StreamReader reader = new StreamReader(path))
                    key = reader.ReadToEnd();

                RSAPrivateKey = key;
                rsa.FromXmlString(RSAPrivateKey);
                textBoxPublicKeyXML.Text = RSAPrivateKey;
            }

            btn_Encrypt.Enabled = true;
            btn_SavePrivateKey.Enabled = true;
            btn_SavePublicKey.Enabled = true;
        }

        private void btn_LoadPublicKey_Click(object sender, EventArgs e)
        {
            string path = "PublicKey.xml";
            openFileDialog1.FileName = path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                string key;
                using (StreamReader reader = new StreamReader(path))
                    key = reader.ReadToEnd();

                RSAPublicKey = key;
                rsa.FromXmlString(RSAPublicKey);
                textBoxPublicKeyXML.Text = RSAPublicKey;
            }
            btn_Encrypt.Enabled = true;
            btn_SavePrivateKey.Enabled = true;
            btn_SavePublicKey.Enabled = true;
        }

        private void btn_SavePrivateKey_Click(object sender, EventArgs e)
        {
            string path = "PrivateKey.xml";
            saveFileDialog1.FileName = path;
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(path))
                    writer.Write(RSAPrivateKey);
            }
            
        }

        private void btn_SavePublicKey_Click(object sender, EventArgs e)
        {
            string path = "PublicKey.xml";
            saveFileDialog1.FileName = path;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(path))
                    writer.Write(RSAPublicKey);
            }
        }
    }
}
