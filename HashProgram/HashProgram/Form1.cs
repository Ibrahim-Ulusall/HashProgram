using System.Linq.Expressions;
using System.Security.Cryptography;

namespace HashProgram
{
    public partial class Form1 : Form
    {
        public string sha1Hash, sha256Hash, md5Hash;
        public ToolTip toolTip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "MD5";
        }
        //MD5 DE�ER�N� HESAPLA
        private string CalculateMD5(string filePath)
        {
            MD5 md5 = MD5.Create();
            FileStream fileStream = File.OpenRead(filePath);

            byte[] hashValue = md5.ComputeHash(fileStream);

            fileStream.Close();
            md5.Dispose();

            return BitConverter.ToString(hashValue).Replace("-", String.Empty);
        }

        //SHA256 DE�ER�N� HESAPLA
        private string CalculateSHA256(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashValue = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashValue).Replace("-", String.Empty);
                }
            }
        }
        //SHA1 DE�ER�N� HESAPLA
        private string CalculateSHA1(string filePath)
        {
            SHA1 sha1 = SHA1.Create();
            FileStream fileStream = File.OpenRead(filePath);

            byte[] hashValue = sha1.ComputeHash(fileStream);

            fileStream.Close();
            sha1.Dispose();

            return BitConverter.ToString(hashValue).Replace("-", String.Empty);
        }
        //DOSYAYI S�STEME Y�KLEME
        private void FileUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                filePathTextBox.Text = selectedFilePath;

                // Dosyan�n SHA256 de�erini hesapla
                sha256Hash = CalculateSHA256(selectedFilePath);
                sha256ResultText.Text = sha256Hash;
                //Dosyan�n MD5 de�erini Hesapla
                md5Hash = CalculateMD5(selectedFilePath);
                Md5ResultText.Text = md5Hash;
                //Dosyan�n SHA1 de�erini hesapla
                sha1Hash = CalculateSHA1(selectedFilePath);
                Sha1ResultText.Text = sha1Hash;
                VisibleControls();
            }
        }
        private void VisibleControls()
        {
            SaveButton.Visible = true;
            CompareButton.Visible = true;
            md5CopyButton.Visible = true;
            sha1CopyButton.Visible = true;
            sha256CopyButton.Visible = true;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MD5")
            {
                if (UserHashTextBox.Text == md5Hash)
                {
                    resultText.Text = "Hash Uyu�uyor!";
                    resultText.Visible = true;
                }
                else
                {
                    resultText.Text = "Hash Uyu�muyor!";
                    resultText.Visible = true;
                }
            }
            else if (comboBox1.Text == "SHA1")
            {
                if (UserHashTextBox.Text == sha1Hash)
                {
                    resultText.Text = "Hash Uyu�uyor!";
                    resultText.Visible = true;
                }
                else
                {
                    resultText.Text = "Hash Uyu�muyor!";
                    resultText.Visible = true;
                }
            }
            else
            {
                if (UserHashTextBox.Text == sha256Hash)
                {
                    resultText.Text = "Hash Uyu�uyor!";
                    resultText.Visible = true;
                }
                else
                {
                    resultText.Text = "Hash Uyu�muyor!";
                    resultText.Visible = true;
                }
            }

        }

        private void Md5ResultText_MouseDown(object sender, MouseEventArgs e)
        {
            Md5ResultText.Focus();
        }

        private void md5CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Md5ResultText.Text);
        }

        private void sha256CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sha256ResultText.Text);
        }

        private void sha1CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Sha1ResultText.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter printer = new StreamWriter("result.txt");
            printer.WriteLine("MD5    : " + md5Hash);
            printer.WriteLine("SHA1   : " + sha1Hash);
            printer.WriteLine("SHA256 : " + sha256Hash);

            printer.Close();
            MessageBox.Show("Kay�t ��lemi Ba�ar�l�");
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip.SetToolTip(button1, "Geli�tirici : �brahim Ulusal");
        }

        private void FileUploadButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(FileUploadButton, "Hash De�eri Hesaplanack Dosya Y�kle");
        }
    }
}