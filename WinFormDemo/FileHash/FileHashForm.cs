using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormDemo.FileHash
{
    public partial class FileHashForm : Form
    {
        private string _filePath;
        private string _fileName;

        public FileHashForm()
        {
            InitializeComponent();
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            // DragEventArgs.Data.GetDataPresent() 确定此实例中存储的数据是否与指定的格式关联，或是否可以转换成指定的格式
            // DataFormats.FileDrop windows文件放置格式
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //重要代码：表明是所有类型的数据，比如文件路径
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            // 获得路径
            _filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            _fileName = _filePath.Substring(_filePath.LastIndexOf('\\') + 1);
            // 计算哈希值
            textBoxOutput.Text += "【" + _fileName + "】哈希值：" + GetFileHash(_filePath) + "\r\n";

            //CompareFile();
            //CreateXml();
        }

        private string GetFileHash(string path)
        {
            HashAlgorithm hash = HashAlgorithm.Create();
            // 获取指定文件的stream对象
            var stream = new FileStream(path, FileMode.Open);
            // 计算指定stream对象的哈希值
            byte[] hashByte = hash.ComputeHash(stream);
            // 关闭stream对象
            stream.Close();

            return BitConverter.ToString(hashByte);
        }

        private void FileHashForm_Load(object sender, EventArgs e)
        {
            // 接收拖放第一步：设置控件AllowDrop为true
            groupBox1.AllowDrop = true;
        }
    }
}
