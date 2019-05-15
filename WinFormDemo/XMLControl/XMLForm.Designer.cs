namespace WinFormDemo.XMLControl
{
    partial class XMLForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxXMLFile = new System.Windows.Forms.ComboBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddfileElement = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preview:";
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreview.Location = new System.Drawing.Point(12, 229);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(845, 429);
            this.textBoxPreview.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择XML文件：";
            // 
            // comboBoxXMLFile
            // 
            this.comboBoxXMLFile.FormattingEnabled = true;
            this.comboBoxXMLFile.Location = new System.Drawing.Point(87, 6);
            this.comboBoxXMLFile.Name = "comboBoxXMLFile";
            this.comboBoxXMLFile.Size = new System.Drawing.Size(370, 20);
            this.comboBoxXMLFile.TabIndex = 3;
            this.comboBoxXMLFile.SelectedValueChanged += new System.EventHandler(this.comboBoxXMLFile_SelectedValueChanged);
            // 
            // buttonView
            // 
            this.buttonView.AutoSize = true;
            this.buttonView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonView.Location = new System.Drawing.Point(463, 6);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(39, 22);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "浏览";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Location = new System.Drawing.Point(818, 201);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(39, 22);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddfileElement
            // 
            this.buttonAddfileElement.AutoSize = true;
            this.buttonAddfileElement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddfileElement.Location = new System.Drawing.Point(12, 45);
            this.buttonAddfileElement.Name = "buttonAddfileElement";
            this.buttonAddfileElement.Size = new System.Drawing.Size(111, 22);
            this.buttonAddfileElement.TabIndex = 6;
            this.buttonAddfileElement.Text = "添加一个file节点";
            this.buttonAddfileElement.UseVisualStyleBackColor = true;
            this.buttonAddfileElement.Click += new System.EventHandler(this.buttonAddfileElement_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AutoSize = true;
            this.buttonLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLoad.Location = new System.Drawing.Point(129, 45);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(39, 22);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "加载";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // XMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 670);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAddfileElement);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.comboBoxXMLFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPreview);
            this.Controls.Add(this.label1);
            this.Name = "XMLForm";
            this.Text = "XMLForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxXMLFile;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddfileElement;
        private System.Windows.Forms.Button buttonLoad;
    }
}