using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MaterialSkin.Controls;
//using MaterialSkin.Animations;
using System.Security.Cryptography;

namespace Test_Encryption
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text File(*.txt*)|*.txt*| Word Document(*.docx)|*.docx*| All Files(*.*)|*.*";
            openFile.Title = "Browse File...";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelFileName.Text = openFile.FileName;
                //read the file to text box
                StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                textArea.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void encyptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Encrypt";
            buttonProcess.Text = "Encrypt";
        }

        private void decryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Decrypt";
            buttonProcess.Text = "Decrypt";
            buttonProcess.BackColor = Color.Lime;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textArea.Text != "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text File(*.txt*)|*.txt*|Crypto File(*.ncr*)|*.ncr* | Word Document(*.docx)|*.docx* | All Files(*.*)|*.*";
                saveFile.Title = "Save As...";
                saveFile.DefaultExt = "txt";
                saveFile.AddExtension = true;

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    //write to file
                    StreamWriter write = new StreamWriter(File.Create(saveFile.FileName));



                    write.Write(textArea.Text);
                    write.Dispose();
                    labelSaveMsg.Visible = true;
                    labelSaveMsg.Text = "File Save Success!";
                    textArea.Text = "";
                    textBoxKey.Text = "";

                }
            }
            else{
                labelSaveMsg.Visible = true;
                labelSaveMsg.Text = "File is blank";
                labelSaveMsg.ForeColor = Color.Maroon;

                
            }

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private string Encrypt(string clearText)//Method To Encrypt
        {
            String EncryptionKey = textBoxKey.Text;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes AESalgorithm = Aes.Create())//
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, 
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                AESalgorithm.Key = pdb.GetBytes(32);
                AESalgorithm.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptostream = new CryptoStream(ms, AESalgorithm.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptostream.Write(clearBytes, 0, clearBytes.Length);
                        cryptostream.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            try
            {
                    String EncryptionKey = textBoxKey.Text;
                    byte[] cipherBytes = Convert.FromBase64String(cipherText);



                using (Aes AESalgorithm = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
                        new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                    AESalgorithm.Key = pdb.GetBytes(32);
                    AESalgorithm.IV = pdb.GetBytes(16);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cryptoSteam = new CryptoStream(ms, AESalgorithm.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoSteam.Write(cipherBytes, 0, cipherBytes.Length);
                            cryptoSteam.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                if (MessageBox.Show("Keys Don't Match, Try Again With The Right Key", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ==
                    DialogResult.OK) { }
            }

            return cipherText;
        }

        public void AnimateProgress(int milliseconds)
        {
            progressBar1.Value = 0;
            timer1.Interval = milliseconds / 100;
            timer1.Enabled = true;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {

            
            if (labelTitle.Text == "Encrypt" && textBoxKey.Text != "")//Option to Enccrypt
            {
                if (MessageBox.Show("File Will Be Encrypted!, Continue?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes) 
                {
                      
                        String encryptedText;
                        encryptedText = this.Encrypt(textArea.Text.Trim());
                        textArea.Text = encryptedText;
                        textBoxKey.Text = "";
                        labelEncyptAlert.Text = "File Encrypted Succesfully!";
                        labelFileName.Visible = true;
                } 


            }
            else if (labelTitle.Text == "Decrypt" && textBoxKey.Text != "")
            {
                String cipheredText;
                cipheredText = this.Decrypt(textArea.Text.Trim());
                textArea.Text = cipheredText;
                textBoxKey.Text = "";
                labelEncyptAlert.Text = "File Decrypted Succesfully!";
                labelFileName.Visible = true;
                buttonProcess.BackColor = Color.Gray;


            }
            else
            {
                if (MessageBox.Show("Please Enter Key To Decrypt!!", "Key Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation)==
                    DialogResult.OK) { }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text File(*.txt*)|*.txt*| Word Document(*.docx)|*.docx*";
            openFile.Title = "Browse File...";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelFileName.Text = openFile.FileName;
                //read the file to text box
                StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                textArea.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.Text != "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text File(*.txt*)|*.txt*| Word Document(*.docx)|*.docx*";
                saveFile.Title = "Save As...";

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    //write to file
                    StreamWriter write = new StreamWriter(File.Create(saveFile.FileName));



                    write.Write(textArea.Text);
                    write.Dispose();
                    labelSaveMsg.Visible = true;
                    labelSaveMsg.Text = "File Save Success!";
                    textArea.Text = "";
                    textBoxKey.Text = "";

                }
            }
            else
            {
                labelSaveMsg.Visible = true;
                labelSaveMsg.Text = "File is blank";
                labelSaveMsg.ForeColor = Color.Maroon;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {

                labelProgresslevel.Text = Convert.ToString(progressBar1.Value += 1) + " %";
                progressBar1.Refresh();

            }
            else
            {
                timer1.Enabled = false;
            }
        }



        //------------------------background worker stuff----------------------------------//

    }
}
