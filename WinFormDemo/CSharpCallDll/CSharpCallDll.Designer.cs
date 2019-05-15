namespace WinFormDemo.CSharpCallDll
{
    partial class CSharpCallDll
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCallActiveX = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCallCSharp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCallActiveX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "调用ActiveXDll";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCallActiveX
            // 
            this.buttonCallActiveX.AutoSize = true;
            this.buttonCallActiveX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCallActiveX.Location = new System.Drawing.Point(8, 6);
            this.buttonCallActiveX.Name = "buttonCallActiveX";
            this.buttonCallActiveX.Size = new System.Drawing.Size(39, 22);
            this.buttonCallActiveX.TabIndex = 0;
            this.buttonCallActiveX.Text = "调用";
            this.buttonCallActiveX.UseVisualStyleBackColor = true;
            this.buttonCallActiveX.Click += new System.EventHandler(this.buttonCallActiveX_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonCallCSharp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "调用C#Dll";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCallCSharp
            // 
            this.buttonCallCSharp.AutoSize = true;
            this.buttonCallCSharp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCallCSharp.Location = new System.Drawing.Point(8, 6);
            this.buttonCallCSharp.Name = "buttonCallCSharp";
            this.buttonCallCSharp.Size = new System.Drawing.Size(39, 22);
            this.buttonCallCSharp.TabIndex = 1;
            this.buttonCallCSharp.Text = "调用";
            this.buttonCallCSharp.UseVisualStyleBackColor = true;
            // 
            // CSharpCallDll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CSharpCallDll";
            this.Text = "CSharpCallDll";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCallActiveX;
        private System.Windows.Forms.Button buttonCallCSharp;
    }
}