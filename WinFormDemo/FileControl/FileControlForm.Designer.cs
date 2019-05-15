namespace WinFormDemo.FileControl
{
    partial class FileControlForm
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetDrivers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDirectoryInfo = new System.Windows.Forms.Button();
            this.buttonFileSystemEntries = new System.Windows.Forms.Button();
            this.buttonFilesInDir = new System.Windows.Forms.Button();
            this.buttonSubDirectory = new System.Windows.Forms.Button();
            this.buttonDeleteDirectory = new System.Windows.Forms.Button();
            this.comboBoxSelectDirectory = new System.Windows.Forms.ComboBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReplaceFile = new System.Windows.Forms.Button();
            this.buttonMoveFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonCopyFile = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonViewFile = new System.Windows.Forms.Button();
            this.comboBoxSelectFile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(3, 262);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(770, 22);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetDrivers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "驱动信息";
            // 
            // buttonGetDrivers
            // 
            this.buttonGetDrivers.AutoSize = true;
            this.buttonGetDrivers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGetDrivers.Location = new System.Drawing.Point(6, 20);
            this.buttonGetDrivers.Name = "buttonGetDrivers";
            this.buttonGetDrivers.Size = new System.Drawing.Size(87, 22);
            this.buttonGetDrivers.TabIndex = 3;
            this.buttonGetDrivers.Text = "加载驱动信息";
            this.buttonGetDrivers.UseVisualStyleBackColor = true;
            this.buttonGetDrivers.Click += new System.EventHandler(this.buttonGetDrivers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDirectoryInfo);
            this.groupBox2.Controls.Add(this.buttonFileSystemEntries);
            this.groupBox2.Controls.Add(this.buttonFilesInDir);
            this.groupBox2.Controls.Add(this.buttonSubDirectory);
            this.groupBox2.Controls.Add(this.buttonDeleteDirectory);
            this.groupBox2.Controls.Add(this.comboBoxSelectDirectory);
            this.groupBox2.Controls.Add(this.buttonView);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonCreateDirectory);
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目录操作";
            // 
            // buttonDirectoryInfo
            // 
            this.buttonDirectoryInfo.AutoSize = true;
            this.buttonDirectoryInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDirectoryInfo.Location = new System.Drawing.Point(533, 48);
            this.buttonDirectoryInfo.Name = "buttonDirectoryInfo";
            this.buttonDirectoryInfo.Size = new System.Drawing.Size(93, 22);
            this.buttonDirectoryInfo.TabIndex = 13;
            this.buttonDirectoryInfo.Text = "Directory信息";
            this.buttonDirectoryInfo.UseVisualStyleBackColor = true;
            this.buttonDirectoryInfo.Click += new System.EventHandler(this.buttonDirectoryInfo_Click);
            // 
            // buttonFileSystemEntries
            // 
            this.buttonFileSystemEntries.AutoSize = true;
            this.buttonFileSystemEntries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFileSystemEntries.Location = new System.Drawing.Point(332, 48);
            this.buttonFileSystemEntries.Name = "buttonFileSystemEntries";
            this.buttonFileSystemEntries.Size = new System.Drawing.Size(195, 22);
            this.buttonFileSystemEntries.TabIndex = 12;
            this.buttonFileSystemEntries.Text = "目录内文件系统项(文件与文件夹)";
            this.buttonFileSystemEntries.UseVisualStyleBackColor = true;
            this.buttonFileSystemEntries.Click += new System.EventHandler(this.buttonFileSystemEntries_Click);
            // 
            // buttonFilesInDir
            // 
            this.buttonFilesInDir.AutoSize = true;
            this.buttonFilesInDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilesInDir.Location = new System.Drawing.Point(251, 48);
            this.buttonFilesInDir.Name = "buttonFilesInDir";
            this.buttonFilesInDir.Size = new System.Drawing.Size(75, 22);
            this.buttonFilesInDir.TabIndex = 11;
            this.buttonFilesInDir.Text = "目录内文件";
            this.buttonFilesInDir.UseVisualStyleBackColor = true;
            this.buttonFilesInDir.Click += new System.EventHandler(this.buttonFilesInDir_Click);
            // 
            // buttonSubDirectory
            // 
            this.buttonSubDirectory.AutoSize = true;
            this.buttonSubDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubDirectory.Location = new System.Drawing.Point(170, 48);
            this.buttonSubDirectory.Name = "buttonSubDirectory";
            this.buttonSubDirectory.Size = new System.Drawing.Size(75, 22);
            this.buttonSubDirectory.TabIndex = 10;
            this.buttonSubDirectory.Text = "子目录集合";
            this.buttonSubDirectory.UseVisualStyleBackColor = true;
            this.buttonSubDirectory.Click += new System.EventHandler(this.buttonSubDirectory_Click);
            // 
            // buttonDeleteDirectory
            // 
            this.buttonDeleteDirectory.AutoSize = true;
            this.buttonDeleteDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteDirectory.Location = new System.Drawing.Point(89, 48);
            this.buttonDeleteDirectory.Name = "buttonDeleteDirectory";
            this.buttonDeleteDirectory.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteDirectory.TabIndex = 9;
            this.buttonDeleteDirectory.Text = "删除文件夹";
            this.buttonDeleteDirectory.UseVisualStyleBackColor = true;
            this.buttonDeleteDirectory.Click += new System.EventHandler(this.buttonDeleteDirectory_Click);
            // 
            // comboBoxSelectDirectory
            // 
            this.comboBoxSelectDirectory.FormattingEnabled = true;
            this.comboBoxSelectDirectory.Location = new System.Drawing.Point(75, 22);
            this.comboBoxSelectDirectory.Name = "comboBoxSelectDirectory";
            this.comboBoxSelectDirectory.Size = new System.Drawing.Size(527, 20);
            this.comboBoxSelectDirectory.TabIndex = 8;
            // 
            // buttonView
            // 
            this.buttonView.AutoSize = true;
            this.buttonView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonView.Location = new System.Drawing.Point(608, 20);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(39, 22);
            this.buttonView.TabIndex = 7;
            this.buttonView.Text = "浏览";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择文件夹：";
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.AutoSize = true;
            this.buttonCreateDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCreateDirectory.Location = new System.Drawing.Point(8, 48);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(75, 22);
            this.buttonCreateDirectory.TabIndex = 4;
            this.buttonCreateDirectory.Text = "新建文件夹";
            this.buttonCreateDirectory.UseVisualStyleBackColor = true;
            this.buttonCreateDirectory.Click += new System.EventHandler(this.buttonCreateDirectory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxOutput);
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 287);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 17);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(770, 245);
            this.textBoxOutput.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonReadFile);
            this.groupBox4.Controls.Add(this.textBoxString);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.buttonReplaceFile);
            this.groupBox4.Controls.Add(this.buttonMoveFile);
            this.groupBox4.Controls.Add(this.buttonDeleteFile);
            this.groupBox4.Controls.Add(this.buttonCopyFile);
            this.groupBox4.Controls.Add(this.buttonCreateFile);
            this.groupBox4.Controls.Add(this.buttonLoadFile);
            this.groupBox4.Controls.Add(this.buttonOpenFile);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonViewFile);
            this.groupBox4.Controls.Add(this.comboBoxSelectFile);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 167);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文件操作";
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(54, 49);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(536, 21);
            this.textBoxString.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "字符串：";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(327, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "追加字符串";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReplaceFile
            // 
            this.buttonReplaceFile.AutoSize = true;
            this.buttonReplaceFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReplaceFile.Location = new System.Drawing.Point(282, 77);
            this.buttonReplaceFile.Name = "buttonReplaceFile";
            this.buttonReplaceFile.Size = new System.Drawing.Size(39, 22);
            this.buttonReplaceFile.TabIndex = 19;
            this.buttonReplaceFile.Text = "替换";
            this.buttonReplaceFile.UseVisualStyleBackColor = true;
            this.buttonReplaceFile.Click += new System.EventHandler(this.buttonReplaceFile_Click);
            // 
            // buttonMoveFile
            // 
            this.buttonMoveFile.AutoSize = true;
            this.buttonMoveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMoveFile.Location = new System.Drawing.Point(237, 77);
            this.buttonMoveFile.Name = "buttonMoveFile";
            this.buttonMoveFile.Size = new System.Drawing.Size(39, 22);
            this.buttonMoveFile.TabIndex = 18;
            this.buttonMoveFile.Text = "移动";
            this.buttonMoveFile.UseVisualStyleBackColor = true;
            this.buttonMoveFile.Click += new System.EventHandler(this.buttonMoveFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.AutoSize = true;
            this.buttonDeleteFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteFile.Location = new System.Drawing.Point(192, 77);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(39, 22);
            this.buttonDeleteFile.TabIndex = 17;
            this.buttonDeleteFile.Text = "删除";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.AutoSize = true;
            this.buttonCopyFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCopyFile.Location = new System.Drawing.Point(123, 77);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(63, 22);
            this.buttonCopyFile.TabIndex = 16;
            this.buttonCopyFile.Text = "复制文件";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopyFile_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.AutoSize = true;
            this.buttonCreateFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCreateFile.Location = new System.Drawing.Point(54, 77);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(63, 22);
            this.buttonCreateFile.TabIndex = 12;
            this.buttonCreateFile.Text = "新建文件";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.AutoSize = true;
            this.buttonLoadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLoadFile.Location = new System.Drawing.Point(147, 103);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(63, 22);
            this.buttonLoadFile.TabIndex = 13;
            this.buttonLoadFile.Text = "加载文件";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.AutoSize = true;
            this.buttonOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenFile.Location = new System.Drawing.Point(78, 103);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(63, 22);
            this.buttonOpenFile.TabIndex = 11;
            this.buttonOpenFile.Text = "打开文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "FileInfo类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "File类：";
            // 
            // buttonViewFile
            // 
            this.buttonViewFile.AutoSize = true;
            this.buttonViewFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewFile.Location = new System.Drawing.Point(596, 21);
            this.buttonViewFile.Name = "buttonViewFile";
            this.buttonViewFile.Size = new System.Drawing.Size(39, 22);
            this.buttonViewFile.TabIndex = 10;
            this.buttonViewFile.Text = "浏览";
            this.buttonViewFile.UseVisualStyleBackColor = true;
            this.buttonViewFile.Click += new System.EventHandler(this.buttonViewFile_Click);
            // 
            // comboBoxSelectFile
            // 
            this.comboBoxSelectFile.FormattingEnabled = true;
            this.comboBoxSelectFile.Location = new System.Drawing.Point(63, 23);
            this.comboBoxSelectFile.Name = "comboBoxSelectFile";
            this.comboBoxSelectFile.Size = new System.Drawing.Size(527, 20);
            this.comboBoxSelectFile.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "选择文件：";
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.AutoSize = true;
            this.buttonReadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReadFile.Location = new System.Drawing.Point(408, 76);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(39, 22);
            this.buttonReadFile.TabIndex = 23;
            this.buttonReadFile.Text = "读取";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // FileControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileControlForm";
            this.Text = "FileControl";
            this.Load += new System.EventHandler(this.FileControlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetDrivers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateDirectory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectDirectory;
        private System.Windows.Forms.Button buttonDeleteDirectory;
        private System.Windows.Forms.Button buttonSubDirectory;
        private System.Windows.Forms.Button buttonFilesInDir;
        private System.Windows.Forms.Button buttonFileSystemEntries;
        private System.Windows.Forms.Button buttonDirectoryInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonViewFile;
        private System.Windows.Forms.ComboBox comboBoxSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCopyFile;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Button buttonMoveFile;
        private System.Windows.Forms.Button buttonReplaceFile;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReadFile;
    }
}