using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormDemo.Attribute
{
    public partial class AttributeForm : Form
    {
        AppSetings appSet = new AppSetings();

        public AttributeForm()
        {
            InitializeComponent();
        }

        private void buttonLoadClass_Click(object sender, EventArgs e)
        {
            // 设置属性列表的数据对象
            propertyGrid1.SelectedObject = appSet;
        }

        private void buttonChangeAttribute_Click(object sender, EventArgs e)
        {
            ChangeAttributeValue changeAttribute = new ChangeAttributeValue(appSet);
            changeAttribute.ShowDialog();
        }
    }

    public class AppSetings
    {
        private string textID;
        private string textName;
        private Size textSize;

        /// <summary>
        /// DisplayName：要显示的名称，如果没有则默认显示属性名
        /// </summary>
        [DisplayName("文本ID")]
        public string TextID
        {
            get { return textID; }
            set { textID = value; }
        }

        public string TextName
        {
            get { return textName; }
            set { textName = value; }
        }

        public Size TextSize
        {
            get { return textSize; }
            set { textSize = value; }
        }

    }
}
