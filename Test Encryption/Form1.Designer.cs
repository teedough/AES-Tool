namespace Test_Encryption
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geneicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encyptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelProgresslevel = new System.Windows.Forms.Label();
            this.labelSaveMsg = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.TextBox();
            this.labelEncyptAlert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.geneicToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newFileToolStripMenuItem.Text = "New File...";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // geneicToolStripMenuItem
            // 
            this.geneicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encyptionToolStripMenuItem,
            this.decryptionToolStripMenuItem});
            this.geneicToolStripMenuItem.Name = "geneicToolStripMenuItem";
            this.geneicToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.geneicToolStripMenuItem.Text = "Generic";
            // 
            // encyptionToolStripMenuItem
            // 
            this.encyptionToolStripMenuItem.Name = "encyptionToolStripMenuItem";
            this.encyptionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.encyptionToolStripMenuItem.Text = "Encyption";
            this.encyptionToolStripMenuItem.Click += new System.EventHandler(this.encyptionToolStripMenuItem_Click);
            // 
            // decryptionToolStripMenuItem
            // 
            this.decryptionToolStripMenuItem.Name = "decryptionToolStripMenuItem";
            this.decryptionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.decryptionToolStripMenuItem.Text = "Decryption";
            this.decryptionToolStripMenuItem.Click += new System.EventHandler(this.decryptionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(362, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AES Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse file...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(39, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 25);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Encrypt";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBrowse.Location = new System.Drawing.Point(44, 123);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFileName.Location = new System.Drawing.Point(42, 149);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(63, 15);
            this.labelFileName.TabIndex = 5;
            this.labelFileName.Text = "File Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Key: ";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(85, 221);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(185, 20);
            this.textBoxKey.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(42, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter Key";
            // 
            // buttonProcess
            // 
            this.buttonProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProcess.Location = new System.Drawing.Point(44, 270);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(107, 32);
            this.buttonProcess.TabIndex = 9;
            this.buttonProcess.Text = "Encrypt";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(42, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Process..";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.Location = new System.Drawing.Point(45, 378);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save File...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelProgresslevel
            // 
            this.labelProgresslevel.AutoSize = true;
            this.labelProgresslevel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgresslevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProgresslevel.Location = new System.Drawing.Point(42, 315);
            this.labelProgresslevel.Name = "labelProgresslevel";
            this.labelProgresslevel.Size = new System.Drawing.Size(59, 15);
            this.labelProgresslevel.TabIndex = 13;
            this.labelProgresslevel.Text = "0% Done.";
            // 
            // labelSaveMsg
            // 
            this.labelSaveMsg.AutoSize = true;
            this.labelSaveMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveMsg.ForeColor = System.Drawing.Color.Lime;
            this.labelSaveMsg.Location = new System.Drawing.Point(135, 382);
            this.labelSaveMsg.Name = "labelSaveMsg";
            this.labelSaveMsg.Size = new System.Drawing.Size(64, 15);
            this.labelSaveMsg.TabIndex = 14;
            this.labelSaveMsg.Text = "File Saved!";
            this.labelSaveMsg.Visible = false;
            this.labelSaveMsg.Click += new System.EventHandler(this.label9_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(432, 47);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(370, 374);
            this.textArea.TabIndex = 15;
            // 
            // labelEncyptAlert
            // 
            this.labelEncyptAlert.AutoSize = true;
            this.labelEncyptAlert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncyptAlert.ForeColor = System.Drawing.Color.Lime;
            this.labelEncyptAlert.Location = new System.Drawing.Point(157, 279);
            this.labelEncyptAlert.Name = "labelEncyptAlert";
            this.labelEncyptAlert.Size = new System.Drawing.Size(56, 15);
            this.labelEncyptAlert.TabIndex = 16;
            this.labelEncyptAlert.Text = "Encypted";
            this.labelEncyptAlert.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(138, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 25);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Click \"Generic\" to change function";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(832, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEncyptAlert);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.labelSaveMsg);
            this.Controls.Add(this.labelProgresslevel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AES Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geneicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encyptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelProgresslevel;
        private System.Windows.Forms.Label labelSaveMsg;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label labelEncyptAlert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

