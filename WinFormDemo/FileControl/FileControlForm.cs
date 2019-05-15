using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace WinFormDemo.FileControl
{
    public partial class FileControlForm : Form
    {
        public FileControlForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 操作driverInfo类
        /// </summary>
        private void GetDrivers()
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo driver in drivers)
            {
                // 指示驱动器上的可用空闲空间量
                long availableFreeSpace = driver.AvailableFreeSpace;
                // 获取文件系统的名称，例如NTFS或FAT32
                string driveFormat = driver.DriveFormat;
                // 获取驱动器类型
                DriveType driveType = driver.DriveType;
                // 获取一个指示驱动器是否已准备好的值
                bool isReady = driver.IsReady;
                // 获取驱动器的名称
                string name = driver.Name;
                // 获取驱动器的根目录
                DirectoryInfo rootDirectory = driver.RootDirectory;
                // 获取驱动器上的可用空闲空间总量
                long totalFreeSpace = driver.TotalFreeSpace;
                // 获取驱动器上存储空间的总大小
                long totalSize = driver.TotalSize;
                // 获取或设置驱动器的卷标
                string volumeLabel = driver.VolumeLabel;

                textBoxOutput.Text += string.Format("驱动器名称：{0}\r\n", driver.Name);
                textBoxOutput.Text += string.Format("\t可用空闲空间量：{0}\t文件系统名称：{1}\r\n", availableFreeSpace, driveFormat);
                textBoxOutput.Text += string.Format("\t驱动器类型：{0}\t\t是否已准备好：{1}\r\n", driveType, isReady);
                textBoxOutput.Text += string.Format("\t驱动器的根目录：{0}\t\t可用空闲空间总量：{1}\r\n", rootDirectory, totalFreeSpace);
                textBoxOutput.Text += string.Format("\t存储空间的总大小：{0}\t驱动器的卷标：{1}\r\n", totalSize, volumeLabel);
                textBoxOutput.Select(textBoxOutput.TextLength, 0);
                textBoxOutput.ScrollToCaret();
            }
        }

        private void buttonGetDrivers_Click(object sender, EventArgs e)
        {
            GetDrivers();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }

        /// <summary>
        /// 操作FolderBrowserDialog类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonView_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            // 获取或设置对话框中在树视图控件上显示的说明文本
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }

                textBoxOutput.Text += "-----------------------------------------------------------------\r\n";

                // 获取或设置对话框中在树视图控件上显示的说明文本
                string description = dialog.Description;
                // 获取或设置从其开始浏览的根文件夹
                SpecialFolder rootFolder = dialog.RootFolder;
                // 获取或设置用户选定的路径
                string selectedPath = dialog.SelectedPath;
                // 获取或设置一个值，该值指示“新建文件夹”按钮是否显示在文件夹浏览对话框中
                bool showNewFolderBtton = dialog.ShowNewFolderButton;

                comboBoxSelectDirectory.Items.Add(selectedPath);
                comboBoxSelectDirectory.SelectedIndex = comboBoxSelectDirectory.Items.Count - 1;

                textBoxOutput.Text += string.Format("已选择文件夹：{0}\r\n", selectedPath);
                textBoxOutput.Text += string.Format("树视图控件上显示的说明文本：{0}\r\n", description);
                textBoxOutput.Text += string.Format("根文件夹：{0}\r\n", rootFolder);
                textBoxOutput.Text += string.Format("“新建文件夹”按钮是否显示在文件夹浏览对话框中：{0}\r\n", showNewFolderBtton);
                textBoxOutput.Text += string.Format("文件夹内目录：\r\n");

                textBoxOutput.Select(textBoxOutput.TextLength, 0);
                textBoxOutput.ScrollToCaret();
            }
        }

        private void FileControlForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectDirectory.Items.Add("D:\\");
            comboBoxSelectDirectory.SelectedIndex = 0;
        }

        private void buttonCreateDirectory_Click(object sender, EventArgs e)
        {
            // 文件夹操作1：按path的指定创建所有目录和子目录
            CreateNotExistDir(comboBoxSelectDirectory.Text);
            DirectoryInfo newDirectory = Directory.CreateDirectory(comboBoxSelectDirectory.Text + @"\新建文件夹");
            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            textBoxOutput.Text += string.Format("创建文件夹：{0} 成功\r\n", newDirectory.FullName);

        }

        private void buttonDeleteDirectory_Click(object sender, EventArgs e)
        {
            string lastError = "";
            DialogResult result = MessageBox.Show("是否删除" + comboBoxSelectDirectory.Text + "?", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            // 文件夹操作2：从指定目录删除空目录
            try
            {
                Directory.Delete(comboBoxSelectDirectory.Text);
            }
            catch (Exception exception)
            {
                lastError = exception.Message;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";

            // 文件夹操作3：确定给定路径是否引用磁盘上的现有目录
            if (!Directory.Exists(comboBoxSelectDirectory.Text))
            {
                textBoxOutput.Text += string.Format("删除文件夹：{0} 成功\r\n", comboBoxSelectDirectory.Text);
            }
            else
            {
                textBoxOutput.Text += string.Format("删除文件夹：{0} 失败，{1}\r\n", comboBoxSelectDirectory.Text, lastError);
            }
        }

        /// <summary>
        /// 文件夹操作4：如果文件夹不存在则创建
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string CreateNotExistDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            if (!dir.Exists)
            {
                DialogResult result = MessageBox.Show(string.Format("文件夹{0}不存在，是否创建？", dir.FullName), "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dir.Create();
                    textBoxOutput.Text += string.Format("该目录不存在，已创建{0}\r\n", dir.FullName);
                }
                else
                {
                    return "";
                }
            }
            else
            {
                textBoxOutput.Text += "该目录已经存在\r\n";
            }

            return dir.FullName;
        }

        /// <summary>
        /// 文件夹操作5：获取子目录枚举
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubDirectory_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBoxSelectDirectory.Text);
            if (!dir.Exists)
            {
                MessageBox.Show("文件夹不存在，请重新选择。");
                return;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            textBoxOutput.Text += comboBoxSelectDirectory.Text + "下的子目录\r\n";
            // 返回指定路径中的目录名称的可枚举集合
            foreach (string dirPath in Directory.EnumerateDirectories(dir.FullName))
            {
                textBoxOutput.Text += string.Format("\t{0}\r\n", dirPath);
            }
        }

        /// <summary>
        /// 文件夹操作6：获取目录下所有文件名的枚举
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFilesInDir_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBoxSelectDirectory.Text);
            if (!dir.Exists)
            {
                MessageBox.Show("文件夹不存在，请重新选择。");
                return;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            textBoxOutput.Text += comboBoxSelectDirectory.Text + "下的文件\r\n";
            // 返回指定路径中的文件名的可枚举集合
            foreach (string filePath in Directory.EnumerateFiles(dir.FullName))
            {
                textBoxOutput.Text += string.Format("\t{0}\r\n", filePath);
            }
        }

        /// <summary>
        /// 文件夹操作7：获取目录下所有文件系统项（文件和文件夹）的枚举
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileSystemEntries_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBoxSelectDirectory.Text);
            if (!dir.Exists)
            {
                MessageBox.Show("文件夹不存在，请重新选择。");
                return;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            textBoxOutput.Text += comboBoxSelectDirectory.Text + "下的文件\r\n";
            // 返回指定路径中的文件系统项（文件和文件夹）的可枚举集合
            foreach (string fileSystemEntries in Directory.EnumerateFileSystemEntries(dir.FullName))
            {
                textBoxOutput.Text += string.Format("\t{0}\r\n", fileSystemEntries);
            }
        }

        private void buttonDirectoryInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBoxSelectDirectory.Text);
            if (!dir.Exists)
            {
                MessageBox.Show("文件夹不存在，请重新选择。");
                return;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";

            // 获取目录的创建日期和时间
            DateTime creationTime = Directory.GetCreationTime(dir.FullName);
            textBoxOutput.Text += string.Format("目录的创建日期和时间：{0}\r\n", creationTime);

            // 获取目录的创建日期和时间，其格式为协调世界时（TUC）
            DateTime creationTimeUtc = Directory.GetCreationTimeUtc(dir.FullName);
            textBoxOutput.Text += string.Format("目录的创建日期和时间（TUC）：{0}\r\n", creationTimeUtc);

            // 获取指定目录中子目录的名称
            string[] directories = Directory.GetDirectories(dir.FullName);
            textBoxOutput.Text += string.Format("指定目录中子目录的名称：{0}\r\n", directories);

            // 返回指定路径的卷信息、根信息或两者同时返回
            string directoryRoot = Directory.GetDirectoryRoot(dir.FullName);
            textBoxOutput.Text += string.Format("指定路径的卷信息、根信息：{0}\r\n", directoryRoot);

            // 返回指定目录中的文件的名称
            string[] files = Directory.GetFiles(dir.FullName);
            foreach (string fileStr in files)
            {
                textBoxOutput.Text += string.Format("指定目录中的文件的名称：{0}\r\n", fileStr);
            }


            // 返回指定目录中所有文件和子目录的名称
            string[] fileSystemEntries = Directory.GetFileSystemEntries(dir.FullName);
            foreach (string fileStr in fileSystemEntries)
            {
                textBoxOutput.Text += string.Format("指定目录中所有文件和子目录的名称：{0}\r\n", fileStr);
            }


            // 返回上次访问指定文件或目录的日期和时间
            DateTime lastAccessTime = Directory.GetLastAccessTime(dir.FullName);
            textBoxOutput.Text += string.Format("上次访问指定文件或目录的日期和时间：{0}\r\n", lastAccessTime);

            // 返回上次访问指定文件或目录的日期和时间，其格式为协调世界时（TUC）
            DateTime lastAccessTimeUtc = Directory.GetLastAccessTimeUtc(dir.FullName);
            textBoxOutput.Text += string.Format("上次访问指定文件或目录的日期和时间（TUC）：{0}\r\n", lastAccessTimeUtc);

            // 返回上次写入指定文件或目录的日期和时间
            DateTime lastWriteTime = Directory.GetLastWriteTime(dir.FullName);
            textBoxOutput.Text += string.Format("上次写入指定文件或目录的日期和时间：{0}\r\n", lastWriteTime);

            // 返回上次写入指定文件或目录的日期和时间，其格式为协调世界时（TUC）
            DateTime lastWriteTimeUtc = Directory.GetLastWriteTimeUtc(dir.FullName);
            textBoxOutput.Text += string.Format("上次写入指定文件或目录的日期和时间（TUC）：{0}\r\n", lastWriteTimeUtc);

            // 检索指定路径的父目录，包括绝对路径和相对路径
            DirectoryInfo parentInfo = Directory.GetParent(dir.FullName);
            textBoxOutput.Text += string.Format("路径的父目录：{0}\r\n", parentInfo);

            // 以下为无参数方法
            textBoxOutput.Text += "以下为无参数方法：\r\n";

            // 检索此计算机上格式为"<盘符>:\"的逻辑驱动器的名称
            string[] logicalDrives = Directory.GetLogicalDrives();
            textBoxOutput.Text += string.Format("\t检索此计算机上格式为\"<盘符>:\\\"的逻辑驱动器的名称：{0}\r\n", logicalDrives);

            // 获取应用程序的当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            textBoxOutput.Text += string.Format("\t应用程序的当前工作目录：{0}\r\n", currentDirectory);
        }

        private void buttonViewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            // *获取或设置对话框是否允许选择多个文件
            dialog.Multiselect = false;

            // *获取或设置文件对话框的标题
            dialog.Title = "请选择文件夹";

            // *筛选文件
            // Filter 属性 赋值为一字符串 用于过滤文件类型;
            // 字符串说明如下：
            // ‘|’分割的两个，一个是注释，一个是真的Filter，显示出来的是那个注释。如果要一次显示多中类型的文件，用分号分开。
            // 如：
            // Open1.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            // 则过滤的文件类型为 “|”号 右边的 *.jpg; *.gif; *.bmp 三种类型文件，在OpenDialog / SaveDialog中显示给用户看的文件类型字符串则是 ：“|”号 左边的 图片文件(*.jpg, *.gif, *.bmp)。
            // 再如：
            // Open1.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            dialog.Filter = "所有文件(*.*)|*.*|文本文档(*.txt)|*.txt";
            // *获取或设置文件对话框中当前选定筛选器的索引
            dialog.FilterIndex = 0;

            // *如果用户省略扩展名，对话框是否显示扩展名
            dialog.AddExtension = true;
            // *如果用户指定不存在文件名，对话框是否显示警告
            dialog.CheckFileExists = true;
            // *如果用户指定不存在路径，对话框是否显示警告
            dialog.CheckPathExists = true;
            // *获取或设置默认文件的扩展名
            dialog.DefaultExt = "docx";
            // *获取或设置对话框是否返回快捷方式引用的文件的位置，或者是否返回快捷方式(.lnk)的位置
            dialog.DereferenceLinks = true;
            // *获取或设置文件对话框显示的初始目录（显示为桌面）
            // dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            // *指定其他文件夹
            dialog.InitialDirectory = @"D:\CSTestFile";
            // *获取或设置是否选定只读复选框框
            dialog.ReadOnlyChecked = false;
            // *获取或设置对话框在关闭前是否还原当前目录
            dialog.RestoreDirectory = true;
            // *获取或设置文件对话框是否显示“帮助”按钮（：如果选择true会改变对话框样式）
            dialog.ShowHelp = false;
            // *获取或设置对话框是否包含只读复选框（：如果选择true会改变对话框样式）
            dialog.ShowReadOnly = false;
            // *获取或设置对话框是否支持显示和保存具有多个文件扩展名的文件
            dialog.SupportMultiDottedExtensions = true;
            // *获取或设置对话框是否只接受有效的win32文件
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // *FileName：文件全路径
                // 获取或设置一个包含在文件对话框中选定的文件名的字符串，（多选文件对话框对应FileNames字符串数组）
                comboBoxSelectFile.Items.Add(dialog.FileName);
                comboBoxSelectFile.SelectedIndex = comboBoxSelectFile.Items.Count - 1;

                // *SafeFileName：文件名和扩展名
                // 获取对话框中所选文件的文件名和扩展名，文件名不包含路径（多选文件对话框对应SafeFileNames字符串数组）
                // MessageBox.Show(dialog.SafeFileName);
            }

            // OpenFileDialog控件有以下常用事件
            // FileOk 当用户点击"打开"或"保存"按钮时要处理的事件
            // HelpRequest 当用户点击"帮助"按钮时要处理的事件
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectFile.Text == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            FileInfo file = new FileInfo(comboBoxSelectFile.Text);
            // *Exists指示文件是否存在的值
            if (!file.Exists)
            {
                MessageBox.Show("找不到文件：" + file.FullName);
                return;
            }

            // 在C#窗体中使用代码实现文件的打开，用的是进程的思想，即Windows中每个软件都是一个进程，
            // 我们平时在电脑中自己打开一个txt文件就是打开一个进程，在代码中同样可以实现打开文件的功能。

            // 关键语句就是：
            // System.Diagnostics.Process csProcess = System.Diagnostics.Process.Start(fileFullName);
            // 在没有设置文件的权限时，文件是不可改变的，所以以上代码中，如果不实现
            // f.Attributes = System.IO.FileAttributes.ReadOnly;
            // 文件打开后也是不能更改的。
            // 了使文件能够修改，要设置成 f.Attributes = System.IO.FileAttributes.Normal;

            // 设置文件的属性主要用到了FileInfo类的Attributes属性。

            // 设置文件属性为只读
            // file.Attributes = FileAttributes.ReadOnly;
            // 设置文件属性为正常
            // file.Attributes = FileAttributes.Normal;

            Process csProcess = Process.Start(file.FullName);
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            string path;
            FileInfo file;

            if ((path = comboBoxSelectFile.Text) == "")
            {
                MessageBox.Show("请先指定文件路径");
                return;
            }

            if ((file = new FileInfo(path)).Exists)
            {
                MessageBox.Show("文件已存在，请修改文件名");
                return;
            }

            // *使用对象来新建文件
            // file.Create();
            // *使用静态类来新建文件
            // 调用此方法创建文件之后会返回一个FileStream对象，如果不调用Dispose()方法，文件资源会一直被占用
            File.Create(path).Dispose();

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";

            // FileInfo类调用Create()方法后Exists属性并不会更新，需要重新加载文件才能判断文件是否存在。
            file = new FileInfo(path);
            if (file.Exists)
            {
                textBoxOutput.Text += "新建文件：“" + file.FullName + "”成功\r\n";
            }
            else
            {
                textBoxOutput.Text += "新建文件：“" + file.FullName + "”失败\r\n";
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            string path;
            FileInfo file;

            if ((path = comboBoxSelectFile.Text) == "")
            {
                MessageBox.Show("请先指定文件路径");
                return;
            }

            if (!(file = new FileInfo(path)).Exists)
            {
                MessageBox.Show("文件不存在，请先新建文件");
                return;
            }

            file = new FileInfo(path);
            file.Open(FileMode.Open);
        }

        private void buttonCopyFile_Click(object sender, EventArgs e)
        {
            string srcPath, copyPath;
            string lastError = "";
            if ((srcPath = comboBoxSelectFile.Text) == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            FileInfo file = new FileInfo(comboBoxSelectFile.Text);
            // *Exists指示文件是否存在的值
            if (!file.Exists)
            {
                MessageBox.Show("找不到文件：" + file.FullName);
                return;
            }

            // *复制文件（复制到桌面）
            copyPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\" + file.Name.Insert(file.Name.LastIndexOf('.'), "_复制");
            try
            {
                File.Copy(file.FullName, copyPath);
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }


            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            file = new FileInfo(copyPath);
            if (lastError.Length == 0)
            {
                textBoxOutput.Text += "已将文件：“" + srcPath + "”复制到“" + copyPath + "”\r\n";
            }
            else
            {
                textBoxOutput.Text += "复制操作失败：" + lastError + "\r\n";
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            string path, lastError = "";

            if ((path = comboBoxSelectFile.Text) == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            // *Exists指示文件是否存在的值
            if (!File.Exists(path))
            {
                MessageBox.Show("找不到文件：" + path);
                return;
            }

            if (MessageBox.Show("是否删除文件“" + path + "”？", "提示", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            if (lastError.Length == 0)
            {
                textBoxOutput.Text += "文件：“" + path + "”已成功删除\r\n";
            }
            else
            {
                textBoxOutput.Text += "删除文件失败：“" + lastError + "\r\n";
            }
        }

        private void buttonMoveFile_Click(object sender, EventArgs e)
        {
            string path, newPath, newName, lastError = "";

            if ((path = comboBoxSelectFile.Text) == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            // *Exists指示文件是否存在的值
            if (!File.Exists(path))
            {
                MessageBox.Show("找不到文件：" + path);
                return;
            }

            newPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            newName = path.Substring(path.LastIndexOf('\\') + 1, path.Length - path.LastIndexOf('\\') - 1);
            newName = newName.Insert(newName.LastIndexOf('.'), "_移动");

            if (MessageBox.Show("是否移动文件“" + path + "”到路径“" + newPath + "”？", "提示", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                File.Move(path, newPath + @"\" + newName);
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            if (lastError.Length == 0)
            {
                textBoxOutput.Text += "文件：“" + path + "”已移动到“" + newPath + @"\" + newName + "”\r\n";
            }
            else
            {
                textBoxOutput.Text += "移动文件失败：“" + lastError + "\r\n";
            }
        }

        private void buttonReplaceFile_Click(object sender, EventArgs e)
        {
            string path = comboBoxSelectFile.Text;
            string directory, newFilePath, lastError = "";

            if (comboBoxSelectFile.Text.Length == 0)
            {
                MessageBox.Show("请先选择要被替换的文件");
                return;
            }


            if (!File.Exists(path))
            {
                MessageBox.Show("该文件不存在，请重新选择");
                return;
            }

            // 获取桌面路径
            directory = path.Substring(0, path.LastIndexOf('\\'));
            // *使用Path.Combine()合并两个路径
            newFilePath = Path.Combine(directory, "newFile.txt");

            // 先在桌面创建一个文件
            File.Create(newFilePath).Dispose();

            try
            {
                // *文件替换：将第一个文件的内容覆盖到第二个文件的内容，然后删除第一个文件，
                // 第三个文件是第二个文件的备份
                File.Replace(newFilePath, path, Path.Combine(directory, "backupFile.txt"));
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            if (lastError.Length == 0)
            {
                textBoxOutput.Text += "替换成功\r\n";
            }
            else
            {
                textBoxOutput.Text += "替换失败失败：“" + lastError + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBoxSelectFile.Text;
            string lastError = "";

            if (path.Length == 0)
            {
                MessageBox.Show("请先选择要操作的文件");
                return;
            }

            if (textBoxString.Text.Length == 0)
            {
                MessageBox.Show("请输入字符串");
                return;
            }

            try
            {
                // 打开一个文件，向其中追加指定的字符串。然后关闭该文件。
                // 如果文件不存在，此方法创建一个文件，将指定的字符串写入文件，然后关闭该文件
                // * 在文件末尾写入，不换行。
                // File.AppendAllText(path, textBoxString.Text);

                // 在一个文本中追加文本行，然后关闭该文件
                // * 第一行不换行，后面的换行，相当于添加一个字符串在后面加换行符
                // File.AppendAllLines(path, new string[] { textBoxString.Text });

                // 创建一个StreamWriter，它将UTF-8编码文本追加到现有文件
                StreamWriter sw = File.AppendText(path);
                // 可以在末尾加\n换行
                // sw.Write(textBoxString.Text + '\n');
                // 也可以像Console.WriteLine()一样直接用方法换行。
                sw.WriteLine(textBoxString.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";
            if (lastError.Length == 0)
            {
                textBoxOutput.Text += "追加成功\r\n";
            }
            else
            {
                textBoxOutput.Text += "追加失败：“" + lastError + "\r\n";
            }
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string path = comboBoxSelectFile.Text;
            string lastError = "";
            string text = "";
            string[] lines;
            byte[] stringBytes;

            if (path.Length == 0)
            {
                MessageBox.Show("请先选择要操作的文件");
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("文件不存在，请重新选择");
                return;
            }

            textBoxOutput.Text += "-----------------------------------------------------------------\r\n";

            try
            {
                // *打开一个文件，读取文件的所有行，然后关闭该文件
                text = File.ReadAllText(path);
                textBoxOutput.Text += text;

                // *返回文件的文本行（IEnumerator 集合访问器）
                // foreach (string s in File.ReadLines(path))
                // {
                //     textBoxOutput.Text += s + "\r\n";
                // }

                // *打开一个文本文件，读取文件的所有行，然后关闭该文件
                // lines = File.ReadAllLines(path);
                // foreach (string s in lines)
                // {
                //     textBoxOutput.Text += s + "\r\n";
                // }

                // *打开一个文件，将文件的内容读入一个字符串，然后关闭该文件
                //stringBytes = File.ReadAllBytes(path);
                //textBoxOutput.Text += System.Text.Encoding.UTF8.GetString(stringBytes);
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }


            if (lastError.Length == 0)
            {
            }
            else
            {
                textBoxOutput.Text += "读取失败：“" + lastError + "\r\n";
            }
        }
    }
}
