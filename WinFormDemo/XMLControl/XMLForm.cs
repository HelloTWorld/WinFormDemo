using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WinFormDemo.XMLControl
{
    public partial class XMLForm : Form
    {
        private string _filePath;

        public XMLForm()
        {
            InitializeComponent();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择xml文件";
            dialog.Filter = "XML文件(*.xml)|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxXMLFile.Items.Add(dialog.FileName);
                comboBoxXMLFile.SelectedIndex = comboBoxXMLFile.Items.Count - 1;
            }
        }

        private void comboBoxXMLFile_SelectedValueChanged(object sender, EventArgs e)
        {
            // FileInfo xmlFile = new FileInfo(comboBoxXMLFile.Text);
            if (!File.Exists(comboBoxXMLFile.Text))
            {
                return;
            }
            else
            {
                _filePath = comboBoxXMLFile.Text;
                textBoxPreview.Text = File.ReadAllText(_filePath);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_filePath, textBoxPreview.Text);
        }

        private void buttonAddfileElement_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxXMLFile.Text.Length == 0)
                return;

            XmlDocument receivedAppCastDocument = new XmlDocument();
            receivedAppCastDocument.Load(comboBoxXMLFile.Text);

            // 获取conpoment节点
            XmlNodeList appCastConpoment = receivedAppCastDocument.SelectNodes("conpoment");

            if (appCastConpoment != null)
            {
                // 遍历conpoment节点中的每个节点
                foreach (XmlNode conpoment in appCastConpoment)
                {
                    // 获取最新版本号节点
                    XmlNode appCastVersion = conpoment.SelectSingleNode("version");

                    
                }
            }
        }

        //public void CreateXml()
        //{
        //    //创建XmlDocument对象
        //    XmlDocument xmlDoc = new XmlDocument();
        //    //XML的声明<?xml version="1.0" encoding="UTF-8"?> 
        //    XmlDeclaration xmlSM = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        //    //追加xmldecl位置
        //    xmlDoc.AppendChild(xmlSM);
        //    //添加一个名为Gen的根节点
        //    XmlElement conpoment = xmlDoc.CreateElement("", "conpoment", "");
        //    //追加Gen的根节点位置
        //    xmlDoc.AppendChild(conpoment);

        //    //添加另一个节点,与Gen所匹配，查找<Gen>
        //    XmlNode conpomentNode = xmlDoc.SelectSingleNode("conpoment");
        //    //添加一个名为<file>的节点   
        //    XmlElement fileElement = xmlDoc.CreateElement("file");
        //    //为<file>节点的属性
        //    fileElement.SetAttribute("name", "zy_yw.dll");
        //    XmlElement versionElement = xmlDoc.CreateElement("version");
        //    //InnerText:获取或设置节点及其所有子节点的串连值
        //    versionElement.InnerText = "1.0.0.0";
        //    fileElement.AppendChild(versionElement);//添加到<file>节点中

        //    XmlElement hashElement = xmlDoc.CreateElement("hash");
        //    hashElement.InnerText = _fileHash;
        //    fileElement.AppendChild(hashElement);
        //    conpoment.AppendChild(fileElement);//添加到<Gen>节点中   

        //    //保存好创建的XML文档
        //    xmlDoc.Save("D:/data.xml");
        //    MessageBox.Show("xmlfile has created!");
        //}
    }
}
