namespace WinFormDemo.Attribute
{
    partial class AttributeForm
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.buttonLoadClass = new System.Windows.Forms.Button();
            this.buttonChangeAttribute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(221, 450);
            this.propertyGrid1.TabIndex = 0;
            // 
            // buttonLoadClass
            // 
            this.buttonLoadClass.Location = new System.Drawing.Point(265, 26);
            this.buttonLoadClass.Name = "buttonLoadClass";
            this.buttonLoadClass.Size = new System.Drawing.Size(82, 29);
            this.buttonLoadClass.TabIndex = 1;
            this.buttonLoadClass.Text = "加载类";
            this.buttonLoadClass.UseVisualStyleBackColor = true;
            this.buttonLoadClass.Click += new System.EventHandler(this.buttonLoadClass_Click);
            // 
            // buttonChangeAttribute
            // 
            this.buttonChangeAttribute.Location = new System.Drawing.Point(265, 76);
            this.buttonChangeAttribute.Name = "buttonChangeAttribute";
            this.buttonChangeAttribute.Size = new System.Drawing.Size(82, 29);
            this.buttonChangeAttribute.TabIndex = 2;
            this.buttonChangeAttribute.Text = "修改特性值";
            this.buttonChangeAttribute.UseVisualStyleBackColor = true;
            this.buttonChangeAttribute.Click += new System.EventHandler(this.buttonChangeAttribute_Click);
            // 
            // AttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeAttribute);
            this.Controls.Add(this.buttonLoadClass);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "AttributeForm";
            this.Text = "AttributeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button buttonLoadClass;
        private System.Windows.Forms.Button buttonChangeAttribute;
    }
}