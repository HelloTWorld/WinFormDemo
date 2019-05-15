namespace WinFormDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAttribute = new System.Windows.Forms.Button();
            this.buttonFileControl = new System.Windows.Forms.Button();
            this.buttonXMLControl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCSharpCallDll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonAttribute
            // 
            this.buttonAttribute.AutoSize = true;
            this.buttonAttribute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAttribute.Location = new System.Drawing.Point(25, 22);
            this.buttonAttribute.Name = "buttonAttribute";
            this.buttonAttribute.Size = new System.Drawing.Size(117, 22);
            this.buttonAttribute.TabIndex = 0;
            this.buttonAttribute.Text = "Attribute(undone)";
            this.buttonAttribute.UseVisualStyleBackColor = true;
            this.buttonAttribute.Click += new System.EventHandler(this.buttonAttribute_Click);
            // 
            // buttonFileControl
            // 
            this.buttonFileControl.AutoSize = true;
            this.buttonFileControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFileControl.Location = new System.Drawing.Point(25, 65);
            this.buttonFileControl.Name = "buttonFileControl";
            this.buttonFileControl.Size = new System.Drawing.Size(111, 22);
            this.buttonFileControl.TabIndex = 1;
            this.buttonFileControl.Text = "文件操作(undone)";
            this.buttonFileControl.UseVisualStyleBackColor = true;
            this.buttonFileControl.Click += new System.EventHandler(this.buttonFileControl_Click);
            // 
            // buttonXMLControl
            // 
            this.buttonXMLControl.AutoSize = true;
            this.buttonXMLControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonXMLControl.Location = new System.Drawing.Point(25, 110);
            this.buttonXMLControl.Name = "buttonXMLControl";
            this.buttonXMLControl.Size = new System.Drawing.Size(57, 22);
            this.buttonXMLControl.TabIndex = 2;
            this.buttonXMLControl.Text = "XML操作";
            this.buttonXMLControl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(25, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "拖拽文件并计算哈希值";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCSharpCallDll
            // 
            this.buttonCSharpCallDll.AutoSize = true;
            this.buttonCSharpCallDll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCSharpCallDll.Location = new System.Drawing.Point(25, 195);
            this.buttonCSharpCallDll.Name = "buttonCSharpCallDll";
            this.buttonCSharpCallDll.Size = new System.Drawing.Size(93, 22);
            this.buttonCSharpCallDll.TabIndex = 4;
            this.buttonCSharpCallDll.Text = "C#动态调用dll";
            this.buttonCSharpCallDll.UseVisualStyleBackColor = true;
            this.buttonCSharpCallDll.Click += new System.EventHandler(this.buttonCSharpCallDll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(237, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCSharpCallDll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonXMLControl);
            this.Controls.Add(this.buttonFileControl);
            this.Controls.Add(this.buttonAttribute);
            this.Name = "MainForm";
            this.Text = "主菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAttribute;
        private System.Windows.Forms.Button buttonFileControl;
        private System.Windows.Forms.Button buttonXMLControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCSharpCallDll;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

