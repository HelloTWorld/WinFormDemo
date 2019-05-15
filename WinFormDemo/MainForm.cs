using System;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开特性例子窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttribute_Click(object sender, EventArgs e)
        {
            Attribute.AttributeForm attributeForm = new Attribute.AttributeForm();
            attributeForm.Show();
        }

        private void buttonFileControl_Click(object sender, EventArgs e)
        {
            FileControl.FileControlForm fileControl = new FileControl.FileControlForm();
            fileControl.Show();
        }

        private void buttonCSharpCallDll_Click(object sender, EventArgs e)
        {
            CSharpCallDll.CSharpCallDll cSharpCallDll = new CSharpCallDll.CSharpCallDll();
            cSharpCallDll.Show();
        }
    }
}
