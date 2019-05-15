using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormDemo.CSharpCallDll
{
    public partial class CSharpCallDll : Form
    {
        [DllImport("User32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern int Swl(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("User32.dll", EntryPoint = "GetWindowLong")]
        public static extern int Gwl(IntPtr hWnd, int nlndex);

        [DllImport("user32.dll", EntryPoint = "SetFocus")]
        private static extern IntPtr SFc(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);

        private const int GWL_STYLE = (-16);
        private const int WS_BORDER = 0x00800000;
        private const int WS_CAPTION = 0x00C00000;

        public CSharpCallDll()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 调用ActiveXDll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [HandleProcessCorruptedStateExceptions]
        private void buttonCallActiveX_Click(object sender, EventArgs e)
        {
            string className;
            Type type;
            object ins = null;
            object result = null;

            // 需要先使用regsvr32注册dll
            className = "CSharpDll.StartClass";
            // 获取类型
            type = Type.GetTypeFromProgID(className);
            //type = Type.GetTypeFromProgID("CSharpDll.dll返回窗体");
            type = Type.GetTypeFromProgID("CSharpDll.My.Forms");
            

            if (type != null)
            {
                try
                {
                    // 创建类实例
                    // 创建ActiveX实例前需要把项目属性设置为32位，不然会报检索COM类工厂组件失败：没有注册类。
                    ins = Activator.CreateInstance(type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            if (ins != null)
            {
                try
                {
                    // type.InvokeMember("dll返回窗体", BindingFlags.in)
                    // 调用类方法 获取返回句柄
                    // result = type.InvokeMember("GetHwnd", BindingFlags.InvokeMethod, null, ins, new object[] { "dll返回窗体", "000", "999" });
                    var vvv = type.InvokeMember("GetObject", BindingFlags.InvokeMethod, null, ins, new object[] { "dll返回窗体" });

                    // Control frm = Form.FromHandle((IntPtr)Convert.ToInt32(result));
                    //Form form = new Form();
                    //frm.Visible = true;
                    //form.Controls.Add(frm);
                    //form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

            if (result != null)
            {
                IntPtr dllReturnHwnd = (IntPtr)Convert.ToInt32(result);
                // Swl(dllReturnHwnd, GWL_STYLE, Gwl(dllReturnHwnd, GWL_STYLE) & ~WS_BORDER & ~WS_CAPTION);// & ~WS_MAXIMIZE);
                if (this.Handle != (IntPtr)0)
                    ShowForm(dllReturnHwnd, 3);
            }
            else
            {
                return;
            }

        }


        private void buttonCallActiveX_Click1(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("hello world! {0} ", i);
            }
        }

        /// <summary>
        /// 显示该句柄的窗体
        /// </summary>
        /// <param name="cmdShow">显示模式，参考窗体显示模式</param>
        public void ShowForm(IntPtr handel, int cmdShow)
        {
            //ShowWindowAsync(this.Handel, cmdShow);
            ShowWindow(handel, cmdShow);
            SFc(handel);
        }





    }
}
