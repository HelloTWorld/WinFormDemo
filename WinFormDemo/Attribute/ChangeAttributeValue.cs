using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormDemo.Attribute
{
    public partial class ChangeAttributeValue : Form
    {
        private object _selectObject;
        private PropertyDescriptorCollection _appSetingAttributes;

        public ChangeAttributeValue(object obj)
        {
            InitializeComponent();
            _selectObject = obj;
            // 获取指定组件属性的集合
            _appSetingAttributes = TypeDescriptor.GetProperties(_selectObject);

            //AppSetings appSeting = new AppSetings();
            //appSetingAttributes = TypeDescriptor.GetProperties(appSeting);

            //Type displayType = typeof(DisplayNameAttribute);
            //FieldInfo fieldInfo = displayType.GetField("_displayName", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance);
            //AttributeCollection attrs = appSetingAttributes["TextID"].Attributes;
            //fieldInfo.SetValue(appSetingAttributes["TextID"].Attributes[displayType], "修改后的文本ID");
        }

        private void ChangeAttributeValue_Load(object sender, EventArgs e)
        {
            labelCurrentClass.Text += _selectObject.GetType();

            comboBoxPropertySelect.Items.Clear();
            foreach (PropertyDescriptor pd in _appSetingAttributes)
            {
                comboBoxPropertySelect.Items.Add(pd.Name);
            }
        }

        private void comboBoxPropertySelect_SelectedValueChanged(object sender, EventArgs e)
        {
            AttributeCollection attrs = _appSetingAttributes[comboBoxPropertySelect.Text].Attributes;
            foreach (System.Attribute attr in attrs)
            {
                comboBoxAttributeSelect.Items.Add(attr.TypeId);
            }
        }

        private void comboBoxPropertySelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
