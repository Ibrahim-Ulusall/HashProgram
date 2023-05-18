namespace HashProgram
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
            panel1 = new Panel();
            minimizeButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            CloseButton = new Button();
            FileUploadButton = new Button();
            filePathTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            sha256CopyButton = new Button();
            sha1CopyButton = new Button();
            md5CopyButton = new Button();
            sha256ResultText = new Label();
            Sha1ResultText = new Label();
            Md5ResultText = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SaveButton = new Button();
            CompareButton = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            resultText = new Label();
            comboBox1 = new ComboBox();
            UserHashTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 49);
            panel1.TabIndex = 0;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.MediumSeaGreen;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.FlatAppearance.BorderColor = Color.White;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(1084, 7);
            minimizeButton.Margin = new Padding(4);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(35, 35);
            minimizeButton.TabIndex = 7;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 5;
            label2.Text = "Hash Calculate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.MediumSeaGreen;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderColor = Color.White;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.White;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(1127, 7);
            CloseButton.Margin = new Padding(4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 35);
            CloseButton.TabIndex = 6;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // FileUploadButton
            // 
            FileUploadButton.BackColor = Color.MediumSeaGreen;
            FileUploadButton.Cursor = Cursors.Hand;
            FileUploadButton.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            FileUploadButton.FlatStyle = FlatStyle.Flat;
            FileUploadButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileUploadButton.ForeColor = Color.White;
            FileUploadButton.Image = (Image)resources.GetObject("FileUploadButton.Image");
            FileUploadButton.Location = new Point(619, 100);
            FileUploadButton.Margin = new Padding(4);
            FileUploadButton.Name = "FileUploadButton";
            FileUploadButton.Size = new Size(47, 33);
            FileUploadButton.TabIndex = 2;
            FileUploadButton.TextAlign = ContentAlignment.MiddleRight;
            FileUploadButton.UseVisualStyleBackColor = false;
            FileUploadButton.Click += FileUploadButton_Click;
            FileUploadButton.MouseHover += FileUploadButton_MouseHover;
            // 
            // filePathTextBox
            // 
            filePathTextBox.BackColor = Color.White;
            filePathTextBox.Location = new Point(137, 100);
            filePathTextBox.Margin = new Padding(4);
            filePathTextBox.Multiline = true;
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.ReadOnly = true;
            filePathTextBox.Size = new Size(474, 33);
            filePathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
            label1.TabIndex = 4;
            label1.Text = "Dosya Yolu : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sha256CopyButton);
            groupBox1.Controls.Add(sha1CopyButton);
            groupBox1.Controls.Add(md5CopyButton);
            groupBox1.Controls.Add(sha256ResultText);
            groupBox1.Controls.Add(Sha1ResultText);
            groupBox1.Controls.Add(Md5ResultText);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 330);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sonuçlar";
            // 
            // sha256CopyButton
            // 
            sha256CopyButton.BackColor = Color.Transparent;
            sha256CopyButton.Cursor = Cursors.Hand;
            sha256CopyButton.FlatAppearance.BorderColor = Color.White;
            sha256CopyButton.FlatAppearance.BorderSize = 0;
            sha256CopyButton.FlatStyle = FlatStyle.Flat;
            sha256CopyButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sha256CopyButton.ForeColor = Color.White;
            sha256CopyButton.Image = (Image)resources.GetObject("sha256CopyButton.Image");
            sha256CopyButton.Location = new Point(141, 196);
            sha256CopyButton.Margin = new Padding(4);
            sha256CopyButton.Name = "sha256CopyButton";
            sha256CopyButton.Size = new Size(25, 25);
            sha256CopyButton.TabIndex = 13;
            sha256CopyButton.UseVisualStyleBackColor = false;
            sha256CopyButton.Visible = false;
            sha256CopyButton.Click += sha256CopyButton_Click;
            // 
            // sha1CopyButton
            // 
            sha1CopyButton.BackColor = Color.Transparent;
            sha1CopyButton.Cursor = Cursors.Hand;
            sha1CopyButton.FlatAppearance.BorderColor = Color.White;
            sha1CopyButton.FlatAppearance.BorderSize = 0;
            sha1CopyButton.FlatStyle = FlatStyle.Flat;
            sha1CopyButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sha1CopyButton.ForeColor = Color.White;
            sha1CopyButton.Image = (Image)resources.GetObject("sha1CopyButton.Image");
            sha1CopyButton.Location = new Point(122, 129);
            sha1CopyButton.Margin = new Padding(4);
            sha1CopyButton.Name = "sha1CopyButton";
            sha1CopyButton.Size = new Size(25, 25);
            sha1CopyButton.TabIndex = 12;
            sha1CopyButton.UseVisualStyleBackColor = false;
            sha1CopyButton.Visible = false;
            sha1CopyButton.Click += sha1CopyButton_Click;
            // 
            // md5CopyButton
            // 
            md5CopyButton.BackColor = Color.Transparent;
            md5CopyButton.Cursor = Cursors.Hand;
            md5CopyButton.FlatAppearance.BorderColor = Color.White;
            md5CopyButton.FlatAppearance.BorderSize = 0;
            md5CopyButton.FlatStyle = FlatStyle.Flat;
            md5CopyButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            md5CopyButton.ForeColor = Color.White;
            md5CopyButton.Image = (Image)resources.GetObject("md5CopyButton.Image");
            md5CopyButton.Location = new Point(122, 55);
            md5CopyButton.Margin = new Padding(4);
            md5CopyButton.Name = "md5CopyButton";
            md5CopyButton.Size = new Size(25, 25);
            md5CopyButton.TabIndex = 7;
            md5CopyButton.UseVisualStyleBackColor = false;
            md5CopyButton.Visible = false;
            md5CopyButton.Click += md5CopyButton_Click;
            // 
            // sha256ResultText
            // 
            sha256ResultText.AutoSize = true;
            sha256ResultText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sha256ResultText.ForeColor = Color.MediumSeaGreen;
            sha256ResultText.Location = new Point(32, 235);
            sha256ResultText.Margin = new Padding(4, 0, 4, 0);
            sha256ResultText.Name = "sha256ResultText";
            sha256ResultText.Size = new Size(0, 20);
            sha256ResultText.TabIndex = 11;
            // 
            // Sha1ResultText
            // 
            Sha1ResultText.AutoSize = true;
            Sha1ResultText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Sha1ResultText.ForeColor = Color.MediumSeaGreen;
            Sha1ResultText.Location = new Point(32, 170);
            Sha1ResultText.Margin = new Padding(4, 0, 4, 0);
            Sha1ResultText.Name = "Sha1ResultText";
            Sha1ResultText.Size = new Size(0, 20);
            Sha1ResultText.TabIndex = 10;
            // 
            // Md5ResultText
            // 
            Md5ResultText.AutoSize = true;
            Md5ResultText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Md5ResultText.ForeColor = Color.MediumSeaGreen;
            Md5ResultText.Location = new Point(32, 92);
            Md5ResultText.Margin = new Padding(4, 0, 4, 0);
            Md5ResultText.Name = "Md5ResultText";
            Md5ResultText.Size = new Size(0, 20);
            Md5ResultText.TabIndex = 9;
            Md5ResultText.MouseDown += Md5ResultText_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 8;
            label5.Text = "MD5 Değeri : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 134);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "SHA1 Değeri : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 201);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 6;
            label3.Text = "SHA256 Değeri : ";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.MediumSeaGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderColor = Color.White;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.ImageAlign = ContentAlignment.MiddleRight;
            SaveButton.Location = new Point(203, 410);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(125, 37);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "     Kaydet";
            SaveButton.TextAlign = ContentAlignment.MiddleLeft;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CompareButton
            // 
            CompareButton.BackColor = Color.MediumSeaGreen;
            CompareButton.Cursor = Cursors.Hand;
            CompareButton.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            CompareButton.FlatStyle = FlatStyle.Flat;
            CompareButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CompareButton.ForeColor = Color.White;
            CompareButton.Image = (Image)resources.GetObject("CompareButton.Image");
            CompareButton.ImageAlign = ContentAlignment.MiddleRight;
            CompareButton.Location = new Point(336, 410);
            CompareButton.Margin = new Padding(4);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(125, 37);
            CompareButton.TabIndex = 6;
            CompareButton.Text = "Karşılaştır";
            CompareButton.TextAlign = ContentAlignment.MiddleLeft;
            CompareButton.UseVisualStyleBackColor = false;
            CompareButton.Visible = false;
            CompareButton.Click += CompareButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(137, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(258, 16);
            label6.TabIndex = 12;
            label6.Text = "Dosya boyutu büyükse bu biraz zaman alabilir.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(resultText);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(UserHashTextBox);
            groupBox2.Controls.Add(SaveButton);
            groupBox2.Controls.Add(CompareButton);
            groupBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(694, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 454);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kontrol Et";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(438, 13);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.MouseHover += button1_MouseHover;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(15, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(362, 48);
            label7.TabIndex = 13;
            label7.Text = "Bu alana kontrol edilecek olan hash değerini girmeniz \r\nve hangi hash olduğunu seçmeniz yeterlidir. \r\nHash değerleri sistem tarafından otomatik olarak kontrol edilecektir.";
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultText.Location = new Point(66, 253);
            resultText.Margin = new Padding(4, 0, 4, 0);
            resultText.Name = "resultText";
            resultText.Size = new Size(77, 33);
            resultText.TabIndex = 9;
            resultText.Text = "Hash";
            resultText.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MD5", "SHA1", "SHA256" });
            comboBox1.Location = new Point(385, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(77, 28);
            comboBox1.TabIndex = 8;
            // 
            // UserHashTextBox
            // 
            UserHashTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserHashTextBox.Location = new Point(15, 94);
            UserHashTextBox.Multiline = true;
            UserHashTextBox.Name = "UserHashTextBox";
            UserHashTextBox.PlaceholderText = "Kontrol Edilecek Hash";
            UserHashTextBox.Size = new Size(367, 110);
            UserHashTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 522);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(filePathTextBox);
            Controls.Add(FileUploadButton);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HashProgram";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button FileUploadButton;
        private TextBox filePathTextBox;
        private Label label1;
        private Button CloseButton;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label sha256ResultText;
        private Label Sha1ResultText;
        private Label Md5ResultText;
        private Button SaveButton;
        private Button CompareButton;
        private Label label6;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private TextBox UserHashTextBox;
        private Label resultText;
        private Button md5CopyButton;
        private Button sha256CopyButton;
        private Button sha1CopyButton;
        private Button minimizeButton;
        private Label label7;
        private Button button1;
    }
}